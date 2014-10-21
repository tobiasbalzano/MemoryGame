namespace JensMemory
{
    partial class BakGrundPopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BakGrundPopUp));
            this.lblBackGround = new System.Windows.Forms.Label();
            this.BG1 = new System.Windows.Forms.PictureBox();
            this.BG2 = new System.Windows.Forms.PictureBox();
            this.BG3 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lbltimeChoice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BG1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BG3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBackGround
            // 
            resources.ApplyResources(this.lblBackGround, "lblBackGround");
            this.lblBackGround.Name = "lblBackGround";
            this.lblBackGround.Click += new System.EventHandler(this.label1_Click);
            // 
            // BG1
            // 
            resources.ApplyResources(this.BG1, "BG1");
            this.BG1.Image = global::JensMemory.Properties.Resources.newpokeball;
            this.BG1.Name = "BG1";
            this.BG1.TabStop = false;
            this.BG1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BG2
            // 
            resources.ApplyResources(this.BG2, "BG2");
            this.BG2.Image = global::JensMemory.Properties.Resources.newpokemon;
            this.BG2.Name = "BG2";
            this.BG2.TabStop = false;
            this.BG2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BG3
            // 
            resources.ApplyResources(this.BG3, "BG3");
            this.BG3.Image = global::JensMemory.Properties.Resources.newpokemon2;
            this.BG3.Name = "BG3";
            this.BG3.TabStop = false;
            this.BG3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // trackBar1
            // 
            resources.ApplyResources(this.trackBar1, "trackBar1");
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lbltimeChoice
            // 
            resources.ApplyResources(this.lbltimeChoice, "lbltimeChoice");
            this.lbltimeChoice.Name = "lbltimeChoice";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // BakGrundPopUp
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltimeChoice);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.BG3);
            this.Controls.Add(this.BG2);
            this.Controls.Add(this.BG1);
            this.Controls.Add(this.lblBackGround);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BakGrundPopUp";
            ((System.ComponentModel.ISupportInitialize)(this.BG1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BG3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBackGround;
        private System.Windows.Forms.PictureBox BG2;
        private System.Windows.Forms.PictureBox BG3;
        private System.Windows.Forms.PictureBox BG1;
        public System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lbltimeChoice;
        private System.Windows.Forms.Label label1;
    }
}