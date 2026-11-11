using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UEVENTS_UI.Resources;

namespace UEVENTS_UI
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            Lobby lobby = new Lobby();
            lobby.Show();

            this.Hide();
        }
    }
}
