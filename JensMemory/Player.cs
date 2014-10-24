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
        public bool computer;
        public int AILevel = 5;
        public List<Card> aiMemory = new List<Card>();

        public Player(string name, Image portrait, bool computer, int AILevel)
        {
            this.name = name;
            this.computer = computer;
            this.potrait = portrait;
            this.AILevel = AILevel;
            points = 0;
            turn = false;
        }
    }
}
