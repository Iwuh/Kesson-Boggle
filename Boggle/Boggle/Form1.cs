using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boggle
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void CustomSettingsEnabled(bool custom)
        {
            if (custom)
            {
                TimeSelector.Enabled = true;
                RowColumnSelector.Enabled = true;
                StartCustom.Enabled = true;
            }
            else if (!custom)
            {
                TimeSelector.Enabled = false;
                RowColumnSelector.Enabled = false;
                StartCustom.Enabled = false;
            }
        }

        private void Start4by4_Click(object sender, EventArgs e)
        {
            CustomSettingsEnabled(false);
            Application.Run(new Game(180, 4, Game.Modes.Standard));
        }

        private void Start5by5_Click(object sender, EventArgs e)
        {
            CustomSettingsEnabled(false);
            Application.Run(new Game(300, 5, Game.Modes.Standard));
        }

        private void StartWildCard_Click(object sender, EventArgs e)
        {
            CustomSettingsEnabled(false);
            Application.Run(new Game(180, 3, Game.Modes.Wildcard));
        }

        private void StartSpeedBoggle_Click(object sender, EventArgs e)
        {
            CustomSettingsEnabled(false);
            Application.Run(new Game(60, 3, Game.Modes.Standard));
        }

        private void Custom_Click(object sender, EventArgs e)
        {
            CustomSettingsEnabled(true);
        }

        private void StartCustom_Click(object sender, EventArgs e)
        {
            Application.Run(new Game((int)TimeSelector.Value, (int)RowColumnSelector.Value, Game.Modes.Custom));
        }
    }
}
