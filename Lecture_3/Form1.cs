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

namespace Lecture_3
{
    public partial class Form1 : Form
    {
        private string _connectionString = "Server=LAB321PC10\\SQLEXPRESS02;Database=OnlineBookStore;Trusted_Connection=True;";
        private SqlConnection _con;

        public Form1()
        {
            InitializeComponent();
            _con = new SqlConnection(_connectionString);
            this.UserLoad();
        }


        private void UserLoad()
        {
            string query = "SELECT [UserID], [Username], [Password], [Email], [FullName]\r\n      ,[Role], [CreatedAt] FROM [OnlineBookStore].[dbo].[Users]";
            _con.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, _con);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Users");
            _con.Close();
            UserIDCombobox.DataSource = dataSet.Tables["Users"];
            UserIDCombobox.DisplayMember = "Username";
            UserIDCombobox.ValueMember = "UserID";
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {

            string OrderDate = OrderDatePicker.Text;
            string TotalAmount = TotalAmountTxt.Text;
            int UserID = int.Parse(UserIDCombobox.SelectedValue.ToString());

            string query = "INSERT INTO [dbo].[Orders]([UserID],[OrderDate],[TotalAmount])VALUES(@UserID, @OrderDate, @TotalAmount)";
            SqlCommand cmd = new SqlCommand(query, _con);
            cmd.Parameters.Add("@UserID", SqlDbType.Int);
            cmd.Parameters.Add("@OrderDate", SqlDbType.DateTime);
            cmd.Parameters.Add("@TotalAmount", SqlDbType.Decimal);

            cmd.Parameters["@UserID"].Value = UserID;
            cmd.Parameters["@OrderDate"].Value = OrderDate;
            cmd.Parameters["@TotalAmount"].Value = TotalAmount;

            _con.Open();
            cmd.ExecuteNonQuery();
            _con.Close();
        }

        private void InsertProcedureBtn_Click(object sender, EventArgs e)
        {
            string OrderDate = OrderDatePicker.Text;
            string TotalAmount = TotalAmountTxt.Text;
            int UserID = int.Parse(UserIDCombobox.SelectedValue.ToString());

            SqlCommand cmd = new SqlCommand("InsertOrder", _con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;
            cmd.Parameters.Add("@OrderDate", SqlDbType.DateTime).Value = OrderDate;
            cmd.Parameters.Add("@TotalAmount", SqlDbType.Decimal).Value = TotalAmount;

            _con.Open();
            cmd.ExecuteNonQuery();
            _con.Close();

            MessageBox.Show("Order successfully inserted.");
        }
    }
}
