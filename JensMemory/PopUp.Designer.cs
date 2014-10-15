namespace JensMemory
{
    partial class PopUp
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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblGiveName = new System.Windows.Forms.Label();
            this.btnCreatePlayer = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.checkBoxAi = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(12, 63);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(206, 20);
            this.tbxName.TabIndex = 0;
            // 
            // lblGiveName
            // 
            this.lblGiveName.AutoSize = true;
            this.lblGiveName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiveName.Location = new System.Drawing.Point(12, 9);
            this.lblGiveName.Name = "lblGiveName";
            this.lblGiveName.Size = new System.Drawing.Size(0, 16);
            this.lblGiveName.TabIndex = 1;
            // 
            // btnCreatePlayer
            // 
            this.btnCreatePlayer.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePlayer.Location = new System.Drawing.Point(12, 99);
            this.btnCreatePlayer.Name = "btnCreatePlayer";
            this.btnCreatePlayer.Size = new System.Drawing.Size(83, 40);
            this.btnCreatePlayer.TabIndex = 2;
            this.btnCreatePlayer.Text = "Skapa ny";
            this.btnCreatePlayer.UseVisualStyleBackColor = true;
            this.btnCreatePlayer.Click += new System.EventHandler(this.btnCreatePlayer_Click);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(153, 100);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(65, 39);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "Klar";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // checkBoxAi
            // 
            this.checkBoxAi.AutoSize = true;
            this.checkBoxAi.Location = new System.Drawing.Point(110, 112);
            this.checkBoxAi.Name = "checkBoxAi";
            this.checkBoxAi.Size = new System.Drawing.Size(36, 17);
            this.checkBoxAi.TabIndex = 4;
            this.checkBoxAi.Text = "AI";
            this.checkBoxAi.UseVisualStyleBackColor = true;
            // 
            // PopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 151);
            this.Controls.Add(this.checkBoxAi);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnCreatePlayer);
            this.Controls.Add(this.lblGiveName);
            this.Controls.Add(this.tbxName);
            this.Name = "PopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Användare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblGiveName;
        private System.Windows.Forms.Button btnCreatePlayer;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.CheckBox checkBoxAi;
    }
}