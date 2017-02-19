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
    public partial class AddPatient : MetroForm
    {
        public AddPatient()
        {
            InitializeComponent();

            metroGrid1.ColumnCount = 2;
            metroGrid1.Columns[0].Name = "Document Name";
            metroGrid1.Columns[1].Name = "Date Uploaded";

            string[] row = new string[] { "ID Book", "12 December 2016, 3:30 PM"};
            metroGrid1.Rows.Add(row);

            row = new string[] { "Birth Certificate", "22 January 2017, 12:30 PM" };
            metroGrid1.Rows.Add(row);

            row = new string[] { "Matric", "23 January 2017, 12:30 PM" };
            metroGrid1.Rows.Add(row);

            row = new string[] { "Proof of Residence", "29 January 2017, 12:30 PM" };
            metroGrid1.Rows.Add(row);

            row = new string[] { "Salary Slip", "22 January 2017, 12:30 PM" };
            metroGrid1.Rows.Add(row);

            row = new string[] { "", "" };
            metroGrid1.Rows.Add(row);

            row = new string[] { "", "" };
            metroGrid1.Rows.Add(row);

            row = new string[] { "", "" };
            metroGrid1.Rows.Add(row);

            row = new string[] { "", "" };
            metroGrid1.Rows.Add(row);

            row = new string[] { "", "" };
            metroGrid1.Rows.Add(row);

            row = new string[] { "", "" };
            metroGrid1.Rows.Add(row);

            this.StyleManager = msmAddPatient;

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
            msmAddPatient.Style = (MetroColorStyle)((MetroTile)sender).Tag;
        }

       

        void _login_SettingsClosed(object sender, EventArgs e)
        {
            lnkSettings.Visible = true;
        }

        private void lnkBack_Click(object sender, EventArgs e)
        {
            pnlSettings.Visible = false;
        }



        private void btnLogIn_Click(object sender, EventArgs e)
        {
            var HomeScreen = new HomeScreen();
            HomeScreen.Show();
        }

        private void lnkSettings_Click(object sender, EventArgs e)
        {
            pnlSettings.Visible = true;
        }

        private void lnkBack_Click_1(object sender, EventArgs e)
        {
            pnlSettings.Visible = false;
        }

        private void mrbDark_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbDark.Checked)
            {
                msmAddPatient.Theme = MetroThemeStyle.Dark;
                label1.ForeColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void mrbLight_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbLight.Checked)
            {
                msmAddPatient.Theme = MetroThemeStyle.Light;
                label1.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }
    }
}
