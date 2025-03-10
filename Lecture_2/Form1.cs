using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_2
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=LAB321PC10\\SQLEXPRESS02;Database=OnlineBookStore;Trusted_Connection=True;";

        public Form1()
        {

            InitializeComponent();

            roleComboBox.Items.Add("Customer");
            roleComboBox.Items.Add("Admin");

            roleComboBox.SelectedIndex = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "Select userID from Users";

                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    IDComboBox.Items.Add(reader["UserID"].ToString());
                }
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {

            try
            {
                string userName = userNameTxt.Text;
                string password = passwordTxt.Text;
                string fullName = fullNameTxt.Text;
                string role = roleComboBox.Text;
                string email = emailTxt.Text;

                if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(role))
                {
                    throw new Exception("empty parameters");
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string commandString = $"INSERT INTO [dbo].[Users]([Username],[Password],[Email],[FullName],[Role])VALUES('{userName}','{password}','{email}','{fullName}', '{role}')";
                    SqlCommand command = new SqlCommand(commandString, conn);
                    conn.Open();
                    int affectedRows = command.ExecuteNonQuery();
                    MessageBox.Show($"{affectedRows} rows inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "Select * from [dbo].[Users]";

                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    conn.Open();
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["UserID"] + "-" + reader["Username"] + "-" + reader["Role"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            string id = IDComboBox.SelectedItem.ToString();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = $"DELETE FROM [dbo].[Users] WHERE UserID = '{id}'";

                    SqlCommand sqlCommand = new SqlCommand(query, conn);

                    conn.Open();
                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User deleted successfully.");
                        IDComboBox.Items.Remove(id);
                    }
                    else
                    {
                        MessageBox.Show("No user found with that UserID.");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
