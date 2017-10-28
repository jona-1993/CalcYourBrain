using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcYourBrainMainMenuGUI
{
    public partial class CalcYourBrainMainMenuGUI : Form
    {
        public CalcYourBrainMainMenuGUI()
        {
            InitializeComponent();
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

            switch (DifficultyCB.Text)
            {
                case "Facile": new CalcYourBrainGameGUI("Facile").Visible = true;
                    break;
                case "Moyen": new CalcYourBrainGameGUI("Moyen").Visible = true;
                    break;
                case "Difficile": new CalcYourBrainGameGUI("Difficile").Visible = true;
                    break;
            }
        }

        private void CreditsButton_Click(object sender, EventArgs e)
        {
            new AboutForm().Visible = true;
        }
    }
}
