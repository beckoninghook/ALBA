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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Movement = new System.Windows.Forms.Timer(this.components);
            this.lblA2 = new System.Windows.Forms.Label();
            this.lblA1 = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Alba.Properties.Resources.player;
            this.pictureBox1.Location = new System.Drawing.Point(118, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 32);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Movement
            // 
            this.Movement.Enabled = true;
            this.Movement.Interval = 1;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 173);
            this.panel1.TabIndex = 8;
            // 
            // outside1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Alba.Properties.Resources.forest;
            this.ClientSize = new System.Drawing.Size(240, 240);
            this.Controls.Add(this.lblA2);
            this.Controls.Add(this.lblA1);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "outside1";
            this.Text = "outside1";
            this.Load += new System.EventHandler(this.outside1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer Movement;
        private System.Windows.Forms.Label lblA2;
        private System.Windows.Forms.Label lblA1;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Panel panel1;
    }
}