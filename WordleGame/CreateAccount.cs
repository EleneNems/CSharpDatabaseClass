using System;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using WordleGame.Data;
using WordleGame.Models;

namespace WordleGame
{
    public partial class CreateAccount : Form
    {
        private readonly WordleDbContext db = new WordleDbContext();

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            string email = emailTxt.Text.Trim();
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

                    if (db.Users.Any(u => u.Email == email))
                    {
                        MessageBox.Show("An account with this email already exists.", "Email Exists");
                        return;
                    }
                    
                    User newUser = new User
                    {
                        Email = email,
                        PasswordHash = HashPassword(password),
                        GamesPlayed = 0,
                        GamesWon = 0,
                        CurrentStreak = 0,
                        MaxStreak = 0,
                        GameResults = new List<GameResult>() 
                    };

                    db.Users.Add(newUser);
                    db.SaveChanges();

                    MessageBox.Show("Account created successfully!");

                    GameForm gameForm = new GameForm(newUser);
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
            }
            else
            {
                MessageBox.Show("Please enter both email and password.", "Missing Info");
            }
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
