using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UEVENTS_UI.Resources
{
    public partial class Lobby : Form
    {
        public Lobby()
        {
            InitializeComponent();
            panelAccount.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxAccount_Click(object sender, EventArgs e)
        {
            panelAccount.Visible = !panelAccount.Visible;
        }

        private void buttonAccountPanelLogOut_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();
            login.Show();

            this.Hide();
        }
    }
}
