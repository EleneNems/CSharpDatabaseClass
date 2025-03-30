using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace MidtermProject
{
    public partial class Form1 : Form
    {
        private string _connectionString = "Server=DESKTOP-O4D8S12;Database=OnlineBookStore;Trusted_Connection=True;";
        private SqlConnection _con;
        int selectedOrderID = -1;
        private DataSet ds;

        public Form1()
        {
            InitializeComponent();
            orderDate.Format = DateTimePickerFormat.Custom;
            orderDate.CustomFormat = "dd-MM-yyyy";
            LoadUsers();
        }

        private void LoadUsers()
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT [UserID], [Username] FROM [dbo].[Users]";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Users");

                    userComboBox.DisplayMember = "Username";
                    userComboBox.ValueMember = "UserID";
                    userComboBox.DataSource = ds.Tables["Users"];
                }
            }
        }

        private async void loadOrdersBtn_Click(object sender, EventArgs e)
        {
            if (userComboBox.SelectedValue == null)
            {
                MessageBox.Show("Please select a user");
                return;
            }
            int selectedUserID = Convert.ToInt32(userComboBox.SelectedValue);
            await LoadData(selectedUserID);
        }

        private async Task LoadData(int userID)
        {
            string query = "SELECT [OrderID], [OrderDate], [TotalAmount] FROM [dbo].[Orders] WHERE UserID = @UserID";
            try
            {
                using (_con = new SqlConnection(_connectionString))
                {
                    await _con.OpenAsync();
                    using (SqlCommand cmd = new SqlCommand(query, _con))
                    {
                        cmd.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int) { Value = userID });
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            ds = new DataSet();
                            adapter.Fill(ds, "Orders");

                            var orders = ds.Tables["Orders"].AsEnumerable()
                                .Select(row => new
                                {
                                    OrderID = row.Field<int>("OrderID"),
                                    OrderDate = row.Field<DateTime>("OrderDate").ToString("dd-MM-yyyy"),
                                    TotalAmount = row.Field<decimal>("TotalAmount")
                                }).ToList();
                            ordersGridView.DataSource = orders;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void addOrderBtn_Click(object sender, EventArgs e)
        {
            string orderDateStr = orderDate.Value.ToString("yyyy-MM-dd");
            int totalAmount = Convert.ToInt32(totalAmountTxt.Value);
            int selectedUserID = Convert.ToInt32(userComboBox.SelectedValue);

            string query = "InsertOrder";

            using (_con = new SqlConnection(_connectionString))
            {
                await _con.OpenAsync();
                SqlTransaction transaction = _con.BeginTransaction();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, _con, transaction))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        DateTime orderDateValue = orderDate.Value;
                        cmd.Parameters.AddWithValue("@OrderDate", orderDateValue);
                        cmd.Parameters.AddWithValue("@UserID", selectedUserID);
                        cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);

                        await cmd.ExecuteNonQueryAsync();
                        transaction.Commit();

                        MessageBox.Show("Order successfully added.");
                        await LoadData(selectedUserID);
                        ClearInputs();
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private async void updateOrderBtn_Click(object sender, EventArgs e)
        {
            if (selectedOrderID == -1)
            {
                MessageBox.Show("Please choose an order to update");
                return;
            }

            string orderDateStr = orderDate.Value.ToString("yyyy-MM-dd");
            int totalAmount = Convert.ToInt32(totalAmountTxt.Value);
            string query = "UPDATE [dbo].[Orders] SET [OrderDate] = @OrderDate, [TotalAmount] = @TotalAmount WHERE OrderID = @OrderID";

            using (_con = new SqlConnection(_connectionString))
            {
                await _con.OpenAsync();
                SqlTransaction transaction = _con.BeginTransaction();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, _con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@OrderDate", orderDateStr);
                        cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                        cmd.Parameters.AddWithValue("@OrderID", selectedOrderID);

                        await cmd.ExecuteNonQueryAsync();
                        transaction.Commit();
                        MessageBox.Show("Order updated successfully.");
                        await LoadData(Convert.ToInt32(userComboBox.SelectedValue));
                        ClearInputs();
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void deleteOrderBtn_Click(object sender, EventArgs e)
        {
            if (selectedOrderID == -1)
            {
                MessageBox.Show("Please choose an order to delete");
                return;
            }
            using (_con = new SqlConnection(_connectionString))
            {
                _con.Open();
                string query = "SELECT * FROM Orders";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, _con))
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Orders");
                    DataTable dt = ds.Tables["Orders"];
                    dt.PrimaryKey = new DataColumn[]
                    {
                        dt.Columns["OrderID"]
                    };

                    DataRow row = dt.Rows.Find(selectedOrderID);
                    if (row != null)
                    {
                        row.Delete();
                        adapter.Update(dt);
                        MessageBox.Show("Order deleted successfully.");
                        LoadData(Convert.ToInt32(userComboBox.SelectedValue));
                        ClearInputs();
                    }
                }
            }
        }

        private void ClearInputs()
        {
            orderDate.Value = DateTime.Today;
            totalAmountTxt.Value = 0;
            selectedOrderID = -1;
        }

        private void ordersGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ordersGridView.Rows[e.RowIndex];
                selectedOrderID = Convert.ToInt32(row.Cells["OrderID"].Value);

                string orderDateString = row.Cells["OrderDate"].Value.ToString();
                orderDate.Value = DateTime.ParseExact(orderDateString, "dd-MM-yyyy", null);

                totalAmountTxt.Value = Convert.ToDecimal(row.Cells["TotalAmount"].Value);


            }
        }
        private void orderByBtn_Click(object sender, EventArgs e)
        {
            if (ds != null && ds.Tables["Orders"] != null)
            {
                var orderedOrders = ds.Tables["Orders"].AsEnumerable()
                    .OrderBy(row => row.Field<decimal>("TotalAmount")) 
                    .Select(row => new
                    {
                        OrderID = row.Field<int>("OrderID"),
                        OrderDate = row.Field<DateTime>("OrderDate").ToString("dd-MM-yyyy"),
                        TotalAmount = row.Field<decimal>("TotalAmount")
                    }).ToList();

                ordersGridView.DataSource = orderedOrders;
            }
            else
            {
                MessageBox.Show("No data to sort Please Load some first.");
            }
        }

    }
}
