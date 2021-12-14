namespace FlappyBird2
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
            this.ScoreText = new System.Windows.Forms.Label();
            this.Flappybird = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pipeDown = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Flappybird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ScoreText.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ScoreText.Location = new System.Drawing.Point(2, 785);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(215, 56);
            this.ScoreText.TabIndex = 0;
            this.ScoreText.Text = "Score: 1";
            this.ScoreText.Click += new System.EventHandler(this.ScoreText_Click);
            // 
            // Flappybird
            // 
            this.Flappybird.Image = global::FlappyBird2.Properties.Resources.bird;
            this.Flappybird.Location = new System.Drawing.Point(157, 377);
            this.Flappybird.Name = "Flappybird";
            this.Flappybird.Size = new System.Drawing.Size(72, 54);
            this.Flappybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flappybird.TabIndex = 1;
            this.Flappybird.TabStop = false;
            this.Flappybird.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::FlappyBird2.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(443, 12);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(83, 289);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 2;
            this.pipeTop.TabStop = false;
            // 
            // pipeDown
            // 
            this.pipeDown.Image = global::FlappyBird2.Properties.Resources.pipe;
            this.pipeDown.Location = new System.Drawing.Point(443, 581);
            this.pipeDown.Name = "pipeDown";
            this.pipeDown.Size = new System.Drawing.Size(83, 266);
            this.pipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown.TabIndex = 3;
            this.pipeDown.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.Image = global::FlappyBird2.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(-4, 844);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(672, 50);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 4;
            this.Ground.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEventt);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(661, 895);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.Flappybird);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.pipeDown);
            this.Controls.Add(this.pipeTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameheyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Flappybird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.PictureBox Flappybird;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeDown;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Timer gameTimer;
    }
}

