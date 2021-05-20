
namespace Flappy_bird
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxflappybird = new System.Windows.Forms.PictureBox();
            this.pictureBoxPipeTop = new System.Windows.Forms.PictureBox();
            this.pictureBoxPipeBottom = new System.Windows.Forms.PictureBox();
            this.pictureBoxGround = new System.Windows.Forms.PictureBox();
            this.timerGameTimer = new System.Windows.Forms.Timer(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            this.labelRestart = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelQuit = new System.Windows.Forms.Label();
            this.pictureBoxBackGround = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxflappybird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxflappybird
            // 
            this.pictureBoxflappybird.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxflappybird.Image")));
            this.pictureBoxflappybird.Location = new System.Drawing.Point(23, 320);
            this.pictureBoxflappybird.Name = "pictureBoxflappybird";
            this.pictureBoxflappybird.Size = new System.Drawing.Size(70, 57);
            this.pictureBoxflappybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxflappybird.TabIndex = 0;
            this.pictureBoxflappybird.TabStop = false;
            // 
            // pictureBoxPipeTop
            // 
            this.pictureBoxPipeTop.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPipeTop.Image")));
            this.pictureBoxPipeTop.Location = new System.Drawing.Point(401, 2);
            this.pictureBoxPipeTop.Name = "pictureBoxPipeTop";
            this.pictureBoxPipeTop.Size = new System.Drawing.Size(116, 219);
            this.pictureBoxPipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPipeTop.TabIndex = 0;
            this.pictureBoxPipeTop.TabStop = false;
            // 
            // pictureBoxPipeBottom
            // 
            this.pictureBoxPipeBottom.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPipeBottom.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPipeBottom.Image")));
            this.pictureBoxPipeBottom.Location = new System.Drawing.Point(331, 397);
            this.pictureBoxPipeBottom.Name = "pictureBoxPipeBottom";
            this.pictureBoxPipeBottom.Size = new System.Drawing.Size(116, 220);
            this.pictureBoxPipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPipeBottom.TabIndex = 0;
            this.pictureBoxPipeBottom.TabStop = false;
            // 
            // pictureBoxGround
            // 
            this.pictureBoxGround.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGround.Image")));
            this.pictureBoxGround.Location = new System.Drawing.Point(-3, 606);
            this.pictureBoxGround.Name = "pictureBoxGround";
            this.pictureBoxGround.Size = new System.Drawing.Size(551, 135);
            this.pictureBoxGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGround.TabIndex = 0;
            this.pictureBoxGround.TabStop = false;
            this.pictureBoxGround.Click += new System.EventHandler(this.pictureBoxGround_Click);
            // 
            // timerGameTimer
            // 
            this.timerGameTimer.Enabled = true;
            this.timerGameTimer.Interval = 20;
            this.timerGameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.labelScore.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelScore.Location = new System.Drawing.Point(12, 641);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(144, 42);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Score: 0";
            // 
            // labelRestart
            // 
            this.labelRestart.AutoSize = true;
            this.labelRestart.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRestart.Location = new System.Drawing.Point(204, 292);
            this.labelRestart.Name = "labelRestart";
            this.labelRestart.Size = new System.Drawing.Size(122, 37);
            this.labelRestart.TabIndex = 2;
            this.labelRestart.Text = "Restart";
            this.labelRestart.Click += new System.EventHandler(this.labelRestart_Click);
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.BackColor = System.Drawing.Color.Transparent;
            this.labelStart.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStart.Location = new System.Drawing.Point(204, 244);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(88, 37);
            this.labelStart.TabIndex = 3;
            this.labelStart.Text = "Start";
            this.labelStart.Click += new System.EventHandler(this.labelStar_Click);
            // 
            // labelQuit
            // 
            this.labelQuit.AutoSize = true;
            this.labelQuit.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelQuit.Location = new System.Drawing.Point(204, 340);
            this.labelQuit.Name = "labelQuit";
            this.labelQuit.Size = new System.Drawing.Size(80, 37);
            this.labelQuit.TabIndex = 4;
            this.labelQuit.Text = "Quit";
            this.labelQuit.Click += new System.EventHandler(this.labelQuit_Click);
            // 
            // pictureBoxBackGround
            // 
            this.pictureBoxBackGround.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackGround.Image")));
            this.pictureBoxBackGround.Location = new System.Drawing.Point(-3, -5);
            this.pictureBoxBackGround.Name = "pictureBoxBackGround";
            this.pictureBoxBackGround.Size = new System.Drawing.Size(534, 615);
            this.pictureBoxBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackGround.TabIndex = 5;
            this.pictureBoxBackGround.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(527, 692);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelQuit);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.labelRestart);
            this.Controls.Add(this.pictureBoxflappybird);
            this.Controls.Add(this.pictureBoxGround);
            this.Controls.Add(this.pictureBoxPipeBottom);
            this.Controls.Add(this.pictureBoxPipeTop);
            this.Controls.Add(this.pictureBoxBackGround);
            this.Name = "Form1";
            this.Text = "Flappy bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxflappybird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBoxflappybird;
        public System.Windows.Forms.PictureBox pictureBoxPipeTop;
        public System.Windows.Forms.PictureBox pictureBoxPipeBottom;
        public System.Windows.Forms.PictureBox pictureBoxGround;
        private System.Windows.Forms.Timer timerGameTimer;
        public System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelRestart;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelQuit;
        public System.Windows.Forms.PictureBox pictureBoxBackGround;
    }
}

