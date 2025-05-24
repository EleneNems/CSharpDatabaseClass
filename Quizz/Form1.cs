using Microsoft.EntityFrameworkCore;
using Quizz.Data;
using Quizz.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Quizz
{
    public partial class Form1 : Form
    {
        private int selectedCustomerId = -1;
        private int selectedOrderId = -1;
        private int selectedOrderDetailId = -1;
        private int selectedProductId = -1;
        private int selectedSupplierId = -1;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            using (var context = new AppDbContext())
            {
                dataGridView1.DataSource = context.Customers.ToList();
            }
            ClearCustomerForm();
            selectedCustomerId = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFirstName.Text))
                {
                    MessageBox.Show("First Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFirstName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    MessageBox.Show("Last Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLastName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCity.Text))
                {
                    MessageBox.Show("City is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCity.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCountry.Text))
                {
                    MessageBox.Show("Country is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCountry.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    MessageBox.Show("Phone is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPhone.Focus();
                    return;
                }

                using (var context = new AppDbContext())
                {
                    var customer = new Customer
                    {
                        FirstName = txtFirstName.Text.Trim(),
                        LastName = txtLastName.Text.Trim(),
                        City = txtCity.Text.Trim(),
                        Country = txtCountry.Text.Trim(),
                        Phone = txtPhone.Text.Trim()
                    };

                    context.Customers.Add(customer);
                    context.SaveChanges();
                }

                MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadCustomers();
                ClearCustomerForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId == -1)
            {
                MessageBox.Show("Please select a customer to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            using (var context = new AppDbContext())
            {
                var customer = context.Customers.Find(selectedCustomerId);
                if (customer != null)
                {
                    context.Customers.Remove(customer);
                    context.SaveChanges();

                    MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Customer not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadCustomers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId == -1)
            {
                MessageBox.Show("Please select a customer to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Phone number cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            using (var context = new AppDbContext())
            {
                var customer = context.Customers.Find(selectedCustomerId);
                if (customer != null)
                {
                    customer.FirstName = txtFirstName.Text.Trim();
                    customer.LastName = txtLastName.Text.Trim();
                    customer.City = txtCity.Text.Trim();
                    customer.Country = txtCountry.Text.Trim();
                    customer.Phone = txtPhone.Text.Trim();

                    context.SaveChanges();

                    MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Customer not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadCustomers();
        }

        private void btnLoadOrders_Click_1(object sender, EventArgs e)
        {
            LoadOrders();
            LoadCustomerCombo();
        }

        private void LoadCustomerCombo()
        {
            using (var context = new AppDbContext())
            {
                cmbCustomers.DataSource = context.Customers
                    .Select(c => new { c.Id, FullName = c.FirstName + " " + c.LastName })
                    .ToList();

                cmbCustomers.DisplayMember = "FullName";
                cmbCustomers.ValueMember = "Id";
            }
        }

        private void LoadOrders()
        {
            using (var context = new AppDbContext())
            {
                var orders = context.Orders
                    .Select(o => new
                    {
                        o.Id,
                        o.OrderNumber,
                        o.OrderDate,
                        Customer = o.Customer.FirstName + " " + o.Customer.LastName,
                        o.TotalAmount
                    })
                    .ToList();

                dataGridView1.DataSource = orders;
            }

            ClearOrderForm();
            selectedOrderId = -1;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtOrderNumber.Text))
                {
                    MessageBox.Show("Order Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtOrderNumber.Focus();
                    return;
                }

                if (cmbCustomers.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a customer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbCustomers.Focus();
                    return;
                }

                using (var context = new AppDbContext())
                {
                    var order = new Order
                    {
                        OrderNumber = txtOrderNumber.Text.Trim(),
                        OrderDate = dtpOrderDate.Value,
                        CustomerId = (int)cmbCustomers.SelectedValue,
                    };

                    context.Orders.Add(order);
                    context.SaveChanges();
                }

                MessageBox.Show("Order added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadOrders();
                ClearOrderForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDeleteOrder_Click_1(object sender, EventArgs e)
        {
            if (selectedOrderId == -1)
            {
                MessageBox.Show("Please select an order to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this order?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            using (var context = new AppDbContext())
            {
                var order = context.Orders.Find(selectedOrderId);
                if (order != null)
                {
                    context.Orders.Remove(order);
                    context.SaveChanges();

                    MessageBox.Show("Order deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Order not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadOrders();
        }

        private void btnUpdateOrders_Click(object sender, EventArgs e)
        {
            if (selectedOrderId == -1)
            {
                MessageBox.Show("Please select an order to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtOrderNumber.Text))
            {
                MessageBox.Show("Order number cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOrderNumber.Focus();
                return;
            }

            if (cmbCustomers.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a customer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCustomers.Focus();
                return;
            }

            using (var context = new AppDbContext())
            {
                var order = context.Orders.Find(selectedOrderId);
                if (order != null)
                {
                    order.OrderNumber = txtOrderNumber.Text.Trim();
                    order.OrderDate = dtpOrderDate.Value;
                    order.CustomerId = (int)cmbCustomers.SelectedValue;

                    context.SaveChanges();

                    MessageBox.Show("Order updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Order not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadOrders();
        }

        private void LoadOrderAndProductCombos()
        {
            using (var context = new AppDbContext())
            {
                cmbOrders.DataSource = context.Orders.Select(o => new { o.Id, o.OrderNumber }).ToList();
                cmbOrders.DisplayMember = "OrderNumber";
                cmbOrders.ValueMember = "Id";

                cmbProducts.DataSource = context.Products.Select(p => new { p.Id, p.ProductName }).ToList();
                cmbProducts.DisplayMember = "ProductName";
                cmbProducts.ValueMember = "Id";
            }
        }

        private void LoadOrderDetails()
        {
            using (var context = new AppDbContext())
            {
                var details = context.OrderItems
                    .Select(oi => new
                    {
                        oi.Id,
                        OrderNumber = oi.Order.OrderNumber,
                        ProductName = oi.Product.ProductName,
                        oi.Quantity,
                        oi.UnitPrice
                    })
                    .ToList();

                dataGridView1.DataSource = details;
            }

            LoadOrderAndProductCombos();
            ClearOrderDetailsForm();
            selectedOrderDetailId = -1;
        }

        private void btnLoadOrderDetails_Click(object sender, EventArgs e)
        {
            LoadOrderDetails();
        }

        private void btnAddOrderDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbOrders.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select an order.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbOrders.Focus();
                    return;
                }

                if (cmbProducts.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a product.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbProducts.Focus();
                    return;
                }

                if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
                {
                    MessageBox.Show("Please enter a valid quantity (greater than zero).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQuantity.Focus();
                    return;
                }

                using (var context = new AppDbContext())
                {
                    int productId = (int)cmbProducts.SelectedValue;
                    int orderId = (int)cmbOrders.SelectedValue;

                    var product = context.Products.Find(productId);
                    var order = context.Orders.Find(orderId);

                    if (product == null)
                    {
                        MessageBox.Show("Selected product does not exist.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (order == null)
                    {
                        MessageBox.Show("Selected order does not exist.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var unitPrice = product.UnitPrice;

                    var detail = new OrderItem
                    {
                        OrderId = orderId,
                        ProductId = productId,
                        Quantity = quantity,
                        UnitPrice = unitPrice
                    };

                    context.OrderItems.Add(detail);
                    context.SaveChanges();

                    order.TotalAmount = context.OrderItems
                        .Where(oi => oi.OrderId == orderId)
                        .Sum(oi => oi.Quantity * oi.UnitPrice);

                    context.SaveChanges();

                    MessageBox.Show("Order detail added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadOrderDetails();
                ClearOrderDetailsForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding order details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteOrderDetails_Click(object sender, EventArgs e)
        {
            if (selectedOrderDetailId == -1)
            {
                MessageBox.Show("Please select an order detail to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this order detail?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            using (var context = new AppDbContext())
            {
                var detail = context.OrderItems.Find(selectedOrderDetailId);
                if (detail != null)
                {
                    context.OrderItems.Remove(detail);
                    context.SaveChanges();

                    MessageBox.Show("Order detail deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Order detail not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadOrderDetails();
        }

        private void btnUpdateOrderDetails_Click(object sender, EventArgs e)
        {
            if (selectedOrderDetailId == -1)
            {
                MessageBox.Show("Please select an order detail to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbOrders.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an order.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbOrders.Focus();
                return;
            }

            if (cmbProducts.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbProducts.Focus();
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                return;
            }

            using (var context = new AppDbContext())
            {
                var detail = context.OrderItems.Find(selectedOrderDetailId);
                if (detail != null)
                {
                    int newOrderId = (int)cmbOrders.SelectedValue;
                    int newProductId = (int)cmbProducts.SelectedValue;

                    var product = context.Products.Find(newProductId);
                    var order = context.Orders.Find(newOrderId);

                    if (product != null && order != null)
                    {
                        detail.OrderId = newOrderId;
                        detail.ProductId = newProductId;
                        detail.Quantity = quantity;
                        detail.UnitPrice = product.UnitPrice;

                        context.SaveChanges();

                        order.TotalAmount = context.OrderItems
                            .Where(oi => oi.OrderId == newOrderId)
                            .Sum(oi => oi.Quantity * oi.UnitPrice);

                        context.SaveChanges();

                        MessageBox.Show("Order detail updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Associated product or order not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Order detail not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadOrderDetails();
        }

        private void LoadProducts()
        {
            using (var context = new AppDbContext())
            {
                var products = context.Products
                    .Include(p => p.Supplier)
                    .Select(p => new
                    {
                        p.Id,
                        p.ProductName,
                        SupplierName = p.Supplier.CompanyName,
                        p.UnitPrice,
                        p.Package,
                        p.IsDiscontinued
                    })
                    .ToList();

                dataGridView1.DataSource = products;

                cmbSupplier.DataSource = context.Suppliers.ToList();
                cmbSupplier.DisplayMember = "CompanyName";
                cmbSupplier.ValueMember = "Id";
            }

            ClearProductForm();
            selectedProductId = -1;
        }

        private void btnLoadProducts_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtProductName.Text))
                {
                    MessageBox.Show("Product Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProductName.Focus();
                    return;
                }

                if (cmbSupplier.SelectedValue == null || !int.TryParse(cmbSupplier.SelectedValue.ToString(), out int supplierId))
                {
                    MessageBox.Show("Please select a valid Supplier.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbSupplier.Focus();
                    return;
                }

                if (!decimal.TryParse(txtProductPrice.Text, out decimal unitPrice) || unitPrice < 0)
                {
                    MessageBox.Show("Please enter a valid non-negative price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProductPrice.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPackage.Text))
                {
                    MessageBox.Show("Package information is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPackage.Focus();
                    return;
                }

                using (var context = new AppDbContext())
                {
                    var product = new Product
                    {
                        ProductName = txtProductName.Text.Trim(),
                        SupplierId = supplierId,
                        UnitPrice = unitPrice,
                        Package = txtPackage.Text.Trim(),
                        IsDiscontinued = chkIsDiscontinued.Checked
                    };
                    context.Products.Add(product);
                    context.SaveChanges();
                }

                MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadProducts();
                ClearProductForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnUpdateProducts_Click(object sender, EventArgs e)
        {
            if (selectedProductId == -1)
            {
                MessageBox.Show("Please select a product to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Product Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductName.Focus();
                return;
            }

            if (cmbSupplier.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a supplier.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbSupplier.Focus();
                return;
            }

            if (!decimal.TryParse(txtProductPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid positive price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductPrice.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPackage.Text))
            {
                MessageBox.Show("Package is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPackage.Focus();
                return;
            }

            using (var context = new AppDbContext())
            {
                var product = context.Products.Find(selectedProductId);
                if (product != null)
                {
                    product.ProductName = txtProductName.Text.Trim();
                    product.SupplierId = (int)cmbSupplier.SelectedValue;
                    product.UnitPrice = price;
                    product.Package = txtPackage.Text.Trim();
                    product.IsDiscontinued = chkIsDiscontinued.Checked;

                    context.SaveChanges();

                    MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Product not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadProducts();
        }

        private void btnDeleteProducts_Click(object sender, EventArgs e)
        {
            if (selectedProductId == -1)
            {
                MessageBox.Show("Please select a product to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            using (var context = new AppDbContext())
            {
                var product = context.Products.Find(selectedProductId);
                if (product != null)
                {
                    context.Products.Remove(product);
                    context.SaveChanges();

                    MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Product not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadProducts();
        }


        private void LoadSuppliers()
        {
            using (var context = new AppDbContext())
            {
                var suppliers = context.Suppliers
                    .Select(s => new
                    {
                        s.Id,
                        s.CompanyName,
                        s.ContactName,
                        s.ContactTitle,
                        s.City,
                        s.Country,
                        s.Phone,
                        s.Fax
                    })
                    .ToList();

                dataGridView1.DataSource = suppliers;
            }

            ClearSupplierForm();
            selectedSupplierId = -1;
        }

        private void btnLoadSupplier_Click(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCompanyName.Text))
                {
                    MessageBox.Show("Company Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCompanyName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtContactName.Text))
                {
                    MessageBox.Show("Contact Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContactName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtContactTitle.Text))
                {
                    MessageBox.Show("Contact Title is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContactTitle.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtSupplierCity.Text))
                {
                    MessageBox.Show("City is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSupplierCity.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(Country.Text))
                {
                    MessageBox.Show("Country is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Country.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtSupplierPhone.Text))
                {
                    MessageBox.Show("Phone is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSupplierPhone.Focus();
                    return;
                }
                else if (!IsPhoneValid(txtSupplierPhone.Text))
                {
                    MessageBox.Show("Phone format is invalid.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSupplierPhone.Focus();
                    return;
                }

                if (!string.IsNullOrWhiteSpace(txtFax.Text) && !IsPhoneValid(txtFax.Text))
                {
                    MessageBox.Show("Fax format is invalid.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFax.Focus();
                    return;
                }

                using (var context = new AppDbContext())
                {
                    var supplier = new Supplier
                    {
                        CompanyName = txtCompanyName.Text,
                        ContactName = txtContactName.Text,
                        ContactTitle = txtContactTitle.Text,
                        City = txtSupplierCity.Text,
                        Country = Country.Text,
                        Phone = txtSupplierPhone.Text,
                        Fax = txtFax.Text
                    };

                    context.Suppliers.Add(supplier);
                    context.SaveChanges();
                }

                MessageBox.Show("Supplier added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding supplier: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsPhoneValid(string phone)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(phone, @"^[\d\s\+\-\(\)]+$");
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            if (selectedSupplierId == -1)
            {
                MessageBox.Show("Please select a supplier to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var context = new AppDbContext())
                {
                    var supplier = context.Suppliers.Find(selectedSupplierId);
                    if (supplier == null)
                    {
                        MessageBox.Show("Selected supplier not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    supplier.CompanyName = txtCompanyName.Text;
                    supplier.ContactName = txtContactName.Text;
                    supplier.ContactTitle = txtContactTitle.Text;
                    supplier.City = txtSupplierCity.Text;
                    supplier.Country = Country.Text;
                    supplier.Phone = txtSupplierPhone.Text;
                    supplier.Fax = txtFax.Text;

                    context.SaveChanges();
                }

                MessageBox.Show("Supplier updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating supplier: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            if (selectedSupplierId == -1)
            {
                MessageBox.Show("Please select a supplier to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this supplier?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var context = new AppDbContext())
                {
                    var supplier = context.Suppliers.Find(selectedSupplierId);
                    if (supplier == null)
                    {
                        MessageBox.Show("Selected supplier not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    context.Suppliers.Remove(supplier);
                    context.SaveChanges();
                }

                MessageBox.Show("Supplier deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting supplier: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index == -1) return;

            var columns = dataGridView1.Columns;

            if (columns.Contains("LastName"))
            {
                selectedCustomerId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                txtFirstName.Text = dataGridView1.CurrentRow.Cells["FirstName"].Value.ToString();
                txtLastName.Text = dataGridView1.CurrentRow.Cells["LastName"].Value.ToString();
                txtCity.Text = dataGridView1.CurrentRow.Cells["City"].Value.ToString();
                txtCountry.Text = dataGridView1.CurrentRow.Cells["Country"].Value.ToString();
                txtPhone.Text = dataGridView1.CurrentRow.Cells["Phone"].Value.ToString();
            }
            else if (columns.Contains("OrderNumber") && columns.Contains("TotalAmount"))
            {
                selectedOrderId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                txtOrderNumber.Text = dataGridView1.CurrentRow.Cells["OrderNumber"].Value.ToString();
                dtpOrderDate.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["OrderDate"].Value);
                txtTotalAmount.Text = dataGridView1.CurrentRow.Cells["TotalAmount"].Value.ToString();
            }
            else if (columns.Contains("ProductName") && columns.Contains("Quantity") && columns.Contains("OrderNumber"))
            {
                selectedOrderDetailId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                cmbOrders.Text = dataGridView1.CurrentRow.Cells["OrderNumber"].Value.ToString();
                cmbProducts.Text = dataGridView1.CurrentRow.Cells["ProductName"].Value.ToString();
                txtQuantity.Text = dataGridView1.CurrentRow.Cells["Quantity"].Value.ToString();
            }
            else if (columns.Contains("ProductName") && columns.Contains("UnitPrice") && columns.Contains("Package"))
            {
                selectedProductId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                txtProductName.Text = dataGridView1.CurrentRow.Cells["ProductName"].Value.ToString();
                cmbSupplier.Text = dataGridView1.CurrentRow.Cells["SupplierName"].Value.ToString();
                txtProductPrice.Text = dataGridView1.CurrentRow.Cells["UnitPrice"].Value.ToString();
                txtPackage.Text = dataGridView1.CurrentRow.Cells["Package"].Value.ToString();
                chkIsDiscontinued.Checked = (bool)dataGridView1.CurrentRow.Cells["IsDiscontinued"].Value;
            }
            else if (columns.Contains("CompanyName"))
            {
                selectedSupplierId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                txtCompanyName.Text = dataGridView1.CurrentRow.Cells["CompanyName"].Value.ToString();
                txtContactName.Text = dataGridView1.CurrentRow.Cells["ContactName"].Value.ToString();
                txtContactTitle.Text = dataGridView1.CurrentRow.Cells["ContactTitle"].Value.ToString();
                txtSupplierCity.Text = dataGridView1.CurrentRow.Cells["City"].Value.ToString();
                txtSupplierCountry.Text = dataGridView1.CurrentRow.Cells["Country"].Value.ToString();
                txtSupplierPhone.Text = dataGridView1.CurrentRow.Cells["Phone"].Value.ToString();
                txtFax.Text = dataGridView1.CurrentRow.Cells["Fax"].Value.ToString();
            }
        }

        private void ClearCustomerForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
            txtCountry.Clear();
            txtPhone.Clear();
        }

        private void ClearOrderForm()
        {
            txtOrderNumber?.Clear();
            dtpOrderDate.Value = DateTime.Now;

            if (cmbCustomers.DataSource != null && cmbCustomers.Items.Count > 0)
                cmbCustomers.SelectedIndex = 0;
        }

        private void ClearOrderDetailsForm()
        {
            txtQuantity.Clear();

            if (cmbOrders.Items.Count > 0)
                cmbOrders.SelectedIndex = 0;

            if (cmbProducts.Items.Count > 0)
                cmbProducts.SelectedIndex = 0;
        }

        private void ClearProductForm()
        {
            txtProductName.Clear();
            txtProductPrice.Clear();
            txtPackage.Clear();
            chkIsDiscontinued.Checked = false;
            cmbSupplier.SelectedIndex = -1;
        }

        private void ClearSupplierForm()
        {
            txtCompanyName.Clear();
            txtContactName.Clear();
            txtContactTitle.Clear();
            txtSupplierCity.Clear();
            txtSupplierCountry.Clear();
            txtSupplierPhone.Clear();
            txtFax.Clear();
            selectedSupplierId = -1;
        }
    }
}