namespace JensMemory
{
    partial class EndGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndGame));
            this.pbxWinner = new System.Windows.Forms.PictureBox();
            this.lblEndGame = new System.Windows.Forms.Label();
            this.btnStartOver = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWinner)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxWinner
            // 
            this.pbxWinner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.pbxWinner.Location = new System.Drawing.Point(108, 75);
            this.pbxWinner.Name = "pbxWinner";
            this.pbxWinner.Size = new System.Drawing.Size(300, 300);
            this.pbxWinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxWinner.TabIndex = 3;
            this.pbxWinner.TabStop = false;
            // 
            // lblEndGame
            // 
            this.lblEndGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.lblEndGame.Font = new System.Drawing.Font("Ketchum", 42F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.lblEndGame.Location = new System.Drawing.Point(414, 75);
            this.lblEndGame.Name = "lblEndGame";
            this.lblEndGame.Size = new System.Drawing.Size(417, 200);
            this.lblEndGame.TabIndex = 4;
            this.lblEndGame.Text = "Congratulations\r\nPlayer.Name!\r\nYou won!";
            // 
            // btnStartOver
            // 
            this.btnStartOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.btnStartOver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStartOver.BackgroundImage")));
            this.btnStartOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStartOver.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnStartOver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.btnStartOver.FlatAppearance.BorderSize = 0;
            this.btnStartOver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.btnStartOver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.btnStartOver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartOver.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnStartOver.Location = new System.Drawing.Point(108, 381);
            this.btnStartOver.Margin = new System.Windows.Forms.Padding(0);
            this.btnStartOver.Name = "btnStartOver";
            this.btnStartOver.Size = new System.Drawing.Size(200, 200);
            this.btnStartOver.TabIndex = 5;
            this.btnStartOver.UseVisualStyleBackColor = false;
            this.btnStartOver.Click += new System.EventHandler(this.btnStartOver_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.btnNewGame.BackgroundImage = global::JensMemory.Properties.Resources.newGame;
            this.btnNewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewGame.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnNewGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.btnNewGame.FlatAppearance.BorderSize = 0;
            this.btnNewGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.btnNewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Location = new System.Drawing.Point(566, 381);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(200, 200);
            this.btnNewGame.TabIndex = 6;
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.btnExit.BackgroundImage = global::JensMemory.Properties.Resources.exitButton;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(325, 511);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 200);
            this.btnExit.TabIndex = 7;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.BackgroundImage = global::JensMemory.Properties.Resources.popUp;
            this.ClientSize = new System.Drawing.Size(850, 720);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnStartOver);
            this.Controls.Add(this.lblEndGame);
            this.Controls.Add(this.pbxWinner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EndGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EndGame";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            ((System.ComponentModel.ISupportInitialize)(this.pbxWinner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxWinner;
        private System.Windows.Forms.Label lblEndGame;
        private System.Windows.Forms.Button btnStartOver;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;
    }
}