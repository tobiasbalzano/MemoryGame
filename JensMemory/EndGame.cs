using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JensMemory
{
    public partial class EndGame : Form
    {
        bool win;

        public EndGame(bool _win)
        {
            win = _win;

            InitializeComponent();

            if (win)//skriver ut vem som vann.
            {
                pbxWinner.Image = GameWindow.winnerList[0].potrait;
                lblEndGame.Text = "Congratulations\n" + GameWindow.winnerList[0].name + "!\nYou won!";
            }
            else
            {
                //skriver ut om det blir lika.
                pbxWinner.Image = Properties.Resources.newpokemon;
                lblEndGame.Text = "Draw!\nNobody wins!";
            }
        }
    }
}
