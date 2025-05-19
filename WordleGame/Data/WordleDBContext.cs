using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordleGame.Models;

namespace WordleGame.Data
{
    public class WordleDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<GameResult> GameResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-O4D8S12;Database=WordleGameDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }

}
