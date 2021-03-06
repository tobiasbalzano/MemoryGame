﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JensMemory
{
    // Vår klass för korten som ärver ur PictureBox
    public class Card : PictureBox
    {
        // Delegat(metod som skickas som argument) vi begär en metod för klick-event som parameter
        // vid instansiering av nya kort
        public delegate void cardEvent(object sender, EventArgs e);
        // Properties:
        public int id;
        public bool flipped;
        // props för bredd och höjd. Kommer senare anpassas beroende på användarens val av spelplan
        //Konstruktor för nya kort. tar 3st parametrar. 
        public Card(int posX, int posY, int size, cardEvent eventHandler)
        {
            // Här sätts kortets placering med formel som separerar alla kort
            // med dess bredd och höjd + 5 pixlar samt beroende av värden för x och y som tagits emot.
            Location = new System.Drawing.Point(posX * (size + 5), posY * (size + 5));
            Name = "card" + posX + "," + posY;
            Size = new System.Drawing.Size(size, size);
            TabIndex = 0;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Click += new System.EventHandler(eventHandler); //lägger till klickmetoden
        }
    }
}
