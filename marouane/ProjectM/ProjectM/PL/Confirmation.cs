using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMarouane.PL
{
    public partial class Confirmation : Form
    {
        int move, moveX, moveY;
        public Confirmation()
        {
            InitializeComponent();
           
        }

        private void Confirmation_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }

        private void Confirmation_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        private void Confirmation_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }
    }
}
