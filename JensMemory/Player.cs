using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace JensMemory
{
    // Klass för spelare. Används inte ännu...
    public class Player
    {
        public string name { get; set; }
        public int points { get; set; }
        public bool turn { get; set; }
        public int id { get; set; }
        public Image potrait { get; set; }
        //public int computerChoice1 { get; set; }  fråga adam
        //public int computerChoice2 { get; set; }
        public bool computer;

        
        public Player(string name,Image portrait, bool computer)
        {
            this.name = name;
            this.computer=computer;
            this.potrait = portrait;
            points = 0;
            turn = false;

        }
    }
}
