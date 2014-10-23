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
    public partial class ChooseCharacter : Form
    {
        public ChooseCharacter()
        {

            InitializeComponent();
            UpdateGUI();
            Portrait.BackgroundImage = Portraits[0];
        }
        int aiLevel = 5;
        bool AI = false;
        int click = 1;
        int i = 0;
        int amountOfPlayer;
        List<int> Chosen = new List<int>(); //Lista med värde som visar valda silhouetter. 
        private static Image[] Choices = { Properties.Resources.trainer1S, Properties.Resources.trainer1S, Properties.Resources.trainer1S, Properties.Resources.trainer1S, Properties.Resources.trainer1S, Properties.Resources.trainer1S };
        private string[] TrainerName = { "Player1", "Player2", "Player3", "Player4", "Player5", "Player6" };
        private static Image[] Portraits = { Properties.Resources.trainer1, Properties.Resources.trainer2, Properties.Resources.trainer3, Properties.Resources.trainer4, Properties.Resources.trainer5, Properties.Resources.trainer6 };
        private static Image[] Silhouettes = { Properties.Resources.trainer1S, Properties.Resources.trainer2S, Properties.Resources.trainer3S, Properties.Resources.trainer4S, Properties.Resources.trainer5S, Properties.Resources.trainer6S };
        int EndRange = Portraits.Count() - 1;

        //vänster knappen.
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

        //Höger knappen.
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

        //Uppdaterar GUI efter varje knapptryck.
        private void UpdateGUI()
        {
            EndRange = Portraits.Count() - 1;
            Portrait.BackgroundImage = Portraits[i];
            Character1.BackgroundImage = Choices[0];
            Character2.BackgroundImage = Choices[1];
            Character3.BackgroundImage = Choices[2];
            Character4.BackgroundImage = Choices[3];
            Character5.BackgroundImage = Choices[4];
            Character6.BackgroundImage = Choices[5];
        }

        //Knappen för att välja en AI.
        private void Computer_Click(object sender, EventArgs e)
        {
            click++;
            if (click % 2 == 0)
            {
                Computer.Image = Properties.Resources.choiceRing;
                AI = true;
            }
            else
            {
                Computer.Image = null;
                AI = false;
            }
        }
        public void AIDifficulty_Click(object sender, EventArgs e)
        {
            PictureBox aiDifficulty = sender as PictureBox;
            
            if(aiDifficulty.Image==null)
            {
                aiDifficulty.Image = Properties.Resources.choiceRing;
            }
            else
            {
                aiDifficulty.Image = null;
            }
        }
        //Knappen för att lägga till en spelare.
        private void Choose_Click(object sender, EventArgs e)
        {
            if (Chosen.Contains(i))
            {
                //if the list cotains the value we want to add, do nothing.
                //om listan innehåller värdet som vi vill lägga till, gör inget.
            }
            else
            {
                if (amountOfPlayer <= EndRange)
                {
                    GameWindow.CreatePlayer(TrainerName[i], Portraits[i], AI, aiLevel); //Skapar en spelares namn, bild, människa eller AI.
                    Choices[amountOfPlayer] = Portraits[i]; //visar toma silhouetter för ej valda spelare.
                    Portraits[i] = Silhouettes[i]; //ändrar en tränares bild till silhouettes.
                    amountOfPlayer++;
                    Chosen.Add(i);
                }
                else
                {
                    Choose.Enabled = false;
                }
                UpdateGUI();
            }
        }
        //Klickar för att gå till nästa form/sida.
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (amountOfPlayer >= 2) //Måste välja minnst 2 spelare för att gå vidare.
            {
                this.FormClosing -= new FormClosingEventHandler(this.ChooseCharacter_FormClosing);
                this.Close();
            }
            else
            {

            }
        }
        //Gör att man inte kan stänga ner formen/sidan.
        private void ChooseCharacter_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }

        private void pictureBoxEasy_Click(object sender, EventArgs e)
        {
            AIDifficulty_Click(sender, e);
            aiLevel = 5;
            pictureBoxHard.Image = null;
            pictureBoxMedium.Image = null;
        }

        private void pictureBoxMedium_Click(object sender, EventArgs e)
        {
            AIDifficulty_Click(sender, e);
            aiLevel = 8;
            pictureBoxEasy.Image = null;
            pictureBoxHard.Image = null;
        }

        private void pictureBoxHard_Click(object sender, EventArgs e)
        {
            AIDifficulty_Click(sender, e);
            aiLevel = 11;
            pictureBoxMedium.Image = null;
            pictureBoxEasy.Image = null;                                               
        }
    }
}
