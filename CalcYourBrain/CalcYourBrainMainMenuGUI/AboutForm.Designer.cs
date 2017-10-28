namespace CalcYourBrainMainMenuGUI
{
    partial class AboutForm
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
            this.DevLabel = new System.Windows.Forms.Label();
            this.DevNameLabel = new System.Windows.Forms.Label();
            this.DevSurnameLabel = new System.Windows.Forms.Label();
            this.DevImage = new System.Windows.Forms.PictureBox();
            this.ProjectNameLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DevImage)).BeginInit();
            this.SuspendLayout();
            // 
            // DevLabel
            // 
            this.DevLabel.AutoSize = true;
            this.DevLabel.Location = new System.Drawing.Point(55, 36);
            this.DevLabel.Name = "DevLabel";
            this.DevLabel.Size = new System.Drawing.Size(71, 13);
            this.DevLabel.TabIndex = 0;
            this.DevLabel.Text = "Développeur:";
            // 
            // DevNameLabel
            // 
            this.DevNameLabel.AutoSize = true;
            this.DevNameLabel.Location = new System.Drawing.Point(55, 76);
            this.DevNameLabel.Name = "DevNameLabel";
            this.DevNameLabel.Size = new System.Drawing.Size(77, 13);
            this.DevNameLabel.TabIndex = 1;
            this.DevNameLabel.Text = "Nom: Capitano";
            // 
            // DevSurnameLabel
            // 
            this.DevSurnameLabel.AutoSize = true;
            this.DevSurnameLabel.Location = new System.Drawing.Point(55, 111);
            this.DevSurnameLabel.Name = "DevSurnameLabel";
            this.DevSurnameLabel.Size = new System.Drawing.Size(93, 13);
            this.DevSurnameLabel.TabIndex = 2;
            this.DevSurnameLabel.Text = "Prénom: Jonathan";
            // 
            // DevImage
            // 
            this.DevImage.BackgroundImage = global::CalcYourBrainMainMenuGUI.Properties.Resources.Developpeur;
            this.DevImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DevImage.Location = new System.Drawing.Point(276, 36);
            this.DevImage.Name = "DevImage";
            this.DevImage.Size = new System.Drawing.Size(242, 240);
            this.DevImage.TabIndex = 3;
            this.DevImage.TabStop = false;
            // 
            // ProjectNameLabel
            // 
            this.ProjectNameLabel.AutoSize = true;
            this.ProjectNameLabel.Location = new System.Drawing.Point(55, 166);
            this.ProjectNameLabel.Name = "ProjectNameLabel";
            this.ProjectNameLabel.Size = new System.Drawing.Size(77, 13);
            this.ProjectNameLabel.TabIndex = 4;
            this.ProjectNameLabel.Text = "CalcYourBrain:";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(55, 205);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(106, 13);
            this.VersionLabel.TabIndex = 5;
            this.VersionLabel.Text = "Version: 17.10 (Bêta)";
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Location = new System.Drawing.Point(237, 330);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Fermer";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.AutoSize = true;
            this.CopyrightLabel.Location = new System.Drawing.Point(55, 285);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(78, 13);
            this.CopyrightLabel.TabIndex = 7;
            this.CopyrightLabel.Text = "Copyright 2017";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 376);
            this.Controls.Add(this.CopyrightLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.ProjectNameLabel);
            this.Controls.Add(this.DevImage);
            this.Controls.Add(this.DevSurnameLabel);
            this.Controls.Add(this.DevNameLabel);
            this.Controls.Add(this.DevLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credits";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.DevImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DevLabel;
        private System.Windows.Forms.Label DevNameLabel;
        private System.Windows.Forms.Label DevSurnameLabel;
        private System.Windows.Forms.PictureBox DevImage;
        private System.Windows.Forms.Label ProjectNameLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label CopyrightLabel;
    }
}