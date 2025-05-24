namespace Quizz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnLoad = new Button();
            btnUpdate = new Button();
            txtCity = new TextBox();
            txtLastName = new TextBox();
            btnDelete = new Button();
            btnAdd = new Button();
            txtPhone = new TextBox();
            txtCountry = new TextBox();
            txtFirstName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnLoadOrders = new Button();
            txtTotalAmount = new Label();
            btnUpdateOrders = new Button();
            btnDeleteOrder = new Button();
            cmbCustomers = new ComboBox();
            dtpOrderDate = new DateTimePicker();
            btnAddOrder = new Button();
            txtOrderNumber = new TextBox();
            label8 = new Label();
            Customer = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel3 = new Panel();
            cmbProducts = new ComboBox();
            cmbOrders = new ComboBox();
            btnLoadOrderDetails = new Button();
            btnUpdateOrderDetails = new Button();
            txtQuantity = new TextBox();
            btnDeleteOrderDetails = new Button();
            btnAddOrderDetails = new Button();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            panel4 = new Panel();
            chkIsDiscontinued = new CheckBox();
            cmbSupplier = new ComboBox();
            btnLoadProducts = new Button();
            btnUpdateProducts = new Button();
            txtPackage = new TextBox();
            txtProductPrice = new TextBox();
            btnDeleteProducts = new Button();
            btnAddProducts = new Button();
            txtProductName = new TextBox();
            label7 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            panel5 = new Panel();
            txtFax = new TextBox();
            label26 = new Label();
            txtSupplierCountry = new TextBox();
            Country = new Label();
            txtContactName = new TextBox();
            btnLoadSupplier = new Button();
            btnUpdateSupplier = new Button();
            txtContactTitle = new TextBox();
            btnDeleteSupplier = new Button();
            btnAddSupplier = new Button();
            txtSupplierPhone = new TextBox();
            txtSupplierCity = new TextBox();
            txtCompanyName = new TextBox();
            label9 = new Label();
            label13 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1185, 431);
            dataGridView1.TabIndex = 0;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(btnLoad);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(txtCity);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(txtCountry);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(211, 816);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 385);
            panel1.TabIndex = 1;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(235, 16);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 34);
            btnLoad.TabIndex = 13;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(251, 327);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(213, 171);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(150, 31);
            txtCity.TabIndex = 8;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(213, 119);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 31);
            txtLastName.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(133, 327);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(15, 327);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(213, 280);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(150, 31);
            txtPhone.TabIndex = 10;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(213, 226);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(150, 31);
            txtCountry.TabIndex = 9;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(213, 70);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 31);
            txtFirstName.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 280);
            label6.Name = "label6";
            label6.Size = new Size(62, 25);
            label6.TabIndex = 5;
            label6.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 223);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 4;
            label5.Text = "Country";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 171);
            label4.Name = "label4";
            label4.Size = new Size(42, 25);
            label4.TabIndex = 3;
            label4.Text = "City";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 123);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 2;
            label3.Text = "Last name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 72);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 1;
            label2.Text = "First name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 16);
            label1.Name = "label1";
            label1.Size = new Size(123, 30);
            label1.TabIndex = 0;
            label1.Text = "Customers";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(btnLoadOrders);
            panel2.Controls.Add(txtTotalAmount);
            panel2.Controls.Add(btnUpdateOrders);
            panel2.Controls.Add(btnDeleteOrder);
            panel2.Controls.Add(cmbCustomers);
            panel2.Controls.Add(dtpOrderDate);
            panel2.Controls.Add(btnAddOrder);
            panel2.Controls.Add(txtOrderNumber);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(Customer);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label12);
            panel2.Location = new Point(12, 475);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 324);
            panel2.TabIndex = 14;
            // 
            // btnLoadOrders
            // 
            btnLoadOrders.Location = new Point(235, 38);
            btnLoadOrders.Name = "btnLoadOrders";
            btnLoadOrders.Size = new Size(112, 34);
            btnLoadOrders.TabIndex = 16;
            btnLoadOrders.Text = "Load";
            btnLoadOrders.UseVisualStyleBackColor = true;
            btnLoadOrders.Click += btnLoadOrders_Click_1;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.AutoSize = true;
            txtTotalAmount.Location = new Point(235, 223);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(0, 25);
            txtTotalAmount.TabIndex = 16;
            // 
            // btnUpdateOrders
            // 
            btnUpdateOrders.Location = new Point(251, 267);
            btnUpdateOrders.Name = "btnUpdateOrders";
            btnUpdateOrders.Size = new Size(112, 34);
            btnUpdateOrders.TabIndex = 15;
            btnUpdateOrders.Text = "Update";
            btnUpdateOrders.UseVisualStyleBackColor = true;
            btnUpdateOrders.Click += btnUpdateOrders_Click;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.Location = new Point(133, 267);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(112, 34);
            btnDeleteOrder.TabIndex = 14;
            btnDeleteOrder.Text = "Delete";
            btnDeleteOrder.UseVisualStyleBackColor = true;
            btnDeleteOrder.Click += btnDeleteOrder_Click_1;
            // 
            // cmbCustomers
            // 
            cmbCustomers.FormattingEnabled = true;
            cmbCustomers.Location = new Point(213, 178);
            cmbCustomers.Name = "cmbCustomers";
            cmbCustomers.Size = new Size(150, 33);
            cmbCustomers.TabIndex = 15;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(213, 136);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(150, 31);
            dtpOrderDate.TabIndex = 14;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(15, 267);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(112, 34);
            btnAddOrder.TabIndex = 2;
            btnAddOrder.Text = "Add";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // txtOrderNumber
            // 
            txtOrderNumber.Location = new Point(213, 97);
            txtOrderNumber.Name = "txtOrderNumber";
            txtOrderNumber.Size = new Size(150, 31);
            txtOrderNumber.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 214);
            label8.Name = "label8";
            label8.Size = new Size(119, 25);
            label8.TabIndex = 4;
            label8.Text = "Total Amount";
            // 
            // Customer
            // 
            Customer.AutoSize = true;
            Customer.Location = new Point(15, 177);
            Customer.Name = "Customer";
            Customer.Size = new Size(89, 25);
            Customer.TabIndex = 3;
            Customer.Text = "Customer";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 141);
            label10.Name = "label10";
            label10.Size = new Size(100, 25);
            label10.TabIndex = 2;
            label10.Text = "Order Date";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 102);
            label11.Name = "label11";
            label11.Size = new Size(128, 25);
            label11.TabIndex = 1;
            label11.Text = "Order Number";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(15, 38);
            label12.Name = "label12";
            label12.Size = new Size(84, 30);
            label12.TabIndex = 0;
            label12.Text = "Orders";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientInactiveCaption;
            panel3.Controls.Add(cmbProducts);
            panel3.Controls.Add(cmbOrders);
            panel3.Controls.Add(btnLoadOrderDetails);
            panel3.Controls.Add(btnUpdateOrderDetails);
            panel3.Controls.Add(txtQuantity);
            panel3.Controls.Add(btnDeleteOrderDetails);
            panel3.Controls.Add(btnAddOrderDetails);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label17);
            panel3.Location = new Point(815, 475);
            panel3.Name = "panel3";
            panel3.Size = new Size(384, 324);
            panel3.TabIndex = 14;
            // 
            // cmbProducts
            // 
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(213, 153);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(150, 33);
            cmbProducts.TabIndex = 17;
            // 
            // cmbOrders
            // 
            cmbOrders.FormattingEnabled = true;
            cmbOrders.Location = new Point(213, 114);
            cmbOrders.Name = "cmbOrders";
            cmbOrders.Size = new Size(150, 33);
            cmbOrders.TabIndex = 16;
            // 
            // btnLoadOrderDetails
            // 
            btnLoadOrderDetails.Location = new Point(237, 37);
            btnLoadOrderDetails.Name = "btnLoadOrderDetails";
            btnLoadOrderDetails.Size = new Size(112, 34);
            btnLoadOrderDetails.TabIndex = 13;
            btnLoadOrderDetails.Text = "Load";
            btnLoadOrderDetails.UseVisualStyleBackColor = true;
            btnLoadOrderDetails.Click += btnLoadOrderDetails_Click;
            // 
            // btnUpdateOrderDetails
            // 
            btnUpdateOrderDetails.Location = new Point(251, 267);
            btnUpdateOrderDetails.Name = "btnUpdateOrderDetails";
            btnUpdateOrderDetails.Size = new Size(112, 34);
            btnUpdateOrderDetails.TabIndex = 12;
            btnUpdateOrderDetails.Text = "Update";
            btnUpdateOrderDetails.UseVisualStyleBackColor = true;
            btnUpdateOrderDetails.Click += btnUpdateOrderDetails_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(215, 192);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(150, 31);
            txtQuantity.TabIndex = 8;
            // 
            // btnDeleteOrderDetails
            // 
            btnDeleteOrderDetails.Location = new Point(133, 267);
            btnDeleteOrderDetails.Name = "btnDeleteOrderDetails";
            btnDeleteOrderDetails.Size = new Size(112, 34);
            btnDeleteOrderDetails.TabIndex = 11;
            btnDeleteOrderDetails.Text = "Delete";
            btnDeleteOrderDetails.UseVisualStyleBackColor = true;
            btnDeleteOrderDetails.Click += btnDeleteOrderDetails_Click;
            // 
            // btnAddOrderDetails
            // 
            btnAddOrderDetails.Location = new Point(15, 267);
            btnAddOrderDetails.Name = "btnAddOrderDetails";
            btnAddOrderDetails.Size = new Size(112, 34);
            btnAddOrderDetails.TabIndex = 2;
            btnAddOrderDetails.Text = "Add";
            btnAddOrderDetails.UseVisualStyleBackColor = true;
            btnAddOrderDetails.Click += btnAddOrderDetails_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(17, 192);
            label14.Name = "label14";
            label14.Size = new Size(80, 25);
            label14.TabIndex = 3;
            label14.Text = "Quantity";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(17, 156);
            label15.Name = "label15";
            label15.Size = new Size(82, 25);
            label15.TabIndex = 2;
            label15.Text = "Products";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(17, 117);
            label16.Name = "label16";
            label16.Size = new Size(66, 25);
            label16.TabIndex = 1;
            label16.Text = "Orders";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(17, 37);
            label17.Name = "label17";
            label17.Size = new Size(132, 30);
            label17.TabIndex = 0;
            label17.Text = "OrderItems";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientInactiveCaption;
            panel4.Controls.Add(chkIsDiscontinued);
            panel4.Controls.Add(cmbSupplier);
            panel4.Controls.Add(btnLoadProducts);
            panel4.Controls.Add(btnUpdateProducts);
            panel4.Controls.Add(txtPackage);
            panel4.Controls.Add(txtProductPrice);
            panel4.Controls.Add(btnDeleteProducts);
            panel4.Controls.Add(btnAddProducts);
            panel4.Controls.Add(txtProductName);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(label19);
            panel4.Controls.Add(label20);
            panel4.Controls.Add(label21);
            panel4.Location = new Point(411, 475);
            panel4.Name = "panel4";
            panel4.Size = new Size(384, 324);
            panel4.TabIndex = 14;
            // 
            // chkIsDiscontinued
            // 
            chkIsDiscontinued.AutoSize = true;
            chkIsDiscontinued.Location = new Point(203, 223);
            chkIsDiscontinued.Name = "chkIsDiscontinued";
            chkIsDiscontinued.Size = new Size(160, 29);
            chkIsDiscontinued.TabIndex = 16;
            chkIsDiscontinued.Text = "Is Discontinued";
            chkIsDiscontinued.UseVisualStyleBackColor = true;
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(215, 179);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(152, 33);
            cmbSupplier.TabIndex = 15;
            // 
            // btnLoadProducts
            // 
            btnLoadProducts.Location = new Point(235, 20);
            btnLoadProducts.Name = "btnLoadProducts";
            btnLoadProducts.Size = new Size(112, 34);
            btnLoadProducts.TabIndex = 13;
            btnLoadProducts.Text = "Load";
            btnLoadProducts.UseVisualStyleBackColor = true;
            btnLoadProducts.Click += btnLoadProducts_Click;
            // 
            // btnUpdateProducts
            // 
            btnUpdateProducts.Location = new Point(251, 267);
            btnUpdateProducts.Name = "btnUpdateProducts";
            btnUpdateProducts.Size = new Size(112, 34);
            btnUpdateProducts.TabIndex = 12;
            btnUpdateProducts.Text = "Update";
            btnUpdateProducts.UseVisualStyleBackColor = true;
            btnUpdateProducts.Click += btnUpdateProducts_Click;
            // 
            // txtPackage
            // 
            txtPackage.Location = new Point(215, 142);
            txtPackage.Name = "txtPackage";
            txtPackage.Size = new Size(150, 31);
            txtPackage.TabIndex = 8;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(215, 102);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(150, 31);
            txtProductPrice.TabIndex = 7;
            // 
            // btnDeleteProducts
            // 
            btnDeleteProducts.Location = new Point(133, 267);
            btnDeleteProducts.Name = "btnDeleteProducts";
            btnDeleteProducts.Size = new Size(112, 34);
            btnDeleteProducts.TabIndex = 11;
            btnDeleteProducts.Text = "Delete";
            btnDeleteProducts.UseVisualStyleBackColor = true;
            btnDeleteProducts.Click += btnDeleteProducts_Click;
            // 
            // btnAddProducts
            // 
            btnAddProducts.Location = new Point(15, 267);
            btnAddProducts.Name = "btnAddProducts";
            btnAddProducts.Size = new Size(112, 34);
            btnAddProducts.TabIndex = 2;
            btnAddProducts.Text = "Add";
            btnAddProducts.UseVisualStyleBackColor = true;
            btnAddProducts.Click += btnAddProducts_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(215, 64);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(150, 31);
            txtProductName.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 182);
            label7.Name = "label7";
            label7.Size = new Size(77, 25);
            label7.TabIndex = 5;
            label7.Text = "Supplier";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(17, 144);
            label18.Name = "label18";
            label18.Size = new Size(76, 25);
            label18.TabIndex = 3;
            label18.Text = "Package";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(17, 108);
            label19.Name = "label19";
            label19.Size = new Size(49, 25);
            label19.TabIndex = 2;
            label19.Text = "Price";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(17, 69);
            label20.Name = "label20";
            label20.Size = new Size(123, 25);
            label20.TabIndex = 1;
            label20.Text = "Product name";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(15, 20);
            label21.Name = "label21";
            label21.Size = new Size(106, 30);
            label21.TabIndex = 0;
            label21.Text = "Products";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.GradientInactiveCaption;
            panel5.Controls.Add(txtFax);
            panel5.Controls.Add(label26);
            panel5.Controls.Add(txtSupplierCountry);
            panel5.Controls.Add(Country);
            panel5.Controls.Add(txtContactName);
            panel5.Controls.Add(btnLoadSupplier);
            panel5.Controls.Add(btnUpdateSupplier);
            panel5.Controls.Add(txtContactTitle);
            panel5.Controls.Add(btnDeleteSupplier);
            panel5.Controls.Add(btnAddSupplier);
            panel5.Controls.Add(txtSupplierPhone);
            panel5.Controls.Add(txtSupplierCity);
            panel5.Controls.Add(txtCompanyName);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(label22);
            panel5.Controls.Add(label23);
            panel5.Controls.Add(label24);
            panel5.Controls.Add(label25);
            panel5.Location = new Point(614, 816);
            panel5.Name = "panel5";
            panel5.Size = new Size(384, 385);
            panel5.TabIndex = 15;
            // 
            // txtFax
            // 
            txtFax.Location = new Point(214, 286);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(150, 31);
            txtFax.TabIndex = 18;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(16, 286);
            label26.Name = "label26";
            label26.Size = new Size(37, 25);
            label26.TabIndex = 17;
            label26.Text = "Fax";
            // 
            // txtSupplierCountry
            // 
            txtSupplierCountry.Location = new Point(214, 249);
            txtSupplierCountry.Name = "txtSupplierCountry";
            txtSupplierCountry.Size = new Size(150, 31);
            txtSupplierCountry.TabIndex = 16;
            // 
            // Country
            // 
            Country.AutoSize = true;
            Country.Location = new Point(16, 249);
            Country.Name = "Country";
            Country.Size = new Size(75, 25);
            Country.TabIndex = 15;
            Country.Text = "Country";
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(213, 94);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(150, 31);
            txtContactName.TabIndex = 14;
            // 
            // btnLoadSupplier
            // 
            btnLoadSupplier.Location = new Point(235, 16);
            btnLoadSupplier.Name = "btnLoadSupplier";
            btnLoadSupplier.Size = new Size(112, 34);
            btnLoadSupplier.TabIndex = 13;
            btnLoadSupplier.Text = "Load";
            btnLoadSupplier.UseVisualStyleBackColor = true;
            btnLoadSupplier.Click += btnLoadSupplier_Click;
            // 
            // btnUpdateSupplier
            // 
            btnUpdateSupplier.Location = new Point(252, 327);
            btnUpdateSupplier.Name = "btnUpdateSupplier";
            btnUpdateSupplier.Size = new Size(112, 34);
            btnUpdateSupplier.TabIndex = 12;
            btnUpdateSupplier.Text = "Update";
            btnUpdateSupplier.UseVisualStyleBackColor = true;
            btnUpdateSupplier.Click += btnUpdateSupplier_Click;
            // 
            // txtContactTitle
            // 
            txtContactTitle.Location = new Point(213, 135);
            txtContactTitle.Name = "txtContactTitle";
            txtContactTitle.Size = new Size(150, 31);
            txtContactTitle.TabIndex = 8;
            // 
            // btnDeleteSupplier
            // 
            btnDeleteSupplier.Location = new Point(134, 327);
            btnDeleteSupplier.Name = "btnDeleteSupplier";
            btnDeleteSupplier.Size = new Size(112, 34);
            btnDeleteSupplier.TabIndex = 11;
            btnDeleteSupplier.Text = "Delete";
            btnDeleteSupplier.UseVisualStyleBackColor = true;
            btnDeleteSupplier.Click += btnDeleteSupplier_Click;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.Location = new Point(16, 327);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(112, 34);
            btnAddSupplier.TabIndex = 2;
            btnAddSupplier.Text = "Add";
            btnAddSupplier.UseVisualStyleBackColor = true;
            btnAddSupplier.Click += btnAddSupplier_Click;
            // 
            // txtSupplierPhone
            // 
            txtSupplierPhone.Location = new Point(213, 212);
            txtSupplierPhone.Name = "txtSupplierPhone";
            txtSupplierPhone.Size = new Size(150, 31);
            txtSupplierPhone.TabIndex = 10;
            // 
            // txtSupplierCity
            // 
            txtSupplierCity.Location = new Point(213, 174);
            txtSupplierCity.Name = "txtSupplierCity";
            txtSupplierCity.Size = new Size(150, 31);
            txtSupplierCity.TabIndex = 9;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(213, 57);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(150, 31);
            txtCompanyName.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 212);
            label9.Name = "label9";
            label9.Size = new Size(62, 25);
            label9.TabIndex = 5;
            label9.Text = "Phone";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 174);
            label13.Name = "label13";
            label13.Size = new Size(42, 25);
            label13.TabIndex = 4;
            label13.Text = "City";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(15, 137);
            label22.Name = "label22";
            label22.Size = new Size(107, 25);
            label22.TabIndex = 3;
            label22.Text = "Contact title";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(15, 101);
            label23.Name = "label23";
            label23.Size = new Size(122, 25);
            label23.TabIndex = 2;
            label23.Text = "Contact name";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(15, 62);
            label24.Name = "label24";
            label24.Size = new Size(138, 25);
            label24.TabIndex = 1;
            label24.Text = "Company name";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.Location = new Point(15, 16);
            label25.Name = "label25";
            label25.Size = new Size(109, 30);
            label25.TabIndex = 0;
            label25.Text = "Suppliers";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1211, 1202);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "od";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPhone;
        private TextBox txtCountry;
        private TextBox txtCity;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Button btnLoad;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private Panel panel2;
        private Button btnAddOrder;
        private TextBox txtOrderNumber;
        private Label label8;
        private Label Customer;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label txtTotalAmount;
        private ComboBox cmbCustomers;
        private DateTimePicker dtpOrderDate;
        private Button btnLoadOrders;
        private Button btnUpdateOrders;
        private Button btnDeleteOrder;
        private Panel panel3;
        private Button btnLoadOrderDetails;
        private Button btnUpdateOrderDetails;
        private TextBox txtQuantity;
        private Button btnDeleteOrderDetails;
        private Button btnAddOrderDetails;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private ComboBox cmbProducts;
        private ComboBox cmbOrders;
        private Panel panel4;
        private Button btnLoadProducts;
        private Button btnUpdateProducts;
        private TextBox txtPackage;
        private TextBox txtProductPrice;
        private Button btnDeleteProducts;
        private Button btnAddProducts;
        private TextBox txtProductName;
        private Label label7;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private ComboBox cmbSupplier;
        private CheckBox chkIsDiscontinued;
        private Panel panel5;
        private Button btnLoadSupplier;
        private Button btnUpdateSupplier;
        private TextBox txtContactTitle;
        private TextBox txtFax;
        private Button btnDeleteSupplier;
        private Button btnAddSupplier;
        private TextBox txtSupplierPhone;
        private TextBox txtSupplierCity;
        private TextBox txtCompanyName;
        private Label label9;
        private Label label13;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private TextBox txtContactName;
        private TextBox txtSupplierCountry;
        private Label Country;
        private Label label26;
    }
}
