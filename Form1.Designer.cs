namespace snake_game
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
            this.txtScore = new System.Windows.Forms.Label();
            this.txtHighScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.Label();
            this.btnSnap = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnExit2 = new System.Windows.Forms.Button();
            this.btnDescription = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbxSnake = new System.Windows.Forms.PictureBox();
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.pnlGame.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSnake)).BeginInit();
            this.pnlDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtScore.ForeColor = System.Drawing.Color.Black;
            this.txtScore.Location = new System.Drawing.Point(610, 346);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 25);
            this.txtScore.TabIndex = 3;
            this.txtScore.Text = "Score: 0";
            // 
            // txtHighScore
            // 
            this.txtHighScore.AutoSize = true;
            this.txtHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHighScore.Location = new System.Drawing.Point(611, 383);
            this.txtHighScore.Name = "txtHighScore";
            this.txtHighScore.Size = new System.Drawing.Size(115, 24);
            this.txtHighScore.TabIndex = 4;
            this.txtHighScore.Text = "High Score";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 60;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.btnRestart);
            this.pnlInfo.Controls.Add(this.btnContinue);
            this.pnlInfo.Controls.Add(this.txtTitle);
            this.pnlInfo.Location = new System.Drawing.Point(189, 150);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(262, 168);
            this.pnlInfo.TabIndex = 6;
            this.pnlInfo.Visible = false;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Turquoise;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRestart.Location = new System.Drawing.Point(62, 73);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(116, 32);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.clickRestart);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.Lime;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnContinue.Location = new System.Drawing.Point(62, 111);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(116, 32);
            this.btnContinue.TabIndex = 1;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.clickContinue);
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTitle.Location = new System.Drawing.Point(58, 24);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(59, 20);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "Pause";
            this.txtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSnap
            // 
            this.btnSnap.BackColor = System.Drawing.Color.Turquoise;
            this.btnSnap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSnap.Location = new System.Drawing.Point(609, 123);
            this.btnSnap.Name = "btnSnap";
            this.btnSnap.Size = new System.Drawing.Size(111, 55);
            this.btnSnap.TabIndex = 1;
            this.btnSnap.Text = "Snap";
            this.btnSnap.UseVisualStyleBackColor = false;
            this.btnSnap.Click += new System.EventHandler(this.clickSnap);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(609, 62);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 55);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.clickStart);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.Tan;
            this.picCanvas.Location = new System.Drawing.Point(9, 10);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(580, 680);
            this.picCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCanvas.TabIndex = 2;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphics);
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlGame.Controls.Add(this.pnlMenu);
            this.pnlGame.Controls.Add(this.btnMenu);
            this.pnlGame.Controls.Add(this.btnExit);
            this.pnlGame.Controls.Add(this.cmbLevel);
            this.pnlGame.Controls.Add(this.pnlInfo);
            this.pnlGame.Controls.Add(this.picCanvas);
            this.pnlGame.Controls.Add(this.txtHighScore);
            this.pnlGame.Controls.Add(this.txtScore);
            this.pnlGame.Controls.Add(this.btnSnap);
            this.pnlGame.Controls.Add(this.btnStart);
            this.pnlGame.Location = new System.Drawing.Point(3, 2);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(741, 720);
            this.pnlGame.TabIndex = 7;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.RosyBrown;
            this.pnlMenu.Controls.Add(this.btnExit2);
            this.pnlMenu.Controls.Add(this.btnDescription);
            this.pnlMenu.Controls.Add(this.btnPlay);
            this.pnlMenu.Controls.Add(this.lblTitle);
            this.pnlMenu.Controls.Add(this.pbxSnake);
            this.pnlMenu.Controls.Add(this.pnlDescription);
            this.pnlMenu.Location = new System.Drawing.Point(9, 10);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(717, 680);
            this.pnlMenu.TabIndex = 10;
            // 
            // btnExit2
            // 
            this.btnExit2.BackColor = System.Drawing.Color.Crimson;
            this.btnExit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit2.Location = new System.Drawing.Point(458, 536);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(130, 55);
            this.btnExit2.TabIndex = 4;
            this.btnExit2.Text = "Exit";
            this.btnExit2.UseVisualStyleBackColor = false;
            this.btnExit2.Click += new System.EventHandler(this.ClickExit);
            // 
            // btnDescription
            // 
            this.btnDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDescription.Location = new System.Drawing.Point(260, 536);
            this.btnDescription.Name = "btnDescription";
            this.btnDescription.Size = new System.Drawing.Size(130, 55);
            this.btnDescription.TabIndex = 3;
            this.btnDescription.Text = "Description";
            this.btnDescription.UseVisualStyleBackColor = false;
            this.btnDescription.Click += new System.EventHandler(this.clickDescription);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPlay.Location = new System.Drawing.Point(58, 536);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(130, 55);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.clickPlay);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Thistle;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(96, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(351, 55);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "SNAKE GAME";
            // 
            // pbxSnake
            // 
            this.pbxSnake.Image = global::snake_game.Properties.Resources.snake1;
            this.pbxSnake.Location = new System.Drawing.Point(30, 118);
            this.pbxSnake.Name = "pbxSnake";
            this.pbxSnake.Size = new System.Drawing.Size(625, 359);
            this.pbxSnake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSnake.TabIndex = 0;
            this.pbxSnake.TabStop = false;
            // 
            // pnlDescription
            // 
            this.pnlDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlDescription.Controls.Add(this.lblDescription);
            this.pnlDescription.Controls.Add(this.btnClose);
            this.pnlDescription.Location = new System.Drawing.Point(126, 168);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(377, 240);
            this.pnlDescription.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDescription.Location = new System.Drawing.Point(60, 42);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(44, 16);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "label1";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.Location = new System.Drawing.Point(209, 179);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.clickClose);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Goldenrod;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenu.Location = new System.Drawing.Point(609, 184);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(111, 55);
            this.btnMenu.TabIndex = 9;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.clickMenu);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.Location = new System.Drawing.Point(609, 245);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 55);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.clickExit);
            // 
            // cmbLevel
            // 
            this.cmbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Items.AddRange(new object[] {
            "Kolay",
            "Orta",
            "Zor"});
            this.cmbLevel.Location = new System.Drawing.Point(605, 457);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(121, 28);
            this.cmbLevel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 725);
            this.Controls.Add(this.pnlGame);
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.Load += new System.EventHandler(this.SnakeGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.pnlGame.ResumeLayout(false);
            this.pnlGame.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSnake)).EndInit();
            this.pnlDescription.ResumeLayout(false);
            this.pnlDescription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtHighScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnSnap;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnDescription;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbxSnake;
        private System.Windows.Forms.Button btnExit2;
        private System.Windows.Forms.Panel pnlDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnClose;
    }
}

