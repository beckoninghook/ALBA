namespace Alba
{
    partial class outside1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.player = new System.Windows.Forms.PictureBox();
            this.Movement = new System.Windows.Forms.Timer(this.components);
            this.lblA2 = new System.Windows.Forms.Label();
            this.lblA1 = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.screen = new System.Windows.Forms.Panel();
            this.wallTop = new System.Windows.Forms.PictureBox();
            this.wallBottom = new System.Windows.Forms.PictureBox();
            this.wallRight = new System.Windows.Forms.PictureBox();
            this.wallLeft = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wallTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Image = global::Alba.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(118, 124);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(16, 32);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // Movement
            // 
            this.Movement.Enabled = true;
            this.Movement.Interval = 1;
            this.Movement.Tick += new System.EventHandler(this.Movement_Tick);
            // 
            // lblA2
            // 
            this.lblA2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblA2.AutoSize = true;
            this.lblA2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblA2.ForeColor = System.Drawing.Color.White;
            this.lblA2.Location = new System.Drawing.Point(203, 218);
            this.lblA2.Name = "lblA2";
            this.lblA2.Size = new System.Drawing.Size(16, 13);
            this.lblA2.TabIndex = 7;
            this.lblA2.Text = "...";
            // 
            // lblA1
            // 
            this.lblA1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblA1.AutoSize = true;
            this.lblA1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblA1.ForeColor = System.Drawing.Color.White;
            this.lblA1.Location = new System.Drawing.Point(166, 218);
            this.lblA1.Name = "lblA1";
            this.lblA1.Size = new System.Drawing.Size(16, 13);
            this.lblA1.TabIndex = 6;
            this.lblA1.Text = "...";
            // 
            // lblEvent
            // 
            this.lblEvent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEvent.AutoSize = true;
            this.lblEvent.ForeColor = System.Drawing.Color.White;
            this.lblEvent.Location = new System.Drawing.Point(12, 218);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(16, 13);
            this.lblEvent.TabIndex = 5;
            this.lblEvent.Text = "...";
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.Transparent;
            this.screen.Controls.Add(this.wallRight);
            this.screen.Controls.Add(this.player);
            this.screen.Controls.Add(this.wallBottom);
            this.screen.Location = new System.Drawing.Point(-3, 35);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(248, 173);
            this.screen.TabIndex = 8;
            // 
            // wallTop
            // 
            this.wallTop.BackColor = System.Drawing.Color.Transparent;
            this.wallTop.Location = new System.Drawing.Point(-3, 12);
            this.wallTop.Name = "wallTop";
            this.wallTop.Size = new System.Drawing.Size(255, 37);
            this.wallTop.TabIndex = 4;
            this.wallTop.TabStop = false;
            // 
            // wallBottom
            // 
            this.wallBottom.Location = new System.Drawing.Point(-7, 168);
            this.wallBottom.Name = "wallBottom";
            this.wallBottom.Size = new System.Drawing.Size(255, 12);
            this.wallBottom.TabIndex = 9;
            this.wallBottom.TabStop = false;
            // 
            // wallRight
            // 
            this.wallRight.Location = new System.Drawing.Point(238, -40);
            this.wallRight.Name = "wallRight";
            this.wallRight.Size = new System.Drawing.Size(18, 218);
            this.wallRight.TabIndex = 10;
            this.wallRight.TabStop = false;
            // 
            // wallLeft
            // 
            this.wallLeft.Location = new System.Drawing.Point(-13, 0);
            this.wallLeft.Name = "wallLeft";
            this.wallLeft.Size = new System.Drawing.Size(18, 211);
            this.wallLeft.TabIndex = 11;
            this.wallLeft.TabStop = false;
            // 
            // outside1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Alba.Properties.Resources.forest;
            this.ClientSize = new System.Drawing.Size(240, 240);
            this.Controls.Add(this.wallLeft);
            this.Controls.Add(this.wallTop);
            this.Controls.Add(this.lblA2);
            this.Controls.Add(this.lblA1);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.screen);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "outside1";
            this.Text = "outside1";
            this.Load += new System.EventHandler(this.outside1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.outside1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.outside1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.screen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wallTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer Movement;
        private System.Windows.Forms.Label lblA2;
        private System.Windows.Forms.Label lblA1;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.PictureBox wallTop;
        private System.Windows.Forms.PictureBox wallBottom;
        private System.Windows.Forms.PictureBox wallRight;
        private System.Windows.Forms.PictureBox wallLeft;
    }
}