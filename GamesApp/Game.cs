using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesApp
{
    public class Game
    {
        
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Developer { get; set; }
        public int ReleaseDate { get; set; }
        public string Category { get; set; }
        public double Rating { get; set; }

    }
}
