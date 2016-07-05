using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alba
{
    public partial class outside1 : Form
    {

        bool right;
        bool left;
        bool up;
        bool down;

        public outside1()
        {
            InitializeComponent();
        }

        private void outside1_Load(object sender, EventArgs e)
        {
            lblEvent.Text = "That tree looks a bit sinister...";
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Location = Owner.Location;
            this.Size = Owner.Size;
        }

        private void outside1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                right = false;
            }

            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                left = false;
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                up = false;
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                down = false;
            }
        }

        private void outside1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                right = true;
            }

            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                left = true;
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                up = true;
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                down = true;
            }

            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }

            if (e.KeyCode == Keys.Q)
            {
                A1Clicked();
            }

            if (e.KeyCode == Keys.E)
            {
                A2Clicked();
            }
        }

              private void lblA1_Click(object sender, EventArgs e)
        {
            A1Clicked();
        }

        private void lblA2_Click(object sender, EventArgs e)
        {
            A2Clicked();
        }

        private void A1Clicked()
        {
            if (lblEvent.Text == "you wanna go outside?")
            {
                Form outside = new outside1();
                this.Hide();
                outside.Show(this);
            }

          
        }

        private void A2Clicked()
        {

            if (lblEvent.Text == "you wanna go outside?")
            {
                lblEvent.Text = "...";
                lblA1.Text = "...";
                lblA2.Text = "...";
            }

        }

        private void Movement_Tick(object sender, EventArgs e)
        {

            //COLLISONS

            //WALLS

            //RIGHT

            if (player.Right > wallRight.Left && player.Left < wallRight.Right - player.Width / 2 && player.Bottom > wallRight.Top)
            {
                right = false;
            }


            //LEFT

            if (player.Left < wallLeft.Right && player.Right > wallLeft.Left + player.Width / 2 && player.Bottom > wallLeft.Top)
            {
                left = false;
            }


            //TOP
            if (player.Top <= wallTop.Bottom && player.Left + player.Width - 1 > wallTop.Left && player.Left + player.Width + 5 < wallTop.Left + wallTop.Width + player.Width && player.Top > wallTop.Top)
            {

                up = false;

            }

            //BOTTOM
            if (player.Left + player.Width - 1 > wallBottom.Left && player.Left + player.Width + 5 < wallBottom.Left + wallBottom.Width + player.Width && player.Top + player.Height >= wallBottom.Top && player.Top < wallBottom.Top)
            {
                down = false;
            }

            //BLOCKS

            if (right == true)
            {
                player.Left += 3;
            }

            if (left == true)
            {
                player.Left -= 3;
            }

            if (up == true)
            {
                player.Top -= 3;
            }

            if (down == true)
            {
                player.Top += 3;
            }


            //mcloset();
        }
    }
}
