using FEH_mockup.Class;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FEH_mockup
{
    public partial class MainForm : MetroForm
    {
        

        public MainForm()
        {
            InitializeComponent();
            this.StyleManager = msmMain;

            for (int i = 3; i < 13; i++)
            {
                MetroTile _tile = new MetroTile();
                _tile.Size = new Size(30, 30);
                _tile.Tag = i;
                _tile.Style = (MetroColorStyle)i;
                _tile.Click += _tile_Click;
                flpoSettings.Controls.Add(_tile);
            }

        }

        void _tile_Click(object sender, EventArgs e)
        {
               msmMain.Style = (MetroColorStyle)((MetroTile)sender).Tag;
        }

        private void mrbDark_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbDark.Checked)
            {
                this.StyleManager.Theme = MetroThemeStyle.Dark;
            }
        }

        private void mrbLight_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbLight.Checked)
            {
                this.StyleManager.Theme = MetroThemeStyle.Light;
            }
        }

        void _login_SettingsClosed(object sender, EventArgs e)
        {
            lnkSettings.Visible = true;
        }

        private void lnkSettings_Click(object sender, EventArgs e)
        {
            lnkSettings.Visible = false;
            pnlSettings.Visible = true;     
        }

        private void lnkBack_Click(object sender, EventArgs e)
        {
            pnlSettings.Visible = false;
            lnkSettings.Visible = true;
        }

        

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            var HomeScreen = new HomeScreen();
            HomeScreen.Show();
        }
    }
}
