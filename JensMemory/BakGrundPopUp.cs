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
            BG1.Location = new System.Drawing.Point(BG1.Location.X, BG1.Location.Y);
            BG1.Size = new System.Drawing.Size(200, 200);
            BG2.Location = new System.Drawing.Point(BG2.Location.X+25, BG2.Location.Y+25);
            BG2.Size = new System.Drawing.Size(150, 150);
            BG3.Location = new System.Drawing.Point(BG3.Location.X+25, BG3.Location.Y+25);
            BG3.Size = new System.Drawing.Size(150, 150);

        }

        //Där det används samma kod, är det bättre att använda en funktion.
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SetCover(0);
            BG1.Location = new System.Drawing.Point(22,250);
            BG1.Size = new System.Drawing.Size(200, 200);
            BG2.Location = new System.Drawing.Point(325+25, 250+25);
            BG2.Size = new System.Drawing.Size(150, 150);
            BG3.Location = new System.Drawing.Point(628+25, 250+25);
            BG3.Size = new System.Drawing.Size(150, 150);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SetCover(1);
            BG1.Location = new System.Drawing.Point(22+25, 250+25);
            BG1.Size = new System.Drawing.Size(150, 150);
            BG2.Location = new System.Drawing.Point(325, 250);
            BG2.Size = new System.Drawing.Size(200, 200);
            BG3.Location = new System.Drawing.Point(628+25, 250+25);
            BG3.Size = new System.Drawing.Size(150, 150);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SetCover(2);
            BG1.Location = new System.Drawing.Point(22+25, 250+25);
            BG1.Size = new System.Drawing.Size(150, 150);
            BG2.Location = new System.Drawing.Point(325+25, 250+25);
            BG2.Size = new System.Drawing.Size(150, 150);
            BG3.Location = new System.Drawing.Point(628, 250);
            BG3.Size = new System.Drawing.Size(200, 200);
        }

        void SetCover(int choice)
        {
            coverChoice = choice;
        }

        private void pictureBoxAdvance_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}