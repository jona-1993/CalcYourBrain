namespace CalcYourBrainMainMenuGUI
{
    partial class CalcYourBrainGameGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcYourBrainGameGUI));
            this.TitleCalcLabel = new System.Windows.Forms.Label();
            this.CalcLabel = new System.Windows.Forms.Label();
            this.ResponseTB = new System.Windows.Forms.TextBox();
            this.SoumettreButton = new System.Windows.Forms.Button();
            this.TitleScore = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.TitleNiveauLabel = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.AbandonButton = new System.Windows.Forms.Button();
            this.TimerQuestion = new System.Windows.Forms.Timer(this.components);
            this.TitleTempsRestantLabel = new System.Windows.Forms.Label();
            this.TempsRestantLabel = new System.Windows.Forms.Label();
            this.SuspensTimer = new System.Windows.Forms.Timer(this.components);
            this.TitleDifficultyLabel = new System.Windows.Forms.Label();
            this.DifficultyLabel = new System.Windows.Forms.Label();
            this.ScreamerPanel = new System.Windows.Forms.Panel();
            this.ScreamerTimer = new System.Windows.Forms.Timer(this.components);
            this.GamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleCalcLabel
            // 
            this.TitleCalcLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleCalcLabel.AutoSize = true;
            this.TitleCalcLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleCalcLabel.Location = new System.Drawing.Point(188, 137);
            this.TitleCalcLabel.Name = "TitleCalcLabel";
            this.TitleCalcLabel.Size = new System.Drawing.Size(92, 31);
            this.TitleCalcLabel.TabIndex = 0;
            this.TitleCalcLabel.Text = "Calcul:";
            // 
            // CalcLabel
            // 
            this.CalcLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CalcLabel.AutoSize = true;
            this.CalcLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcLabel.Location = new System.Drawing.Point(241, 193);
            this.CalcLabel.Name = "CalcLabel";
            this.CalcLabel.Size = new System.Drawing.Size(75, 31);
            this.CalcLabel.TabIndex = 1;
            this.CalcLabel.Text = "None";
            // 
            // ResponseTB
            // 
            this.ResponseTB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ResponseTB.Location = new System.Drawing.Point(247, 241);
            this.ResponseTB.Name = "ResponseTB";
            this.ResponseTB.Size = new System.Drawing.Size(198, 20);
            this.ResponseTB.TabIndex = 2;
            // 
            // SoumettreButton
            // 
            this.SoumettreButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SoumettreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SoumettreButton.Location = new System.Drawing.Point(277, 281);
            this.SoumettreButton.Name = "SoumettreButton";
            this.SoumettreButton.Size = new System.Drawing.Size(149, 35);
            this.SoumettreButton.TabIndex = 4;
            this.SoumettreButton.Text = "Soumettre";
            this.SoumettreButton.UseVisualStyleBackColor = true;
            this.SoumettreButton.Click += new System.EventHandler(this.SoumettreButton_Click);
            // 
            // TitleScore
            // 
            this.TitleScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleScore.AutoSize = true;
            this.TitleScore.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleScore.Location = new System.Drawing.Point(580, 22);
            this.TitleScore.Name = "TitleScore";
            this.TitleScore.Size = new System.Drawing.Size(63, 23);
            this.TitleScore.TabIndex = 5;
            this.TitleScore.Text = "Score:";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(649, 21);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(21, 24);
            this.ScoreLabel.TabIndex = 6;
            this.ScoreLabel.Text = "0";
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.Color.Transparent;
            this.GamePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GamePanel.BackgroundImage")));
            this.GamePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GamePanel.Controls.Add(this.ScreamerPanel);
            this.GamePanel.Controls.Add(this.DifficultyLabel);
            this.GamePanel.Controls.Add(this.TitleDifficultyLabel);
            this.GamePanel.Controls.Add(this.TempsRestantLabel);
            this.GamePanel.Controls.Add(this.TitleTempsRestantLabel);
            this.GamePanel.Controls.Add(this.AbandonButton);
            this.GamePanel.Controls.Add(this.LevelLabel);
            this.GamePanel.Controls.Add(this.TitleNiveauLabel);
            this.GamePanel.Controls.Add(this.ResponseTB);
            this.GamePanel.Controls.Add(this.TitleCalcLabel);
            this.GamePanel.Controls.Add(this.CalcLabel);
            this.GamePanel.Controls.Add(this.ScoreLabel);
            this.GamePanel.Controls.Add(this.TitleScore);
            this.GamePanel.Controls.Add(this.SoumettreButton);
            this.GamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamePanel.Location = new System.Drawing.Point(0, 0);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(725, 432);
            this.GamePanel.TabIndex = 7;
            // 
            // TitleNiveauLabel
            // 
            this.TitleNiveauLabel.AutoSize = true;
            this.TitleNiveauLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleNiveauLabel.Location = new System.Drawing.Point(13, 9);
            this.TitleNiveauLabel.Name = "TitleNiveauLabel";
            this.TitleNiveauLabel.Size = new System.Drawing.Size(76, 23);
            this.TitleNiveauLabel.TabIndex = 7;
            this.TitleNiveauLabel.Text = "Niveau:";
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLabel.Location = new System.Drawing.Point(95, 8);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(21, 24);
            this.LevelLabel.TabIndex = 8;
            this.LevelLabel.Text = "1";
            // 
            // AbandonButton
            // 
            this.AbandonButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AbandonButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AbandonButton.Location = new System.Drawing.Point(573, 366);
            this.AbandonButton.Name = "AbandonButton";
            this.AbandonButton.Size = new System.Drawing.Size(109, 44);
            this.AbandonButton.TabIndex = 9;
            this.AbandonButton.Text = "Abandonner";
            this.AbandonButton.UseVisualStyleBackColor = true;
            this.AbandonButton.Click += new System.EventHandler(this.AbandonButton_Click);
            // 
            // TimerQuestion
            // 
            this.TimerQuestion.Interval = 1000;
            this.TimerQuestion.Tick += new System.EventHandler(this.TimerQuestion_Tick);
            // 
            // TitleTempsRestantLabel
            // 
            this.TitleTempsRestantLabel.AutoSize = true;
            this.TitleTempsRestantLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTempsRestantLabel.Location = new System.Drawing.Point(13, 43);
            this.TitleTempsRestantLabel.Name = "TitleTempsRestantLabel";
            this.TitleTempsRestantLabel.Size = new System.Drawing.Size(136, 22);
            this.TitleTempsRestantLabel.TabIndex = 10;
            this.TitleTempsRestantLabel.Text = "Temps Restant: ";
            // 
            // TempsRestantLabel
            // 
            this.TempsRestantLabel.AutoSize = true;
            this.TempsRestantLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempsRestantLabel.Location = new System.Drawing.Point(155, 43);
            this.TempsRestantLabel.Name = "TempsRestantLabel";
            this.TempsRestantLabel.Size = new System.Drawing.Size(42, 23);
            this.TempsRestantLabel.TabIndex = 11;
            this.TempsRestantLabel.Text = "INF";
            // 
            // SuspensTimer
            // 
            this.SuspensTimer.Interval = 1000;
            this.SuspensTimer.Tick += new System.EventHandler(this.SuspensTimer_Tick);
            // 
            // TitleDifficultyLabel
            // 
            this.TitleDifficultyLabel.AutoSize = true;
            this.TitleDifficultyLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleDifficultyLabel.Location = new System.Drawing.Point(13, 75);
            this.TitleDifficultyLabel.Name = "TitleDifficultyLabel";
            this.TitleDifficultyLabel.Size = new System.Drawing.Size(97, 22);
            this.TitleDifficultyLabel.TabIndex = 12;
            this.TitleDifficultyLabel.Text = "Difficulté: ";
            // 
            // DifficultyLabel
            // 
            this.DifficultyLabel.AutoSize = true;
            this.DifficultyLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultyLabel.Location = new System.Drawing.Point(116, 75);
            this.DifficultyLabel.Name = "DifficultyLabel";
            this.DifficultyLabel.Size = new System.Drawing.Size(60, 23);
            this.DifficultyLabel.TabIndex = 13;
            this.DifficultyLabel.Text = "Facile";
            // 
            // ScreamerPanel
            // 
            this.ScreamerPanel.BackColor = System.Drawing.Color.Transparent;
            this.ScreamerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScreamerPanel.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ScreamerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScreamerPanel.Location = new System.Drawing.Point(0, 0);
            this.ScreamerPanel.Name = "ScreamerPanel";
            this.ScreamerPanel.Size = new System.Drawing.Size(725, 432);
            this.ScreamerPanel.TabIndex = 14;
            this.ScreamerPanel.Visible = false;
            // 
            // ScreamerTimer
            // 
            this.ScreamerTimer.Interval = 2000;
            this.ScreamerTimer.Tick += new System.EventHandler(this.ScreamerTimer_Tick);
            // 
            // CalcYourBrainGameGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(725, 432);
            this.Controls.Add(this.GamePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalcYourBrainGameGUI";
            this.Text = "CalcYourBrainGameGUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.GamePanel.ResumeLayout(false);
            this.GamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleCalcLabel;
        private System.Windows.Forms.Label CalcLabel;
        private System.Windows.Forms.TextBox ResponseTB;
        private System.Windows.Forms.Button SoumettreButton;
        private System.Windows.Forms.Label TitleScore;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label TitleNiveauLabel;
        private System.Windows.Forms.Button AbandonButton;
        private System.Windows.Forms.Timer TimerQuestion;
        private System.Windows.Forms.Label TempsRestantLabel;
        private System.Windows.Forms.Label TitleTempsRestantLabel;
        private System.Windows.Forms.Timer SuspensTimer;
        private System.Windows.Forms.Label DifficultyLabel;
        private System.Windows.Forms.Label TitleDifficultyLabel;
        private System.Windows.Forms.Panel ScreamerPanel;
        private System.Windows.Forms.Timer ScreamerTimer;
    }
}