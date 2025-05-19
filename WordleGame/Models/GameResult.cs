using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleGame.Models
{
    public class GameResult
    {
        public int Id { get; set; }
        public DateTime PlayedOn { get; set; }
        public string CorrectWord { get; set; }
        public int AttemptsUsed { get; set; }
        public int Score { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
