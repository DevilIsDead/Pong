using System.Drawing;

namespace Pong
{
    partial class Form1
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
            this.p1score = new System.Windows.Forms.Label();
            this.p2score = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grass = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.P1 = new System.Windows.Forms.PictureBox();
            this.P2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // p1score
            // 
            this.p1score.BackColor = System.Drawing.Color.Transparent;
            this.p1score.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p1score.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.p1score.Location = new System.Drawing.Point(530, 723);
            this.p1score.Name = "p1score";
            this.p1score.Size = new System.Drawing.Size(110, 65);
            this.p1score.TabIndex = 4;
            this.p1score.Text = "0";
            this.p1score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2score
            // 
            this.p2score.BackColor = System.Drawing.Color.Transparent;
            this.p2score.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p2score.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.p2score.Location = new System.Drawing.Point(640, 723);
            this.p2score.Name = "p2score";
            this.p2score.Size = new System.Drawing.Size(110, 65);
            this.p2score.TabIndex = 5;
            this.p2score.Text = "0";
            this.p2score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.gameTimer);
            // 
            // grass
            // 
            this.grass.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grass.Location = new System.Drawing.Point(-13, 723);
            this.grass.Name = "grass";
            this.grass.Size = new System.Drawing.Size(1303, 133);
            this.grass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grass.TabIndex = 7;
            this.grass.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Gold;
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ball.Location = new System.Drawing.Point(860, 334);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(25, 25);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 6;
            this.ball.TabStop = false;
            // 
            // P1
            // 
            this.P1.BackColor = System.Drawing.Color.Red;
            this.P1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.P1.Location = new System.Drawing.Point(30, 300);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(10, 160);
            this.P1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P1.TabIndex = 2;
            this.P1.TabStop = false;
            // 
            // P2
            // 
            this.P2.BackColor = System.Drawing.Color.DodgerBlue;
            this.P2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.P2.Location = new System.Drawing.Point(1240, 300);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(10, 160);
            this.P2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P2.TabIndex = 1;
            this.P2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1280, 720);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 795);
            this.Controls.Add(this.p2score);
            this.Controls.Add(this.p1score);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grass);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.grass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox P2;
        private System.Windows.Forms.PictureBox P1;
        private System.Windows.Forms.Label p1score;
        private System.Windows.Forms.Label p2score;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox grass;
    }
}

