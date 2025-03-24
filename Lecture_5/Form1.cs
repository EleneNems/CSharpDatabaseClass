using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_5
{
    public partial class Form1 : Form
    {
        private string _connectionString = "Server=LAB321PC01\\SQLEXPRESS02;Database=OnlineBookStore;Trusted_Connection=True;";
        private SqlConnection _con;
        int selectedBookID;

        public Form1()
        {
            InitializeComponent();
            loadData();
        }

        private async void insert_btn_Click(object sender, EventArgs e)
        {
            string title = titletxt.Text;
            string author = authorTxt.Text;
            string isbn = isbnTxt.Text;

            decimal price = decimal.Parse(priceTxt.Text);
            int stock = int.Parse(stockTxt.Text);

            string query = "InsertBook";

            try
            {
                using (_con = new SqlConnection(_connectionString))
                {
                    await _con.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand(query, _con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Author", author);
                        cmd.Parameters.AddWithValue("@ISBN", isbn);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Stock", stock);

                        await cmd.ExecuteNonQueryAsync();
                        MessageBox.Show("Successfully inserted the data");
                        clearInputs();
                        loadData();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void loadData()
        {
            string query = "Select * from dbo.Books";

            try
            {
                using(SqlConnection _con = new SqlConnection(_connectionString))
                {
                    await _con.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand(query, _con))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();

                            adapter.Fill(dt);

                            bookGrid.DataSource = dt;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" +ex.Message);
            }
        }

        private async void update_btn_Click(object sender, EventArgs e)
        {
            if (selectedBookID == -1)
            {
                MessageBox.Show("Please select a row to update");
            }

            string title = titletxt.Text;
            string author = authorTxt.Text;
            string isbn = isbnTxt.Text;

            decimal price = decimal.Parse(priceTxt.Text);
            int stock = int.Parse(stockTxt.Text);

            string query = "UPDATE [dbo].[Books] SET [Title] =@Title, [Author] =@Author, [ISBN] = @ISBN, [Price] = @Price, [Stock] = @Stock WHERE BookID = @BookID";

            try
            {

                using (SqlConnection _con = new SqlConnection(_connectionString))
                {

                    await _con.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand(query, _con))
                    {
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Author", author);
                        cmd.Parameters.AddWithValue("@ISBN", isbn);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Stock", stock);
                        cmd.Parameters.AddWithValue("@BookID", selectedBookID);


                        await cmd.ExecuteNonQueryAsync();

                        MessageBox.Show("Successfully updated the data");

                        loadData();
                        clearInputs();

                        selectedBookID = -1;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if(selectedBookID == -1)
            {
                MessageBox.Show("Please select a row to delete");
            }

            string query = "DELETE FROM [dbo].[Books] WHERE BookID = @BookID";

            try
            {
                using(SqlConnection _con = new SqlConnection(_connectionString))
                {
                    _con.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand(query, _con))
                    {
                        DbParameter param = cmd.CreateParameter();
                        param.ParameterName = "@BookID";
                        param.Value = selectedBookID;
                        param.DbType = System.Data.DbType.Int32;

                        cmd.Parameters.Add(param);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Book deleted successfully!");

                        loadData();
                        clearInputs();

                    }


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error"+ex.Message);
            }

        }

        private void bookGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = bookGrid.Rows[e.RowIndex];

                titletxt.Text = row.Cells["Title"].Value.ToString();
                authorTxt.Text = row.Cells["Author"].Value.ToString();
                isbnTxt.Text = row.Cells["ISBN"].Value.ToString();
                priceTxt.Text = row.Cells["Price"].Value.ToString();
                stockTxt.Text = row.Cells["Stock"].Value.ToString();

                selectedBookID = Convert.ToInt32(row.Cells["BookID"].Value);
            }
        }

        private void clearInputs()
        {
            titletxt.Clear();
            authorTxt.Clear();
            isbnTxt.Clear();
            priceTxt.Clear();
            stockTxt.Clear();
        }

        
    }
}
