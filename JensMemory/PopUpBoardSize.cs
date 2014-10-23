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
    public partial class PopUpBoardSize : Form
    {
        Image[] smallBoards = new Image[3] { Properties.Resources.boardSz4x4, Properties.Resources.boardSz5x4, Properties.Resources.boardSz6x5 };
        Image[] mediumBoards = new Image[3] { Properties.Resources.boardSz6x6, Properties.Resources.boardSz8x6, Properties.Resources.boardSz8x8 };
        Image[] largeBoards = new Image[3] { Properties.Resources.boardSz10x8, Properties.Resources.boardSz10x10, Properties.Resources.boardSz12x10 };
        Image[] boardArray;
        static dimensions _4x4 = new dimensions(4, 4);
        static dimensions _5x4 = new dimensions(5, 4);
        static dimensions _6x5 = new dimensions(6, 5);
        static dimensions _6x6 = new dimensions(6, 6);
        static dimensions _8x6 = new dimensions(8, 6);
        static dimensions _8x8 = new dimensions(8, 8);
        static dimensions _10x8 = new dimensions(10, 8);
        static dimensions _10x10 = new dimensions(10, 10);
        static dimensions _12x10 = new dimensions(12, 10);
        static dimensions[] smallDimensions = new dimensions[] { _4x4, _5x4, _6x5 };
        static dimensions[] mediumDimensions = new dimensions[] { _6x6, _8x6, _8x8 };
        static dimensions[] largeDimensions = new dimensions[] { _10x8, _10x10, _12x10 };
        static dimensions[] activeDimensions;
        dimensions sendDimensions;
        int choice;

        public PopUpBoardSize()
        {
            InitializeComponent();
        }
        private void pbSmallBtn_Click(object sender, EventArgs e)
        {
            GameWindow.clickForwardFX.Play();
            boardArray = smallBoards;
            activeDimensions = smallDimensions;
            updateGui();
        }

        private void pbMedBtn_Click(object sender, EventArgs e)
        {
            GameWindow.clickForwardFX.Play();
            boardArray = mediumBoards;
            activeDimensions = mediumDimensions;
            updateGui();
        }

        private void pbLargeBtn_Click(object sender, EventArgs e)
        {
            GameWindow.clickForwardFX.Play();
            boardArray = largeBoards;
            activeDimensions = largeDimensions;
            updateGui();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            GameWindow.clickNextFX.Play();
            sendDimensions = activeDimensions[choice];
            GameWindow.columns = sendDimensions.collumns;
            GameWindow.rows = sendDimensions.rows;
            this.FormClosing -= new FormClosingEventHandler(this.PopUpBoardSize_FormClosing);
            this.Close();
        }

        private void choice1Btn_Click(object sender, EventArgs e)
        {
            GameWindow.clickBackFX.Play();
            choice = 0;
            choice1Btn.Image = Properties.Resources.choiceRing;
            choice2Btn.Image = null;
            choice3Btn.Image = null;
            confirmBtn.Enabled = true;
        }

        private void choice2Btn_Click(object sender, EventArgs e)
        {
            GameWindow.clickBackFX.Play();
            choice = 1;
            choice2Btn.Image = Properties.Resources.choiceRing;
            choice1Btn.Image = null;
            choice3Btn.Image = null;
            confirmBtn.Enabled = true;
        }

        private void choice3Btn_Click(object sender, EventArgs e)
        {
            GameWindow.clickBackFX.Play();
            choice = 2;
            choice3Btn.Image = Properties.Resources.choiceRing;
            choice2Btn.Image = null;
            choice1Btn.Image = null;
            confirmBtn.Enabled = true;
        }
        public void updateGui()
        {
            choice1Btn.BackgroundImage = boardArray[0];
            choice2Btn.BackgroundImage = boardArray[1];
            choice3Btn.BackgroundImage = boardArray[2];
        }

        private void PopUpBoardSize_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }
    }
    public class dimensions
    {
        public int collumns;
        public int rows;

        public dimensions(int _collumns, int _rows) //Constructor med parametrar
        {
            collumns = _collumns;
            rows = _rows;
        }

    }
}
