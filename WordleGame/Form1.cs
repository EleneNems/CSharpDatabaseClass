using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordleGame.Data;
using WordleGame.Models;

namespace WordleGame
{
    public partial class Form1 : Form
    {
        private readonly WordleDbContext db = new WordleDbContext();

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
                    var user = db.Users.FirstOrDefault(u => u.Email == email);
                    MessageBox.Show("Welcome!");

                    GameForm gameForm = new GameForm(user);
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
