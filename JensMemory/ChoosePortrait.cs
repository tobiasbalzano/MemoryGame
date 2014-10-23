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

        bool AI = false;
        int click = 1;
        int i = 0;
        int amountOfPlayer;
        List<int> Chosen = new List<int>(); //Lista med värde som visar valda silhouetter. 
        private static Image[] Choices;
        private string[] TrainerName = { "Ash", "Misty", "Flannery", "May", "Gary", "Calem" };
        private static Image[] Portraits;
        private static Image[] Silhouettes = { Properties.Resources.trainer1S, Properties.Resources.trainer2S, Properties.Resources.trainer3S, Properties.Resources.trainer4S, Properties.Resources.trainer5S, Properties.Resources.trainer6S };
        int EndRange;
        int aiLevel = 5;

        public ChooseCharacter()
        {

            InitializeComponent();
            Choices = new Image[] { Properties.Resources.emptySilhouette, Properties.Resources.emptySilhouette, Properties.Resources.emptySilhouette, Properties.Resources.emptySilhouette, Properties.Resources.emptySilhouette, Properties.Resources.emptySilhouette };
            Portraits = new Image[] { Properties.Resources.trainer1, Properties.Resources.trainer2, Properties.Resources.trainer3, Properties.Resources.trainer4, Properties.Resources.trainer5, Properties.Resources.trainer6 };
            EndRange = Portraits.Count() - 1;
            UpdateGUI();
            Portrait.BackgroundImage = Portraits[0];
        }

        //vänster knappen.
        private void LeftArrow_Click(object sender, EventArgs e)
        {
            GameWindow.clickForwardFX.Play();
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


        //Höger knappen.
        private void RightArrow_Click(object sender, EventArgs e)
        {
            GameWindow.clickForwardFX.Play();
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

        //Uppdaterar GUI efter varje knapptryck.
        private void UpdateGUI()
        {
            lblChooseChar.Text = TrainerName[i];
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
            GameWindow.clickBackFX.Play();
            click++;
            if (click % 3 == 2)
            {
                Computer.Image = Properties.Resources.AILogo;
                AI = true;
                aiLevel = 5;
            }
            else if (click % 3 == 0)
            {
                Computer.Image = Properties.Resources.AILogoHard;
                AI = true;
                aiLevel = 11;
            }
            else
            {
                Computer.Image = null;
                AI = false;
            }
        }

        //Knappen för att lägga till en spelare.
        private void Choose_Click(object sender, EventArgs e)
        {
            GameWindow.clickBigFX.Play();
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
                    Portraits[i] = Silhouettes[i]; //ändrar en tränares bild till silhouettes efter en tränare har blivit vald.
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
            GameWindow.clickNextFX.Play();
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

        private void exitBox_Click(object sender, EventArgs e)
        {
            GameWindow.creditSong.Play();
            GameWindow.exit.ShowDialog();
        }
    }
}
