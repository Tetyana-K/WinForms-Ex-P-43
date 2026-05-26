namespace Timer_demo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            btnStart = new Button();
            btnStop = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btnClose = new Button();
            btnStartMoving = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            timerMoving = new System.Windows.Forms.Timer(components);
            timerNew = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.PaleTurquoise;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(297, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 166);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(29, 24);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(154, 34);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start  SlideShow";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(29, 86);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(154, 34);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop SlideShow";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(29, 215);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(154, 34);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close Form";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnStartMoving
            // 
            btnStartMoving.Location = new Point(29, 156);
            btnStartMoving.Name = "btnStartMoving";
            btnStartMoving.Size = new Size(154, 34);
            btnStartMoving.TabIndex = 4;
            btnStartMoving.Text = "Start Moving";
            btnStartMoving.UseVisualStyleBackColor = true;
            btnStartMoving.Click += btnStartMoving_Click;
            // 
            // timerMoving
            // 
            timerMoving.Interval = 500;
            timerMoving.Tick += timerMoving_Tick;
            // 
            // timerNew
            // 
            timerNew.Enabled = true;
            timerNew.Interval = 500;
            timerNew.Tick += timerNew_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 502);
            Controls.Add(btnStartMoving);
            Controls.Add(btnClose);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnStart;
        private Button btnStop;
        private System.Windows.Forms.Timer timer1;
        private Button btnClose;
        private Button btnStartMoving;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timerMoving;
        private System.Windows.Forms.Timer timerNew;
    }
}
