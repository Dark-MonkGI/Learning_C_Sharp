namespace GuessTheMelodyNET_Framework
{
    partial class fGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGame));
            this.btnNext = new System.Windows.Forms.Button();
            this.wmplayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.lbPlayerTwo = new System.Windows.Forms.Label();
            this.lbPointsTwo = new System.Windows.Forms.Label();
            this.lbPlayerOne = new System.Windows.Forms.Label();
            this.lbPointsOne = new System.Windows.Forms.Label();
            this.lblCountTrack = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMusicDuration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wmplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(302, 193);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(186, 85);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // wmplayer
            // 
            this.wmplayer.Enabled = true;
            this.wmplayer.Location = new System.Drawing.Point(-170, 414);
            this.wmplayer.Name = "wmplayer";
            this.wmplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmplayer.OcxState")));
            this.wmplayer.Size = new System.Drawing.Size(212, 36);
            this.wmplayer.TabIndex = 0;
            this.wmplayer.Visible = false;
            this.wmplayer.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.wmplayer_OpenStateChange);
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnContinue.Location = new System.Drawing.Point(631, 368);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(133, 53);
            this.btnContinue.TabIndex = 2;
            this.btnContinue.Text = "Continue eee";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPause.Location = new System.Drawing.Point(25, 368);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(133, 53);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lbPlayerTwo
            // 
            this.lbPlayerTwo.AutoSize = true;
            this.lbPlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPlayerTwo.Location = new System.Drawing.Point(599, 30);
            this.lbPlayerTwo.Name = "lbPlayerTwo";
            this.lbPlayerTwo.Size = new System.Drawing.Size(165, 32);
            this.lbPlayerTwo.TabIndex = 4;
            this.lbPlayerTwo.Text = "Player Two";
            // 
            // lbPointsTwo
            // 
            this.lbPointsTwo.AutoSize = true;
            this.lbPointsTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPointsTwo.Location = new System.Drawing.Point(671, 99);
            this.lbPointsTwo.Name = "lbPointsTwo";
            this.lbPointsTwo.Size = new System.Drawing.Size(31, 32);
            this.lbPointsTwo.TabIndex = 5;
            this.lbPointsTwo.Text = "0";
            // 
            // lbPlayerOne
            // 
            this.lbPlayerOne.AutoSize = true;
            this.lbPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPlayerOne.Location = new System.Drawing.Point(33, 30);
            this.lbPlayerOne.Name = "lbPlayerOne";
            this.lbPlayerOne.Size = new System.Drawing.Size(160, 32);
            this.lbPlayerOne.TabIndex = 6;
            this.lbPlayerOne.Text = "Player one";
            // 
            // lbPointsOne
            // 
            this.lbPointsOne.AutoSize = true;
            this.lbPointsOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPointsOne.Location = new System.Drawing.Point(95, 99);
            this.lbPointsOne.Name = "lbPointsOne";
            this.lbPointsOne.Size = new System.Drawing.Size(31, 32);
            this.lbPointsOne.TabIndex = 7;
            this.lbPointsOne.Text = "0";
            // 
            // lblCountTrack
            // 
            this.lblCountTrack.AutoSize = true;
            this.lblCountTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountTrack.Location = new System.Drawing.Point(464, 396);
            this.lblCountTrack.Name = "lblCountTrack";
            this.lblCountTrack.Size = new System.Drawing.Size(24, 25);
            this.lblCountTrack.TabIndex = 8;
            this.lblCountTrack.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(309, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Track Count:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(302, 305);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(186, 23);
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Value = 50;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMusicDuration
            // 
            this.lblMusicDuration.AutoSize = true;
            this.lblMusicDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMusicDuration.Location = new System.Drawing.Point(382, 335);
            this.lblMusicDuration.Name = "lblMusicDuration";
            this.lblMusicDuration.Size = new System.Drawing.Size(17, 18);
            this.lblMusicDuration.TabIndex = 11;
            this.lblMusicDuration.Text = "0";
            // 
            // fGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMusicDuration);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCountTrack);
            this.Controls.Add(this.lbPointsOne);
            this.Controls.Add(this.lbPlayerOne);
            this.Controls.Add(this.lbPointsTwo);
            this.Controls.Add(this.lbPlayerTwo);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.wmplayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "fGame";
            this.Text = "Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fGame_FormClosed);
            this.Load += new System.EventHandler(this.fGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.wmplayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmplayer;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lbPlayerTwo;
        private System.Windows.Forms.Label lbPointsTwo;
        private System.Windows.Forms.Label lbPlayerOne;
        private System.Windows.Forms.Label lbPointsOne;
        private System.Windows.Forms.Label lblCountTrack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMusicDuration;
    }
}