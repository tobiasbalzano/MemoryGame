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
            Portrait.BackgroundImage = Portraits[0];
        }

        int i = 0;
        private static Image[] Portraits = { Properties.Resources.trainer1, Properties.Resources.trainer2, Properties.Resources.trainer3, Properties.Resources.trainer4, Properties.Resources.trainer5, Properties.Resources.trainer6 };
        private static Image[] Silhouettes = { Properties.Resources.trainer1S, Properties.Resources.trainer2S, Properties.Resources.trainer3S, Properties.Resources.trainer4S, Properties.Resources.trainer5S, Properties.Resources.trainer6S };
        //public static List<Image> trainer = new List<Image>();
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
        }
    }
}
