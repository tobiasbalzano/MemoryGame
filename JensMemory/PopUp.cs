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
    public partial class PopUp : Form
    {
        public PopUp()
        {
            InitializeComponent();
            lblGiveName.Text = "Ge namn till spelare 1\noch tryck skapa ny.:";

        }

        private void btnCreatePlayer_Click(object sender, EventArgs e)
        {
            if (tbxName.Text != "")
            {
                GameWindow.CreatePlayer(tbxName.Text);
                tbxName.Text = "";
                lblGiveName.Text = "Ge namn till spelare " + (GameWindow.players.Count + 1) + "\noch tryck skapa ny:";
                this.ActiveControl = tbxName;
                
            }
            else
            {
                lblGiveName.Text = "Du måste ange ett namn";
                this.ActiveControl = tbxName;
            }
            if(GameWindow.players.Count>1)
            {
                btnDone.DialogResult = DialogResult.OK;
                
            }
                      

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (GameWindow.players.Count < 2)
            {
                lblGiveName.Text = "Du måste skapa minst 2st spelare";
            }
            
        }


    }
}
