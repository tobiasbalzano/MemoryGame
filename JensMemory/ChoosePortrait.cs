﻿using System;
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
    public partial class ChooseCharacter : Form
    {

        public ChooseCharacter()
        {
            
            InitializeComponent();
            Portrait.BackgroundImage = Portraits[0];
        }

        private string[] TrainerName = { "Player1", "Plyer2", "Player3", "Player4", "Player5", "Player6" };
        int i = 0;
        int amountOfPlayer;
        private static Image[] Portraits = { Properties.Resources.trainer1, Properties.Resources.trainer2, Properties.Resources.trainer3, Properties.Resources.trainer4, Properties.Resources.trainer5, Properties.Resources.trainer6 };
        private static Image[] Silhouettes = { Properties.Resources.trainer1S, Properties.Resources.trainer2S, Properties.Resources.trainer3S, Properties.Resources.trainer4S, Properties.Resources.trainer5S, Properties.Resources.trainer6S };
        int EndRange = Portraits.Count() - 1;

        private void LeftArrow_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                i = EndRange;
            }
            else
            {
                i--;
            }
            UpdateGUI();
        }

        private void Portrait_Click(object sender, EventArgs e)
        {

        }

        private void RightArrow_Click(object sender, EventArgs e)
        {
            if (i == EndRange)
            {
                i = 0;
            }
            else
            {
                i++;
            }
            UpdateGUI();    
        }

        private void ChooseCharacter_Load(object sender, EventArgs e)
        {
            
        }

        private void UpdateGUI()
        {
            Portrait.BackgroundImage = Portraits[i];

            //Character1.BackgroundImage = GameWindow.players[0].potrait;
        }

        private void Computer_Click(object sender, EventArgs e)
        {
            
        }

        private void Choose_Click(object sender, EventArgs e)
        {
            amountOfPlayer++;
            GameWindow.CreatePlayer(TrainerName[i], Portraits[i], true);
            Character1.BackgroundImage = GameWindow.players[0].potrait;
        }
    }
}
