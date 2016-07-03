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
    public partial class Form1 : Form
    {
        int i;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
   
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



        private void btnStart_Click(object sender, EventArgs e)
        {
            Form hb = new FirstScene();
            this.Hide();
            hb.Show(this);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Location = Owner.Location;
            this.Size = Owner.Size;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void twitch_Tick(object sender, EventArgs e)
        {
           
            i++;
            if (i == 1)
            {
                this.BackgroundImage = Properties.Resources.StartSreentwitch;

            }
            else
            {
                this.BackgroundImage = Properties.Resources.startscreenface;
            }

            if (i == 2)
            {
                i = 0;

            }
        }

        public void triphard()
        {
            twitch.Start();

         
        }


        private void btnStart_MouseHover(object sender, EventArgs e)
        {
            triphard();
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            twitch.Stop();
            this.BackgroundImage = Properties.Resources.startscreenface;
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            triphard();
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            twitch.Stop();
            this.BackgroundImage = Properties.Resources.startscreenface;
        }
    }
}
