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

        }

        private void BakGrundPopUp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            coverChoice = 0;
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            coverChoice = 1;
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            coverChoice = 2;
            this.Close();
        }
    }
}