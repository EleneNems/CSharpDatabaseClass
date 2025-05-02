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
    public partial class Form1 : Form
    {
        private WordleDBEntities1 db = new WordleDBEntities1();

        public Form1()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            
            string email = emailTxt.Text;
            if (!string.IsNullOrEmpty(email))
            {
                bool exists = db.Users.Any(x => x.Email == email);

                if (exists)
                {
                    MessageBox.Show("Welcome!");

                    GameForm gameForm = new GameForm();
                    gameForm.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("That email doesn't exist!", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please enter an email", "Error");
            }

        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();
            this.Hide();
        }
    }
}
