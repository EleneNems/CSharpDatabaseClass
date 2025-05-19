using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordleGame.Models;

namespace WordleGame
{
    public partial class StatisticsForm : Form
    {
        private readonly User currentUser;

        public StatisticsForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            valuePlayed.Text = currentUser.GamesPlayed.ToString();

            int winPercent = currentUser.GamesPlayed > 0
                ? (int)(((double)currentUser.GamesWon / currentUser.GamesPlayed) * 100)
                : 0;
            valueWinPercent.Text = winPercent + "%";

            valueCurrentStreak.Text = currentUser.CurrentStreak.ToString();
            valueMaxStreak.Text = currentUser.MaxStreak.ToString();
        }

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
