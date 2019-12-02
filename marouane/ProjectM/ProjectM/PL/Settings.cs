using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectM.PL
{
    public partial class Settings : Form
    {
        int move, MoveX, MoveY;

        private void Settings_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            MoveX = e.X;
            MoveY = e.Y;
        }

        private void Settings_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MoveX, MousePosition.Y - MoveY);
            }
        }

        private void Settings_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Label6_MouseHover(object sender, EventArgs e)
        {
            label6.BackColor = Color.FromArgb(80, Color.Gray);
        }

        private void Label6_MouseLeave(object sender, EventArgs e)
        {
            label6.BackColor = Color.Transparent;
        }

        public Settings()
        {
            InitializeComponent();
            rb_Win.Checked = true;
            txtPswd.Enabled = false;
            txtUser.Enabled = false;
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.server = txtServer.Text;
            Properties.Settings.Default.database = txtData.Text;
            MessageBox.Show("Vous avez configuré votre accés avec succées", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
