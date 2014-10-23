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
            this.BG1 = new System.Windows.Forms.PictureBox();
            this.BG2 = new System.Windows.Forms.PictureBox();
            this.BG3 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pigctureBoxAdvance = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BG1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BG3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pigctureBoxAdvance)).BeginInit();
            this.SuspendLayout();
            // 
            // BG1
            // 
            resources.ApplyResources(this.BG1, "BG1");
            this.BG1.Name = "BG1";
            this.BG1.TabStop = false;
            this.BG1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BG2
            // 
            resources.ApplyResources(this.BG2, "BG2");
            this.BG2.Name = "BG2";
            this.BG2.TabStop = false;
            this.BG2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BG3
            // 
            resources.ApplyResources(this.BG3, "BG3");
            this.BG3.Name = "BG3";
            this.BG3.TabStop = false;
            this.BG3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // trackBar1
            // 
            resources.ApplyResources(this.trackBar1, "trackBar1");
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(100)))), ((int)(((byte)(232)))));
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.TickFrequency = 5;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Value = 10;
            // 
            // pigctureBoxAdvance
            // 
            this.pigctureBoxAdvance.BackColor = System.Drawing.Color.Transparent;
            this.pigctureBoxAdvance.BackgroundImage = global::JensMemory.Properties.Resources.nextButton;
            resources.ApplyResources(this.pigctureBoxAdvance, "pigctureBoxAdvance");
            this.pigctureBoxAdvance.Name = "pigctureBoxAdvance";
            this.pigctureBoxAdvance.TabStop = false;
            this.pigctureBoxAdvance.Click += new System.EventHandler(this.pictureBoxAdvance_Click);
            // 
            // BakGrundPopUp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.BackgroundImage = global::JensMemory.Properties.Resources.popUp;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.BG3);
            this.Controls.Add(this.pigctureBoxAdvance);
            this.Controls.Add(this.BG2);
            this.Controls.Add(this.BG1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BakGrundPopUp";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            ((System.ComponentModel.ISupportInitialize)(this.BG1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BG3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pigctureBoxAdvance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BG2;
        private System.Windows.Forms.PictureBox BG3;
        private System.Windows.Forms.PictureBox BG1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pigctureBoxAdvance;
    }
}