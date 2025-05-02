using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homeworkk_2
{
    public partial class CreateAccount : Form
    {
        WordleDBEntities1 db = new WordleDBEntities1();

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            string email = emailTxt.Text;
            string password = passwordTxt.Text;


            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                try
                {
                    var mail = new MailAddress(email);

                    if (password.Length < 8 || !password.Any(char.IsUpper))
                    {
                        MessageBox.Show("Password must be at least 8 characters long and contain at least one uppercase letter.", "Password Error");
                        return;
                    }

                    User newUser = new User
                    {
                        Email = email,
                        Password = password
                    };

                    db.Users.Add(newUser);
                    db.SaveChanges();

                    MessageBox.Show("You have successfully signed up!");

                    GameForm gameForm = new GameForm();
                    gameForm.Show();
                    this.Hide();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid email format. Please enter a valid email address.", "Validation Error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error");
                }

            else
                {
                MessageBox.Show("Please enter the email and the password", "Error");
            }
        }
    }
}