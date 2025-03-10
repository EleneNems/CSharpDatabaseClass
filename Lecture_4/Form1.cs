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

namespace Lecture_4
{
    public partial class Form1 : Form
    {
        private string _connectionString = "Server=DESKTOP-O4D8S12;Database=OnlineBookStore;Trusted_Connection=True;";
        private SqlConnection _con;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            using (_con = new SqlConnection(_connectionString))
            {
                string query = "SELECT [UserID],[Username],[Password],[Email],[FullName],[Role],[CreatedAt] FROM [dbo].[Users]";
                using (SqlCommand cmd = new SqlCommand(query, _con))
                {
                    await _con.OpenAsync();
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Console.WriteLine("{0}-{1}-{2}-{3}-{4}-{5}-{6}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6));
                        }
                    }
                }
            }
        }

        public async void CreateWithTransaction()
        {
            using (_con = new SqlConnection(_connectionString)) 
            {
                await _con.OpenAsync();

                using (SqlTransaction transaction = _con.BeginTransaction())
                {
                    try
                    {
                        string query = "INSERT INTO [dbo].[Users] ([Username],[Password],[Email],[FullName],[Role]) VALUES(@userName, @password, @email, @fullName, @role)";
                        using (SqlCommand cmd = new SqlCommand(query, _con, transaction))
                        {
                            cmd.Parameters.AddWithValue("@userName", "username1");
                            cmd.Parameters.AddWithValue("@password", "123456");
                            cmd.Parameters.AddWithValue("@email", "username1@gmail.com");
                            cmd.Parameters.AddWithValue("@fullName", "full name1");
                            cmd.Parameters.AddWithValue("@role", "Admin");
                            await cmd.ExecuteNonQueryAsync();
                        }

                        query = "INSERT INTO [dbo].[Users1] ([Username],[Password],[Email],[FullName],[Role]) VALUES(@userName, @password, @email, @fullName, @role)";
                        using (SqlCommand cmd = new SqlCommand(query, _con, transaction))
                        {
                            cmd.Parameters.AddWithValue("@userName", "username1");
                            cmd.Parameters.AddWithValue("@password", "123456");
                            cmd.Parameters.AddWithValue("@email", "username1@gmail.com");
                            cmd.Parameters.AddWithValue("@fullName", "full name1");
                            cmd.Parameters.AddWithValue("@role", "Admin");
                            await cmd.ExecuteNonQueryAsync();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        transaction.Rollback();
                    }
                }
            }
        }


    public async void Create()
        {
            using (_con = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO [dbo].[Users] ([Username],[Password],[Email],[FullName],[Role]) VALUES(@userName, @password, @email, @fullName, @role)";

                try
                {
                    await _con.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand(query, _con))
                    {
                        cmd.Parameters.AddWithValue("@userName", "username1");
                        cmd.Parameters.AddWithValue("@password", "123456");
                        cmd.Parameters.AddWithValue("@email", "username1@gmail.com");
                        cmd.Parameters.AddWithValue("@fullName", "full name1");
                        cmd.Parameters.AddWithValue("@role", "Admin");
                        await cmd.ExecuteNonQueryAsync();

                    }

                    query = "INSERT INTO [dbo].[Users1] ([Username],[Password],[Email],[FullName],[Role]) VALUES(@userName, @password, @email, @fullName, @role)";
                    using (SqlCommand cmd = new SqlCommand(query, _con))
                    {
                        cmd.Parameters.AddWithValue("@userName", "username1");
                        cmd.Parameters.AddWithValue("@password", "123456");
                        cmd.Parameters.AddWithValue("@email", "username1@gmail.com");
                        cmd.Parameters.AddWithValue("@fullName", "full name1");
                        cmd.Parameters.AddWithValue("@role", "Admin");
                        await cmd.ExecuteNonQueryAsync();

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void transactionButton_Click(object sender, EventArgs e)
        {
            CreateWithTransaction();
        }
    }
}
