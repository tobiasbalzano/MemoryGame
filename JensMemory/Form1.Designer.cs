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
            this.splashBox = new System.Windows.Forms.PictureBox();
            this.timerCompare = new System.Windows.Forms.Timer(this.components);
            this.timerEndGame = new System.Windows.Forms.Timer(this.components);
            this.splashTimer = new System.Windows.Forms.Timer(this.components);
            this.timerTurn = new System.Windows.Forms.Timer(this.components);
            this.exitBox = new System.Windows.Forms.PictureBox();
            this.pictureBoxP1 = new System.Windows.Forms.PictureBox();
            this.lblNameP1 = new System.Windows.Forms.Label();
            this.lblp1Score = new System.Windows.Forms.Label();
            this.lblP1ScoreN = new System.Windows.Forms.Label();
            this.lblNameP2 = new System.Windows.Forms.Label();
            this.lblp2Score = new System.Windows.Forms.Label();
            this.lblP2ScoreN = new System.Windows.Forms.Label();
            this.pictureBoxP2 = new System.Windows.Forms.PictureBox();
            this.lblNameP3 = new System.Windows.Forms.Label();
            this.lblp3Score = new System.Windows.Forms.Label();
            this.lblP3ScoreN = new System.Windows.Forms.Label();
            this.pictureBoxP3 = new System.Windows.Forms.PictureBox();
            this.lblNameP4 = new System.Windows.Forms.Label();
            this.lblp4Score = new System.Windows.Forms.Label();
            this.lblP4ScoreN = new System.Windows.Forms.Label();
            this.pictureBoxP4 = new System.Windows.Forms.PictureBox();
            this.lblNameP5 = new System.Windows.Forms.Label();
            this.lblp5Score = new System.Windows.Forms.Label();
            this.lblP5ScoreN = new System.Windows.Forms.Label();
            this.pictureBoxP5 = new System.Windows.Forms.PictureBox();
            this.lblNameP6 = new System.Windows.Forms.Label();
            this.lblp6Score = new System.Windows.Forms.Label();
            this.lblP6ScoreN = new System.Windows.Forms.Label();
            this.pictureBoxP6 = new System.Windows.Forms.PictureBox();
            this.pictureBoxTurn = new System.Windows.Forms.PictureBox();
            this.lblPlayerTurn = new System.Windows.Forms.Label();
            this.lblTurnAnnounce = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splashBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxP3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxP4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxP5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxP6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTurn)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCardHolder
            // 
            this.pnlCardHolder.BackColor = System.Drawing.Color.Transparent;
            this.pnlCardHolder.Location = new System.Drawing.Point(240, 60);
            this.pnlCardHolder.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCardHolder.Name = "pnlCardHolder";
            this.pnlCardHolder.Size = new System.Drawing.Size(800, 600);
            this.pnlCardHolder.TabIndex = 0;
            // 
            // splashBox
            // 
            this.splashBox.Image = global::JensMemory.Properties.Resources.pokemonSplash;
            this.splashBox.Location = new System.Drawing.Point(1271, 74);
            this.splashBox.Margin = new System.Windows.Forms.Padding(0);
            this.splashBox.Name = "splashBox";
            this.splashBox.Size = new System.Drawing.Size(1280, 720);
            this.splashBox.TabIndex = 6;
            this.splashBox.TabStop = false;
            // 
            // timerEndGame
            // 
            this.timerEndGame.Interval = 500;
            this.timerEndGame.Tick += new System.EventHandler(this.timerEndGame_Tick);
            // 
            // splashTimer
            // 
            this.splashTimer.Interval = 3000;
            this.splashTimer.Tick += new System.EventHandler(this.splashTimer_Tick);
            // 
            // timerTurn
            // 
            this.timerTurn.Interval = 1000;
            this.timerTurn.Tick += new System.EventHandler(this.timerTurn_Tick);
            // 
            // exitBox
            // 
            this.exitBox.BackColor = System.Drawing.Color.Transparent;
            this.exitBox.Image = global::JensMemory.Properties.Resources.exitButton;
            this.exitBox.Location = new System.Drawing.Point(1214, 0);
            this.exitBox.Margin = new System.Windows.Forms.Padding(0);
            this.exitBox.Name = "exitBox";
            this.exitBox.Size = new System.Drawing.Size(66, 64);
            this.exitBox.TabIndex = 8;
            this.exitBox.TabStop = false;
            this.exitBox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxP1
            // 
            this.pictureBoxP1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxP1.Location = new System.Drawing.Point(1050, 74);
            this.pictureBoxP1.Name = "pictureBoxP1";
            this.pictureBoxP1.Size = new System.Drawing.Size(95, 95);
            this.pictureBoxP1.TabIndex = 9;
            this.pictureBoxP1.TabStop = false;
            // 
            // lblNameP1
            // 
            this.lblNameP1.BackColor = System.Drawing.Color.Transparent;
            this.lblNameP1.Font = new System.Drawing.Font("Ketchum", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameP1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.lblNameP1.Location = new System.Drawing.Point(1141, 71);
            this.lblNameP1.Margin = new System.Windows.Forms.Padding(0);
            this.lblNameP1.Name = "lblNameP1";
            this.lblNameP1.Size = new System.Drawing.Size(130, 32);
            this.lblNameP1.TabIndex = 4;
            // 
            // lblp1Score
            // 
            this.lblp1Score.BackColor = System.Drawing.Color.Transparent;
            this.lblp1Score.Font = new System.Drawing.Font("Ketchum", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp1Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.lblp1Score.Location = new System.Drawing.Point(1148, 135);
            this.lblp1Score.Margin = new System.Windows.Forms.Padding(0);
            this.lblp1Score.Name = "lblp1Score";
            this.lblp1Score.Size = new System.Drawing.Size(76, 22);
            this.lblp1Score.TabIndex = 4;
            this.lblp1Score.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblP1ScoreN
            // 
            this.lblP1ScoreN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblP1ScoreN.BackColor = System.Drawing.Color.Transparent;
            this.lblP1ScoreN.Font = new System.Drawing.Font("Ketchum", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1ScoreN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.lblP1ScoreN.Location = new System.Drawing.Point(1214, 118);
            this.lblP1ScoreN.Margin = new System.Windows.Forms.Padding(0);
            this.lblP1ScoreN.Name = "lblP1ScoreN";
            this.lblP1ScoreN.Size = new System.Drawing.Size(57, 43);
            this.lblP1ScoreN.TabIndex = 4;
            this.lblP1ScoreN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNameP2
            // 
            this.lblNameP2.BackColor = System.Drawing.Color.Transparent;
            this.lblNameP2.Font = new System.Drawing.Font("Ketchum", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameP2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.lblNameP2.Location = new System.Drawing.Point(1141, 172);
            this.lblNameP2.Margin = new System.Windows.Forms.Padding(0);
            this.lblNameP2.Name = "lblNameP2";
            this.lblNameP2.Size = new System.Drawing.Size(130, 32);
            this.lblNameP2.TabIndex = 4;
            // 
            // lblp2Score
            // 
            this.lblp2Score.BackColor = System.Drawing.Color.Transparent;
            this.lblp2Score.Font = new System.Drawing.Font("Ketchum", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp2Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.lblp2Score.Location = new System.Drawing.Point(1148, 236);
            this.lblp2Score.Margin = new System.Windows.Forms.Padding(0);
            this.lblp2Score.Name = "lblp2Score";
            this.lblp2Score.Size = new System.Drawing.Size(76, 22);
            this.lblp2Score.TabIndex = 4;
            this.lblp2Score.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblP2ScoreN
            // 
            this.lblP2ScoreN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblP2ScoreN.BackColor = System.Drawing.Color.Transparent;
            this.lblP2ScoreN.Font = new System.Drawing.Font("Ketchum", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2ScoreN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.lblP2ScoreN.Location = new System.Drawing.Point(1214, 219);
            this.lblP2ScoreN.Margin = new System.Windows.Forms.Padding(0);
            this.lblP2ScoreN.Name = "lblP2ScoreN";
            this.lblP2ScoreN.Size = new System.Drawing.Size(57, 43);
            this.lblP2ScoreN.TabIndex = 4;
            this.lblP2ScoreN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxP2
            // 
            this.pictureBoxP2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxP2.Location = new System.Drawing.Point(1050, 175);
            this.pictureBoxP2.Name = "pictureBoxP2";
            this.pictureBoxP2.Size = new System.Drawing.Size(95, 95);
            this.pictureBoxP2.TabIndex = 9;
            this.pictureBoxP2.TabStop = false;
            // 
            // lblNameP3
            // 
            this.lblNameP3.BackColor = System.Drawing.Color.Transparent;
            this.lblNameP3.Font = new System.Drawing.Font("Ketchum", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameP3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.lblNameP3.Location = new System.Drawing.Point(1141, 273);
            this.lblNameP3.Margin = new System.Windows.Forms.Padding(0);
            this.lblNameP3.Name = "lblNameP3";
            this.lblNameP3.Size = new System.Drawing.Size(130, 32);
            this.lblNameP3.TabIndex = 4;
            // 
            // lblp3Score
            // 
            this.lblp3Score.BackColor = System.Drawing.Color.Transparent;
            this.lblp3Score.Font = new System.Drawing.Font("Ketchum", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp3Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.lblp3Score.Location = new System.Drawing.Point(1148, 337);
            this.lblp3Score.Margin = new System.Windows.Forms.Padding(0);
            this.lblp3Score.Name = "lblp3Score";
            this.lblp3Score.Size = new System.Drawing.Size(76, 22);
            this.lblp3Score.TabIndex = 4;
            this.lblp3Score.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblP3ScoreN
            // 
            this.lblP3ScoreN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblP3ScoreN.BackColor = System.Drawing.Color.Transparent;
            this.lblP3ScoreN.Font = new System.Drawing.Font("Ketchum", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP3ScoreN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.lblP3ScoreN.Location = new System.Drawing.Point(1214, 320);
            this.lblP3ScoreN.Margin = new System.Windows.Forms.Padding(0);
            this.lblP3ScoreN.Name = "lblP3ScoreN";
            this.lblP3ScoreN.Size = new System.Drawing.Size(57, 43);
            this.lblP3ScoreN.TabIndex = 4;
            this.lblP3ScoreN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxP3
            // 
            this.pictureBoxP3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxP3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxP3.Location = new System.Drawing.Point(1050, 276);
            this.pictureBoxP3.Name = "pictureBoxP3";
            this.pictureBoxP3.Size = new System.Drawing.Size(95, 95);
            this.pictureBoxP3.TabIndex = 9;
            this.pictureBoxP3.TabStop = false;
            // 
            // lblNameP4
            // 
            this.lblNameP4.BackColor = System.Drawing.Color.Transparent;
            this.lblNameP4.Font = new System.Drawing.Font("Ketchum", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameP4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.lblNameP4.Location = new System.Drawing.Point(1141, 374);
            this.lblNameP4.Margin = new System.Windows.Forms.Padding(0);
            this.lblNameP4.Name = "lblNameP4";
            this.lblNameP4.Size = new System.Drawing.Size(130, 32);
            this.lblNameP4.TabIndex = 4;
            // 
            // lblp4Score
            // 
            this.lblp4Score.BackColor = System.Drawing.Color.Transparent;
            this.lblp4Score.Font = new System.Drawing.Font("Ketchum", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp4Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.lblp4Score.Location = new System.Drawing.Point(1148, 438);
            this.lblp4Score.Margin = new System.Windows.Forms.Padding(0);
            this.lblp4Score.Name = "lblp4Score";
            this.lblp4Score.Size = new System.Drawing.Size(76, 22);
            this.lblp4Score.TabIndex = 4;
            this.lblp4Score.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblP4ScoreN
            // 
            this.lblP4ScoreN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblP4ScoreN.BackColor = System.Drawing.Color.Transparent;
            this.lblP4ScoreN.Font = new System.Drawing.Font("Ketchum", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP4ScoreN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.lblP4ScoreN.Location = new System.Drawing.Point(1214, 421);
            this.lblP4ScoreN.Margin = new System.Windows.Forms.Padding(0);
            this.lblP4ScoreN.Name = "lblP4ScoreN";
            this.lblP4ScoreN.Size = new System.Drawing.Size(57, 43);
            this.lblP4ScoreN.TabIndex = 4;
            this.lblP4ScoreN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxP4
            // 
            this.pictureBoxP4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxP4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxP4.Location = new System.Drawing.Point(1050, 377);
            this.pictureBoxP4.Name = "pictureBoxP4";
            this.pictureBoxP4.Size = new System.Drawing.Size(95, 95);
            this.pictureBoxP4.TabIndex = 9;
            this.pictureBoxP4.TabStop = false;
            // 
            // lblNameP5
            // 
            this.lblNameP5.BackColor = System.Drawing.Color.Transparent;
            this.lblNameP5.Font = new System.Drawing.Font("Ketchum", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameP5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.lblNameP5.Location = new System.Drawing.Point(1141, 475);
            this.lblNameP5.Margin = new System.Windows.Forms.Padding(0);
            this.lblNameP5.Name = "lblNameP5";
            this.lblNameP5.Size = new System.Drawing.Size(130, 32);
            this.lblNameP5.TabIndex = 4;
            // 
            // lblp5Score
            // 
            this.lblp5Score.BackColor = System.Drawing.Color.Transparent;
            this.lblp5Score.Font = new System.Drawing.Font("Ketchum", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp5Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.lblp5Score.Location = new System.Drawing.Point(1148, 539);
            this.lblp5Score.Margin = new System.Windows.Forms.Padding(0);
            this.lblp5Score.Name = "lblp5Score";
            this.lblp5Score.Size = new System.Drawing.Size(76, 22);
            this.lblp5Score.TabIndex = 4;
            this.lblp5Score.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblP5ScoreN
            // 
            this.lblP5ScoreN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblP5ScoreN.BackColor = System.Drawing.Color.Transparent;
            this.lblP5ScoreN.Font = new System.Drawing.Font("Ketchum", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP5ScoreN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.lblP5ScoreN.Location = new System.Drawing.Point(1214, 522);
            this.lblP5ScoreN.Margin = new System.Windows.Forms.Padding(0);
            this.lblP5ScoreN.Name = "lblP5ScoreN";
            this.lblP5ScoreN.Size = new System.Drawing.Size(57, 43);
            this.lblP5ScoreN.TabIndex = 4;
            this.lblP5ScoreN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxP5
            // 
            this.pictureBoxP5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxP5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxP5.Location = new System.Drawing.Point(1050, 478);
            this.pictureBoxP5.Name = "pictureBoxP5";
            this.pictureBoxP5.Size = new System.Drawing.Size(95, 95);
            this.pictureBoxP5.TabIndex = 9;
            this.pictureBoxP5.TabStop = false;
            // 
            // lblNameP6
            // 
            this.lblNameP6.BackColor = System.Drawing.Color.Transparent;
            this.lblNameP6.Font = new System.Drawing.Font("Ketchum", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameP6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.lblNameP6.Location = new System.Drawing.Point(1141, 576);
            this.lblNameP6.Margin = new System.Windows.Forms.Padding(0);
            this.lblNameP6.Name = "lblNameP6";
            this.lblNameP6.Size = new System.Drawing.Size(130, 32);
            this.lblNameP6.TabIndex = 4;
            // 
            // lblp6Score
            // 
            this.lblp6Score.BackColor = System.Drawing.Color.Transparent;
            this.lblp6Score.Font = new System.Drawing.Font("Ketchum", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp6Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.lblp6Score.Location = new System.Drawing.Point(1148, 640);
            this.lblp6Score.Margin = new System.Windows.Forms.Padding(0);
            this.lblp6Score.Name = "lblp6Score";
            this.lblp6Score.Size = new System.Drawing.Size(76, 22);
            this.lblp6Score.TabIndex = 4;
            this.lblp6Score.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblP6ScoreN
            // 
            this.lblP6ScoreN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblP6ScoreN.BackColor = System.Drawing.Color.Transparent;
            this.lblP6ScoreN.Font = new System.Drawing.Font("Ketchum", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP6ScoreN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.lblP6ScoreN.Location = new System.Drawing.Point(1214, 623);
            this.lblP6ScoreN.Margin = new System.Windows.Forms.Padding(0);
            this.lblP6ScoreN.Name = "lblP6ScoreN";
            this.lblP6ScoreN.Size = new System.Drawing.Size(57, 43);
            this.lblP6ScoreN.TabIndex = 4;
            this.lblP6ScoreN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxP6
            // 
            this.pictureBoxP6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxP6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxP6.Location = new System.Drawing.Point(1050, 579);
            this.pictureBoxP6.Name = "pictureBoxP6";
            this.pictureBoxP6.Size = new System.Drawing.Size(95, 95);
            this.pictureBoxP6.TabIndex = 9;
            this.pictureBoxP6.TabStop = false;
            // 
            // pictureBoxTurn
            // 
            this.pictureBoxTurn.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTurn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxTurn.Location = new System.Drawing.Point(12, 135);
            this.pictureBoxTurn.Name = "pictureBoxTurn";
            this.pictureBoxTurn.Size = new System.Drawing.Size(180, 180);
            this.pictureBoxTurn.TabIndex = 9;
            this.pictureBoxTurn.TabStop = false;
            // 
            // lblPlayerTurn
            // 
            this.lblPlayerTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerTurn.Font = new System.Drawing.Font("Ketchum", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTurn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.lblPlayerTurn.Location = new System.Drawing.Point(15, 318);
            this.lblPlayerTurn.Name = "lblPlayerTurn";
            this.lblPlayerTurn.Size = new System.Drawing.Size(222, 100);
            this.lblPlayerTurn.TabIndex = 10;
            // 
            // lblTurnAnnounce
            // 
            this.lblTurnAnnounce.BackColor = System.Drawing.Color.Transparent;
            this.lblTurnAnnounce.Font = new System.Drawing.Font("Ketchum", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnAnnounce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.lblTurnAnnounce.Location = new System.Drawing.Point(12, 32);
            this.lblTurnAnnounce.Margin = new System.Windows.Forms.Padding(0);
            this.lblTurnAnnounce.Name = "lblTurnAnnounce";
            this.lblTurnAnnounce.Size = new System.Drawing.Size(225, 129);
            this.lblTurnAnnounce.TabIndex = 10;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.BackgroundImage = global::JensMemory.Properties.Resources.MainBG;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pictureBoxTurn);
            this.Controls.Add(this.lblTurnAnnounce);
            this.Controls.Add(this.lblPlayerTurn);
            this.Controls.Add(this.splashBox);
            this.Controls.Add(this.pictureBoxP6);
            this.Controls.Add(this.lblP6ScoreN);
            this.Controls.Add(this.pictureBoxP5);
            this.Controls.Add(this.lblP5ScoreN);
            this.Controls.Add(this.pictureBoxP4);
            this.Controls.Add(this.lblP4ScoreN);
            this.Controls.Add(this.pictureBoxP3);
            this.Controls.Add(this.lblp6Score);
            this.Controls.Add(this.lblP3ScoreN);
            this.Controls.Add(this.lblp5Score);
            this.Controls.Add(this.pictureBoxP2);
            this.Controls.Add(this.lblp4Score);
            this.Controls.Add(this.lblP2ScoreN);
            this.Controls.Add(this.lblNameP6);
            this.Controls.Add(this.lblp3Score);
            this.Controls.Add(this.lblNameP5);
            this.Controls.Add(this.pictureBoxP1);
            this.Controls.Add(this.lblNameP4);
            this.Controls.Add(this.lblp2Score);
            this.Controls.Add(this.lblNameP3);
            this.Controls.Add(this.lblP1ScoreN);
            this.Controls.Add(this.lblNameP2);
            this.Controls.Add(this.lblp1Score);
            this.Controls.Add(this.lblNameP1);
            this.Controls.Add(this.exitBox);
            this.Controls.Add(this.pnlCardHolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            ((System.ComponentModel.ISupportInitialize)(this.splashBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxP3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxP4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxP5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxP6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTurn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCardHolder;
        private System.Windows.Forms.Timer timerCompare;
        private System.Windows.Forms.Timer timerEndGame;
        private System.Windows.Forms.Timer splashTimer;
        private System.Windows.Forms.PictureBox splashBox;
        private System.Windows.Forms.Timer timerTurn;
        private System.Windows.Forms.PictureBox exitBox;
        private System.Windows.Forms.PictureBox pictureBoxP1;
        private System.Windows.Forms.Label lblNameP1;
        private System.Windows.Forms.Label lblp1Score;
        private System.Windows.Forms.Label lblP1ScoreN;
        private System.Windows.Forms.Label lblNameP2;
        private System.Windows.Forms.Label lblp2Score;
        private System.Windows.Forms.Label lblP2ScoreN;
        private System.Windows.Forms.PictureBox pictureBoxP2;
        private System.Windows.Forms.Label lblNameP3;
        private System.Windows.Forms.Label lblp3Score;
        private System.Windows.Forms.Label lblP3ScoreN;
        private System.Windows.Forms.PictureBox pictureBoxP3;
        private System.Windows.Forms.Label lblNameP4;
        private System.Windows.Forms.Label lblp4Score;
        private System.Windows.Forms.Label lblP4ScoreN;
        private System.Windows.Forms.PictureBox pictureBoxP4;
        private System.Windows.Forms.Label lblNameP5;
        private System.Windows.Forms.Label lblp5Score;
        private System.Windows.Forms.Label lblP5ScoreN;
        private System.Windows.Forms.PictureBox pictureBoxP5;
        private System.Windows.Forms.Label lblNameP6;
        private System.Windows.Forms.Label lblp6Score;
        private System.Windows.Forms.Label lblP6ScoreN;
        private System.Windows.Forms.PictureBox pictureBoxP6;
        private System.Windows.Forms.PictureBox pictureBoxTurn;
        private System.Windows.Forms.Label lblPlayerTurn;
        private System.Windows.Forms.Label lblTurnAnnounce;
    }
}

