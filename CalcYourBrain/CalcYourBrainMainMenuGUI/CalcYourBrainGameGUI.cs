using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CalcYourBrainMainMenuGUI
{
    public partial class CalcYourBrainGameGUI : Form
    {
        Level niveau;
        int Score = 0;
        int penaldiff = 0;
        int tempsrestant = 10;
        private System.IO.Stream str = Properties.Resources.ScreamerSong;

        public CalcYourBrainGameGUI()
        {
            InitializeComponent();
        }

        public CalcYourBrainGameGUI(String difficulty)
        {
            InitializeComponent();

            RollBackground();

            Random rand = new Random();
            SuspensTimer.Interval = rand.Next(60, 300) * 1000;
            //SuspensTimer.Interval = 1000;
            SuspensTimer.Start();

            DifficultyLabel.Text = difficulty;

            if (difficulty == "Facile")
            {
                niveau = new Level();
                niveau.GenerateCalc();
                CalcLabel.Text = niveau.Calc;
                LevelLabel.Text = niveau.Num.ToString();

            }
            else if (difficulty == "Moyen")
            {
                niveau = new Level();
                niveau.Num = 30;
                niveau.GenerateCalc();
                CalcLabel.Text = niveau.Calc;
                penaldiff = 29;
                LevelLabel.Text = (niveau.Num - penaldiff).ToString();
                TimerQuestion.Start();
            }
            else
            {
                niveau = new Level();
                niveau.Num = 50;
                niveau.GenerateCalc();
                CalcLabel.Text = niveau.Calc;
                penaldiff = 49;
                LevelLabel.Text = (niveau.Num - penaldiff).ToString();
                TimerQuestion.Start();
            }
        }

        private void SoumettreButton_Click(object sender, EventArgs e)
        {
            TimerQuestion.Stop();
            try
            {
                if (niveau.ResolvCalc(Double.Parse(ResponseTB.Text)) == true)
                {
                    niveau.Num += 1;
                    Score += niveau.Score;
                    niveau.GenerateCalc();
                    CalcLabel.Text = niveau.Calc;
                    ResponseTB.Text = null;
                    ScoreLabel.Text = Score.ToString();
                    LevelLabel.Text = (niveau.Num - penaldiff).ToString();
                }
                else
                {
                    Score -= niveau.Score;
                    niveau.GenerateCalc();
                    CalcLabel.Text = niveau.Calc;
                    ResponseTB.Text = null;
                    ScoreLabel.Text = Score.ToString();


                    if (Score < 0)
                    {
                        MessageBox.Show("Vous avez perdu, votre score est inférieur à 0 et vous vous êtes arrêté au niveau " + (niveau.Num - penaldiff) + "!", "Résultats", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Close();
                    }
                }
            }
            catch (Exception)
            {
                Score -= niveau.Score;
                niveau.GenerateCalc();
                CalcLabel.Text = niveau.Calc;
                ResponseTB.Text = null;
                ScoreLabel.Text = Score.ToString();

                if (Score < 0)
                {
                    MessageBox.Show("Vous avez perdu, votre score est inférieur à 0 et vous vous êtes arrêté au niveau " + (niveau.Num - penaldiff) + "!", "Résultats", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
            }
            if (penaldiff != 0)
            {
                tempsrestant = 10;
                TimerQuestion.Start();
            }

            ResponseTB.Focus();
        }

        private void AbandonButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous avez abandonné, votre score est " + Score + " et vous vous êtes arrêté au niveau " + (niveau.Num - penaldiff) + "!", "Résultats", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private void TimerQuestion_Tick(object sender, EventArgs e)
        {
            tempsrestant -= 1;

            if (tempsrestant == 0)
            {
                TimerQuestion.Stop();

                MessageBox.Show("Temps écoulé, votre score est " + Score + " et vous vous êtes arrêté au niveau " + (niveau.Num - penaldiff) + "!", "Résultats", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            else
            {
                TempsRestantLabel.Text = tempsrestant.ToString();

                TimerQuestion.Start();
            }
        }

        private void RollBackground()
        {
            Random rand = new Random();

            switch (rand.Next(1, 6))
            {
                case 1:
                    ScreamerPanel.BackgroundImage = Properties.Resources.Horor1;
                    break;
                case 2:
                    ScreamerPanel.BackgroundImage = Properties.Resources.Horor2;
                    break;
                case 3:
                    ScreamerPanel.BackgroundImage = Properties.Resources.Horor3;
                    break;
                case 4:
                    ScreamerPanel.BackgroundImage = Properties.Resources.Horor4;
                    break;
                case 5:
                    ScreamerPanel.BackgroundImage = Properties.Resources.Horor5;
                    break;
            }
            ScreamerPanel.Enabled = true;
        }

        private void RollSound()
        {
            Random rand = new Random();

            switch (rand.Next(1, 3))
            {
                case 1:
                    str = Properties.Resources.ScreamerSong;
                    break;
                case 2:
                    str = Properties.Resources.JeffSound;
                    break;
            }
        }

        private void SuspensTimer_Tick(object sender, EventArgs e)
        {

            RollSound();

            SoundPlayer player = new SoundPlayer(str);

            player.Play();

            ScreamerPanel.Visible = true;

            ScreamerTimer.Start();
            
            SuspensTimer.Stop();
        }

        private void ScreamerTimer_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();

            ScreamerPanel.Visible = false;
            ScreamerTimer.Stop();

            RollBackground();
            SuspensTimer.Interval = rand.Next(60, 300) * 1000;

            SuspensTimer.Start();

            
        }
    }
}
