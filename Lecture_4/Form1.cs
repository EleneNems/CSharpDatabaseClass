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
        private string _connectionString = "Server=LAB321PC11\\SQLEXPRESS02;Database=OnlineBookStore;Trusted_Connection=True;";
        private SqlConnection _con;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            using (_con = new SqlConnection(_connectionString))
            {
                string query = "SELECT [CustomerID],[FirstName],[LastName],[DateOfBirth],[Phone] FROM [dbo].[Customers]";
                using (SqlCommand cmd = new SqlCommand(query, _con))
                {
                    await _con.OpenAsync();
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Console.WriteLine("{0}-{1}-{2}-{3}-{4}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetInt32(4));
                        }
                    }
                }
            }
        }
    }
}
