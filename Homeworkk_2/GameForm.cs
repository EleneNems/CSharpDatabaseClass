using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordleGame
{
    public partial class GameForm : Form
    {
        private int currentRow = 1;
        WordleDBEntities1 db = new WordleDBEntities1();
        string correctWord;
        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            var wordsList = db.Words.ToList();
            Random random = new Random();
            int index = random.Next(wordsList.Count);
            correctWord = wordsList[index].Word1.ToUpper(); 
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string guessedWord = "";

            for (int col = 1; col <= 5; col++)
            {
                TextBox currentBox = this.Controls.Find($"textBox{currentRow}{col}", true).First() as TextBox;
                if (currentBox != null)
                {
                    guessedWord += currentBox.Text.ToUpper();
                }
            }

            if (guessedWord.Length != 5)
            {
                MessageBox.Show("Please enter 5 letters!");
                return;
            }

            for (int col = 1; col <= 5; col++)
            {
                TextBox currentBox = this.Controls.Find($"textBox{currentRow}{col}", true).First() as TextBox;

                if (currentBox != null)
                {
                    if (guessedWord[col - 1] == correctWord[col - 1])
                    {
                        currentBox.BackColor = Color.LightGreen;
                        currentBox.ForeColor = Color.White;
                    }
                    else if (correctWord.Contains(guessedWord[col - 1]))
                    {
                        currentBox.BackColor = Color.Gold;
                        currentBox.ForeColor = Color.White;
                    }
                    else
                    {
                        currentBox.BackColor = Color.Gray;
                        currentBox.ForeColor = Color.White;
                    }
                }
            }

            if (guessedWord == correctWord)
            {
                MessageBox.Show("You guessed the word correctly!");
            }
            else
            {
                currentRow++; 
                if (currentRow > 6)
                {
                    MessageBox.Show($"Game Over! The word was: {correctWord}");
                }
            }

        }

        private void clickButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(correctWord);
        }

        private void instructionBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructionForm instructionForm = new InstructionForm();
            instructionForm.ShowDialog();
        }
    }
}
