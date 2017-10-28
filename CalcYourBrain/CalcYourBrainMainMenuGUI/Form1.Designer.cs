namespace CalcYourBrainMainMenuGUI
{
    partial class CalcYourBrainMainMenuGUI
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcYourBrainMainMenuGUI));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DifficultyLabel = new System.Windows.Forms.Label();
            this.DifficultyCB = new System.Windows.Forms.ComboBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.CreditsButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.TitleLabel.Location = new System.Drawing.Point(276, 45);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(195, 38);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "CalcYourBrain";
            // 
            // DifficultyLabel
            // 
            this.DifficultyLabel.AutoSize = true;
            this.DifficultyLabel.BackColor = System.Drawing.Color.Transparent;
            this.DifficultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultyLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.DifficultyLabel.Location = new System.Drawing.Point(341, 98);
            this.DifficultyLabel.Name = "DifficultyLabel";
            this.DifficultyLabel.Size = new System.Drawing.Size(62, 13);
            this.DifficultyLabel.TabIndex = 1;
            this.DifficultyLabel.Text = "Difficulté:";
            // 
            // DifficultyCB
            // 
            this.DifficultyCB.FormattingEnabled = true;
            this.DifficultyCB.Items.AddRange(new object[] {
            "Facile",
            "Moyen",
            "Difficile"});
            this.DifficultyCB.Location = new System.Drawing.Point(306, 125);
            this.DifficultyCB.Name = "DifficultyCB";
            this.DifficultyCB.Size = new System.Drawing.Size(121, 21);
            this.DifficultyCB.TabIndex = 2;
            this.DifficultyCB.Text = "Facile";
            // 
            // StartButton
            // 
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.Location = new System.Drawing.Point(316, 176);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(95, 25);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Commencer";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // CreditsButton
            // 
            this.CreditsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreditsButton.Location = new System.Drawing.Point(326, 234);
            this.CreditsButton.Name = "CreditsButton";
            this.CreditsButton.Size = new System.Drawing.Size(75, 23);
            this.CreditsButton.TabIndex = 4;
            this.CreditsButton.Text = "Credits";
            this.CreditsButton.UseVisualStyleBackColor = true;
            this.CreditsButton.Click += new System.EventHandler(this.CreditsButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EndButton.Location = new System.Drawing.Point(326, 284);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(75, 23);
            this.EndButton.TabIndex = 5;
            this.EndButton.Text = "Quitter";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(477, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pour une expérience optimale,\r\nUtilisez un casque et augmentez le volume!";
            // 
            // CalcYourBrainMainMenuGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(767, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.CreditsButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.DifficultyCB);
            this.Controls.Add(this.DifficultyLabel);
            this.Controls.Add(this.TitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalcYourBrainMainMenuGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalcYourBrain - Réveillez vos aptitudes !";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DifficultyLabel;
        private System.Windows.Forms.ComboBox DifficultyCB;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button CreditsButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Label label1;
    }
}

