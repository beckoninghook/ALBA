namespace Alba
{
    partial class FirstScene
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
            this.screen = new System.Windows.Forms.Panel();
            this.wallRight = new System.Windows.Forms.PictureBox();
            this.wallLeft = new System.Windows.Forms.PictureBox();
            this.Movement = new System.Windows.Forms.Timer(this.components);
            this.wallTop = new System.Windows.Forms.PictureBox();
            this.wallBottom = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wallRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Image = global::Alba.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(123, 98);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(16, 32);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.Transparent;
            this.screen.Controls.Add(this.pictureBox1);
            this.screen.Controls.Add(this.wallBottom);
            this.screen.Controls.Add(this.wallTop);
            this.screen.Controls.Add(this.player);
            this.screen.Controls.Add(this.wallRight);
            this.screen.Controls.Add(this.wallLeft);
            this.screen.Location = new System.Drawing.Point(-14, -5);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(285, 211);
            this.screen.TabIndex = 1;
            // 
            // wallRight
            // 
            this.wallRight.Location = new System.Drawing.Point(243, 14);
            this.wallRight.Name = "wallRight";
            this.wallRight.Size = new System.Drawing.Size(18, 218);
            this.wallRight.TabIndex = 1;
            this.wallRight.TabStop = false;
            // 
            // wallLeft
            // 
            this.wallLeft.Location = new System.Drawing.Point(3, 3);
            this.wallLeft.Name = "wallLeft";
            this.wallLeft.Size = new System.Drawing.Size(18, 211);
            this.wallLeft.TabIndex = 2;
            this.wallLeft.TabStop = false;
            // 
            // Movement
            // 
            this.Movement.Enabled = true;
            this.Movement.Interval = 1;
            this.Movement.Tick += new System.EventHandler(this.Movement_Tick);
            // 
            // wallTop
            // 
            this.wallTop.Location = new System.Drawing.Point(3, -21);
            this.wallTop.Name = "wallTop";
            this.wallTop.Size = new System.Drawing.Size(255, 37);
            this.wallTop.TabIndex = 3;
            this.wallTop.TabStop = false;
            // 
            // wallBottom
            // 
            this.wallBottom.Location = new System.Drawing.Point(3, 211);
            this.wallBottom.Name = "wallBottom";
            this.wallBottom.Size = new System.Drawing.Size(255, 3);
            this.wallBottom.TabIndex = 4;
            this.wallBottom.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 37);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FirstScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Alba.Properties.Resources.HOUSE;
            this.ClientSize = new System.Drawing.Size(240, 240);
            this.Controls.Add(this.screen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FirstScene";
            this.Text = "FirstScene";
            this.Load += new System.EventHandler(this.FirstScene_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FirstScene_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FirstScene_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.screen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wallRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.Timer Movement;
        private System.Windows.Forms.PictureBox wallRight;
        private System.Windows.Forms.PictureBox wallLeft;
        private System.Windows.Forms.PictureBox wallTop;
        private System.Windows.Forms.PictureBox wallBottom;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}