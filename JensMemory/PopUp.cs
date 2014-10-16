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
            lblGiveName.Text = "Write player name \nAnd click add:";

        }

        private void btnCreatePlayer_Click(object sender, EventArgs e)
        {
            if (tbxName.Text != "")
            {
                if (checkBoxAi.Checked==true)
                {
                    GameWindow.CreatePlayer(tbxName.Text, true);
                }
                else
                {
                    GameWindow.CreatePlayer(tbxName.Text, false);
                }
                tbxName.Text = "";
                lblGiveName.Text = "Write player name " + (GameWindow.players.Count + 1) + "\nAnd click add:";
                this.ActiveControl = tbxName;

            }
            else
            {
                lblGiveName.Text = "Enter a name";
                this.ActiveControl = tbxName;
            }
            if (GameWindow.players.Count > 1)
            {
                btnDone.DialogResult = DialogResult.OK;

            }


        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (GameWindow.players.Count < 2)
            {
                lblGiveName.Text = "Add at least 2 players";
            }

        }

        private void PopUp_Load(object sender, EventArgs e)
        {

        }


    }
}
