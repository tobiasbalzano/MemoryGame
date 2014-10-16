namespace JensMemory
{
    partial class GameWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlCardHolder = new System.Windows.Forms.Panel();
            this.lblWhosTurn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxInfo = new System.Windows.Forms.TextBox();
            this.timerCompare = new System.Windows.Forms.Timer(this.components);
            this.timerEndGame = new System.Windows.Forms.Timer(this.components);
            this.ComputerThinks = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlCardHolder
            // 
            this.pnlCardHolder.Location = new System.Drawing.Point(150, 60);
            this.pnlCardHolder.Name = "pnlCardHolder";
            this.pnlCardHolder.Size = new System.Drawing.Size(800, 600);
            this.pnlCardHolder.TabIndex = 0;
            // 
            // lblWhosTurn
            // 
            this.lblWhosTurn.AutoSize = true;
            this.lblWhosTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhosTurn.Location = new System.Drawing.Point(127, 25);
            this.lblWhosTurn.Name = "lblWhosTurn";
            this.lblWhosTurn.Size = new System.Drawing.Size(0, 25);
            this.lblWhosTurn.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aktiv spelare:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(994, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Poäng:";
            // 
            // tbxInfo
            // 
            this.tbxInfo.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInfo.Location = new System.Drawing.Point(997, 60);
            this.tbxInfo.Multiline = true;
            this.tbxInfo.Name = "tbxInfo";
            this.tbxInfo.Size = new System.Drawing.Size(140, 400);
            this.tbxInfo.TabIndex = 5;
            // 
            // timerCompare
            // 
            this.timerCompare.Interval = 1;
            this.timerCompare.Tick += new System.EventHandler(this.timerCompare_Tick);
            // 
            // timerEndGame
            // 
            this.timerEndGame.Interval = 500;
            this.timerEndGame.Tick += new System.EventHandler(this.timerEndGame_Tick);
            // 
            // ComputerThinks
            // 
            this.ComputerThinks.Interval = 1;
            this.ComputerThinks.Tick += new System.EventHandler(this.ComputerThinks_Tick);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.tbxInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWhosTurn);
            this.Controls.Add(this.pnlCardHolder);
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory";
            this.Load += new System.EventHandler(this.GameWindow_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCardHolder;
        private System.Windows.Forms.Label lblWhosTurn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxInfo;
        private System.Windows.Forms.Timer timerCompare;
        private System.Windows.Forms.Timer timerEndGame;
        private System.Windows.Forms.Timer ComputerThinks;
    }
}

