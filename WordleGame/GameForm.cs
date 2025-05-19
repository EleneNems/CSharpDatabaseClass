using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WordleGame.Data;
using WordleGame.Models;

namespace WordleGame
{
    public partial class GameForm : Form
    {
        private readonly WordleDbContext db = new WordleDbContext();
        private readonly User currentUser;
        private int currentRow = 1;
        private string correctWord;
        private List<string> wordList = new List<string> { "APPLE", "GRAPE", "PLANE", "CHAIR", "MOUSE", "CLOUD", "SUGAR", "LOOKS", "SCORE"};

        public GameForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int index = rnd.Next(wordList.Count);
            correctWord = wordList[index];
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string guessedWord = "";

            for (int col = 1; col <= 5; col++)
            {
                var box = this.Controls.Find($"textBox{currentRow}{col}", true).FirstOrDefault() as TextBox;
                if (box != null)
                {
                    guessedWord += box.Text.ToUpper();
                }
            }

            if (guessedWord.Length != 5)
            {
                MessageBox.Show("Please enter 5 letters!");
                return;
            }

            for (int col = 1; col <= 5; col++)
            {
                var box = this.Controls.Find($"textBox{currentRow}{col}", true).FirstOrDefault() as TextBox;

                if (box != null)
                {
                    if (guessedWord[col - 1] == correctWord[col - 1])
                    {
                        box.BackColor = Color.LightGreen;
                        box.ForeColor = Color.White;
                    }
                    else if (correctWord.Contains(guessedWord[col - 1]))
                    {
                        box.BackColor = Color.Gold;
                        box.ForeColor = Color.White;
                    }
                    else
                    {
                        box.BackColor = Color.Gray;
                        box.ForeColor = Color.White;
                    }
                }
            }

            if (guessedWord == correctWord)
            {
                SaveGameResult(currentRow, 100 - (currentRow - 1) * 10);
                UpdateUserStats(true, currentRow);
                MessageBox.Show("You guessed the word correctly!");
                this.Close();
            }
            else
            {
                currentRow++;
                if (currentRow > 6)
                {
                    SaveGameResult(6, 0);
                    UpdateUserStats(false, 6);
                    MessageBox.Show($"Game Over! The word was: {correctWord}");
                    this.Close();
                }
            }
        }

        private void SaveGameResult(int attempts, int score)
        {
            var result = new GameResult
            {
                PlayedOn = DateTime.Now,
                CorrectWord = correctWord,
                AttemptsUsed = attempts,
                Score = score,
                UserId = currentUser.Id
            };

            db.GameResults.Add(result);
            db.SaveChanges();
        }

        private void UpdateUserStats(bool won, int attemptsUsed)
        {
            currentUser.GamesPlayed++;

            if (won)
            {
                currentUser.GamesWon++;
                currentUser.CurrentStreak++;
                if (currentUser.CurrentStreak > currentUser.MaxStreak)
                {
                    currentUser.MaxStreak = currentUser.CurrentStreak;
                }
            }
            else
            {
                currentUser.CurrentStreak = 0;
            }

            db.Users.Update(currentUser);
            db.SaveChanges();
        }

        private void clickButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(correctWord);
        }

        private void instructionBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructionForm instructionForm = new InstructionForm(currentUser);
            instructionForm.ShowDialog();
        }

        private void statisticsBtn_Click(object sender, EventArgs e)
        {
            StatisticsForm statsForm = new StatisticsForm(currentUser);
            statsForm.ShowDialog();
        }
    }
}