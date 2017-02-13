using FEH_mockup.Class;
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
        pnlLogin _login = null;

        public MainForm()
        {
            InitializeComponent();
            this.StyleManager = msmMain;
            this.Shown += MainForm_Shown;

            _login = new pnlLogin(this);
            _login.SettingsClosed += _login_SettingsClosed;
            _login.swipe();
        }

        void _login_SettingsClosed(object sender, EventArgs e)
        {
            lnkSettings.Visible = true;
        }

        void MainForm_Shown(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }

        private void lnkSettings_Click(object sender, EventArgs e)
        {
            lnkSettings.Visible = false;
            _login.ShowSettings();
            
        }
    }
}
