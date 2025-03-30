using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string _connectionString = "Server=DESKTOP-O4D8S12;Database=OnlineBookStore;Trusted_Connection=True;";
            string query = "select * from users";

            DataTable userTable = new DataTable("users");

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(userTable);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                //DataRow newRow = userTable.NewRow();
                //newRow["Username"] = "Keti";
                //newRow["Password"] = "password101112";
                //newRow["Email"] = "Keti@example.com";
                //newRow["FullName"] = "Keti Ketelauri";
                //newRow["Role"] = "Admin";

                //userTable.Rows.Add(newRow);

                //adapter.Update(userTable);


                DataRow newRow = userTable.NewRow();
                newRow["Username"] = "Zaza";
                newRow["Password"] = "password131415";
                newRow["Email"] = "Zaza@example.com";
                newRow["FullName"] = "Zaza Shavtvaladze";
                newRow["Role"] = "Customer";

                userTable.Rows.Add(newRow); 
                adapter.Update(userTable);
                Console.WriteLine("insert done");



                var filteredValue = userTable.AsEnumerable().First
                    (row => row.Field<string>("UserName")=="Keti");

                filteredValue["Role"] = "Customer";
                adapter.Update(userTable);
                Console.WriteLine("update done");




                var filteredValueDelete = userTable.AsEnumerable().First
                    (row => row.Field<string>("Username") == "Mari");

                filteredValueDelete.Delete();
                adapter.Update(userTable);
                Console.WriteLine("Delete done");

                foreach (DataRow row in userTable.Rows)
                {
                    Console.WriteLine(row["FullName"]);
                }


            }

            //foreach (DataRow row in userTable.Rows) 
            //{
            //    Console.WriteLine(row["Username"]);
            //}

            //var filteredValue = userTable.AsEnumerable().First
            //    (row => row.Field<string>("Username")=="Keti");
            //Console.WriteLine(filteredValue["Email"]);
            //Console.WriteLine(filteredValue["FullName"]); 

            Console.ReadKey();
        }
    }
}
