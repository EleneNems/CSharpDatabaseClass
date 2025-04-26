using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homeworkk_2
{
    public partial class CreateAccount : Form
    {
        WordleDBEntities db = new WordleDBEntities();

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;

            
            if (!string.IsNullOrEmpty(username) || !string.IsNullOrEmpty(password))
            {
                User newUser = new User
                {
                    Username = username,
                    Password = password
                };

                db.Users.Add(newUser);
                db.SaveChanges();

                MessageBox.Show("You have successfully signed up!");

                GameForm gameForm = new GameForm();
                gameForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter the username and the password", "Error");
            }
        }
    }
}
