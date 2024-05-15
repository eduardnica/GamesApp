
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using SQLite;
using Microsoft.EntityFrameworkCore;

namespace GamesApp
{
    internal class GameDbContext : DbContext
    {

        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = @"C:\Eduard\Master\PDM\GamesApp\games.db";
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }
    }
}
