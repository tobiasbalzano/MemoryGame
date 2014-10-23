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
            this.pigctureBoxAdvance = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exitBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BG1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BG3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pigctureBoxAdvance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BG1
            // 
            this.BG1.BackColor = System.Drawing.Color.Transparent;
            this.BG1.BackgroundImage = global::JensMemory.Properties.Resources.newpokeball;
            resources.ApplyResources(this.BG1, "BG1");
            this.BG1.Name = "BG1";
            this.BG1.TabStop = false;
            this.BG1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BG2
            // 
            this.BG2.BackColor = System.Drawing.Color.Transparent;
            this.BG2.BackgroundImage = global::JensMemory.Properties.Resources.newpokemon;
            resources.ApplyResources(this.BG2, "BG2");
            this.BG2.Name = "BG2";
            this.BG2.TabStop = false;
            this.BG2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BG3
            // 
            this.BG3.BackColor = System.Drawing.Color.Transparent;
            this.BG3.BackgroundImage = global::JensMemory.Properties.Resources.newpokemon2;
            resources.ApplyResources(this.BG3, "BG3");
            this.BG3.Name = "BG3";
            this.BG3.TabStop = false;
            this.BG3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pigctureBoxAdvance
            // 
            this.pigctureBoxAdvance.BackColor = System.Drawing.Color.Transparent;
            this.pigctureBoxAdvance.BackgroundImage = global::JensMemory.Properties.Resources.playBoardButton;
            resources.ApplyResources(this.pigctureBoxAdvance, "pigctureBoxAdvance");
            this.pigctureBoxAdvance.Name = "pigctureBoxAdvance";
            this.pigctureBoxAdvance.TabStop = false;
            this.pigctureBoxAdvance.Click += new System.EventHandler(this.pictureBoxAdvance_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.label1.Name = "label1";
            // 
            // exitBox
            // 
            this.exitBox.BackColor = System.Drawing.Color.Transparent;
            this.exitBox.Image = global::JensMemory.Properties.Resources.closeWindowButton;
            resources.ApplyResources(this.exitBox, "exitBox");
            this.exitBox.Name = "exitBox";
            this.exitBox.TabStop = false;
            this.exitBox.Click += new System.EventHandler(this.exitBox_Click);
            // 
            // BakGrundPopUp
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.BackgroundImage = global::JensMemory.Properties.Resources.popUp;
            this.Controls.Add(this.exitBox);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pigctureBoxAdvance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BG2;
        private System.Windows.Forms.PictureBox BG3;
        private System.Windows.Forms.PictureBox BG1;
        private System.Windows.Forms.PictureBox pigctureBoxAdvance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox exitBox;
    }
}