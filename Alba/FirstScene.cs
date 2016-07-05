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
    public partial class FirstScene : Form
    {
        bool right;
        bool left;
        bool up;
        bool down;
      

        public FirstScene()
        {
           
            InitializeComponent();
        }

        private void FirstScene_Load(object sender, EventArgs e)
        {
            mirror.Visible = false;
        }

        private void Movement_Tick(object sender, EventArgs e)
        {

            //COLLISONS

            //WALLS

            //RIGHT

            if (player.Right > wallRight.Left && player.Left < wallRight.Right -player.Width / 2 && player.Bottom > wallRight.Top)
            {
                right = false ;
            }


            //LEFT

            if (player.Left < wallLeft.Right && player.Right > wallLeft.Left + player.Width /2 && player.Bottom > wallLeft.Top)
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

            if ( down == true)
            {
                player.Top += 3;
            }


            //mcloset();

            mDoor();
        }

        private void FirstScene_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                right = true;
            }
            
            if ( e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
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


        private void stopmovement()
        {
            left = false;
            right = false;
            up = false;
            down = false;
        }

        private void FirstScene_KeyUp(object sender, KeyEventArgs e)
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

        private void lblA1_Click(object sender, EventArgs e)
        {
            A1Clicked();
        }

        private void lblA2_Click(object sender, EventArgs e)
        {
            A2Clicked();
        }

        private void mcloset()
        {
            if (player.Bounds.IntersectsWith(closet.Bounds))
            {
                lblEvent.Text = "Q: Check Mirror. E: Change Clothes";
                lblA1.Text = "Q";
                lblA2.Text = "E";
            }
            else
            {
                mirror.Visible = false;
                lblEvent.Text = "...";
                lblA1.Text = "...";
                lblA2.Text = "...";
            }
        }

        private void mDoor()
        {

            if (player.Bounds.IntersectsWith(door.Bounds))
            {
                lblEvent.Text = "you wanna go outside?";
                lblA1.Text = "yes";
                lblA2.Text = "no";

            }
            else
            {
                lblEvent.Text = "...";
                lblA1.Text = "...";
                lblA2.Text = "...";
            }
        }

        private void A1Clicked()
        {
            if(lblEvent.Text == "you wanna go outside?")
            {
                Form outside = new outside1();
                this.Hide();
                outside.Show(this);
            }

            if (lblEvent.Text == "Q: Check Mirror. E: Change Clothes")
            {
                lblEvent.Text = "jezus christ! ur hard to look at";
                mirror.Visible = true;
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
    }
}
