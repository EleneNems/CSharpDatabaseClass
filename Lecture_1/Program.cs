using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_1
{
    internal class Program
    {
        static string connectionString = "Server=LAB321PC10\\SQLEXPRESS02;Database=OnlineBookStore;Trusted_Connection=True;";
        static void Main(string[] args)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO [dbo].[Users]([Username],[Password],[Email],[FullName] ,[Role]) VALUES ('mari', 'mari2020', 'mariami@gmail.com', 'mariamtyebuchava', 'Admin' )";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            Console.ReadKey();
        }
    }
}
