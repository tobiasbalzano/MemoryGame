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
    public partial class BakGrundPopUp : Form
    {
        public int coverChoice;
        public BakGrundPopUp()
        {
            InitializeComponent();
            lblBackGround.Text = "Choose a background picture";
            GameWindow.setDuration = trackBar1.Value;

        }

        //Där det används samma kod, är det bättre att använda en funktion.

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SetCover(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SetCover(1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SetCover(2);
        }

        void SetCover(int choice)
        {
            coverChoice = choice;
            this.Close();
        }
        
        
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // Väljer betänketiden från trackbaren och sedan skriver ut den.
            lbltimeChoice.Text = trackBar1.Value.ToString() + " seconds";
            GameWindow.setDuration = trackBar1.Value;

        }


    }
}