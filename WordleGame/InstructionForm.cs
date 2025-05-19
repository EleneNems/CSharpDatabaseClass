using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordleGame.Models;

namespace WordleGame
{
    public partial class InstructionForm : Form
    {
        private readonly User currentUser;

        public InstructionForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm gameForm = new GameForm(currentUser);
            gameForm.ShowDialog();
        }
    }
}
