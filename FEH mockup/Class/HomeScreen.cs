using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework;

namespace FEH_mockup.Class
{
    public partial class HomeScreen : MetroForm
    {
        public HomeScreen()
        {
            InitializeComponent();
            this.StyleManager = msmHome;

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
            msmHome.Style = (MetroColorStyle)((MetroTile)sender).Tag;
        }

        

        void _login_SettingsClosed(object sender, EventArgs e)
        {
            lnkSettings.Visible = true;
        }

        private void lnkSettings_Click(object sender, EventArgs e)
        {
            pnlSettings.Visible = true;
            flpoSettings.BringToFront();
            lnkSettings.Visible = false;

        }

        private void lnkBack_Click(object sender, EventArgs e)
        {
            pnlSettings.Visible = false;
            lnkSettings.Visible = true;
        }

        private void mrbDark_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbDark.Checked)
            {
                msmHome.Theme = MetroThemeStyle.Dark;
                label1.ForeColor = Color.FromArgb(255, 255, 255); 
            }
        }

        private void mrbLight_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbLight.Checked)
            {
                msmHome.Theme = MetroThemeStyle.Light;
                label1.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        
    }
}
