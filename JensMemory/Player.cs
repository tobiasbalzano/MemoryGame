using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JensMemory
{
    // Klass för spelare. Används inte ännu...
    public class Player
    {
        public string name { get; set; }
        public int points { get; set; }
        public bool turn { get; set; }
        public int id { get; set; }
        //public int computerChoice1 { get; set; }  fråga adam
        //public int computerChoice2 { get; set; }
        public bool computer;

        
        public Player(string name, bool computer)
        {
            this.name = name;
            this.computer=computer;
            points = 0;
            turn = false;

        }
    }
}
