using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Imaging;  //add this for the JPG compressor

namespace snake_game
{
    public partial class Form1 : Form
    {

        private List<Circle> Snake = new List<Circle>();
        private Circle food= new Circle();

        int maxWidth;
        int maxHeight;

        int score;
        int highScore;

        Random rand= new Random();

        bool goLeft, goRight, goUp, goDown;


        public Form1()
        {
            InitializeComponent();

            new Settings();

        }

        private void SnakeGame_Load(object sender, EventArgs e)
        {
            cmbLevel.SelectedIndex = 1;
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left && Settings.directions != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Settings.directions != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings.directions != "up")
            {
                goDown = true;
            }

            if(e.KeyCode == Keys.P)
            { 
                showPanel(0);
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void clickStart(object sender, EventArgs e)
        {
            startGame();
        }

        private void clickSnap(object sender, EventArgs e)
        {
            Label caption=new Label();
            caption.Text = "I scored: " + score + " and my high score: " + highScore + " on the Snake Game";
            caption.Font = new Font("Ariel", 12, FontStyle.Bold);
            caption.ForeColor= Color.Purple;
            caption.AutoSize = false;
            caption.Width= picCanvas.Width;
            caption.Height = 30;
            caption.TextAlign= ContentAlignment.MiddleCenter;
            picCanvas.Controls.Add(caption);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "Snake Game SnapShot";
            dialog.DefaultExt = "jpg";
            dialog.Filter = "JPG Image File | *.jpg";
            dialog.ValidateNames = true;

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                int width= Convert.ToInt32(picCanvas.Width);
                int height= Convert.ToInt32(picCanvas.Height);
                Bitmap bmp= new Bitmap(width, height);
                picCanvas.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                bmp.Save(dialog.FileName, ImageFormat.Jpeg);
                picCanvas.Controls.Remove(caption);
                
            }

        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            //setting the directions

            if(goLeft)
            {
                Settings.directions = "left";
            }
            if (goRight)
            {
                Settings.directions = "right";
            }
            if (goUp)
            {
                Settings.directions = "up";
            }
            if (goDown)
            {
                Settings.directions = "down";
            }

            for(int i = Snake.Count-1; i >= 0; i--)
            {
                if(i==0)  
                {

                    switch(Settings.directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                        default:
                            break;
                    }

                    if(Snake[i].X<0)
                    {
                        Snake[i].X = maxWidth;
                    }
                    if(Snake[i].X > maxWidth)
                    {
                        Snake[i].X = 0;
                    }
                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = maxHeight;
                    }
                    if (Snake[i].Y > maxHeight)
                    {
                        Snake[i].Y = 0;
                    }


                    if(Snake[i].X == food.X && Snake[i].Y == food.Y)
                    {
                        eatFood();
                    }

                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if(Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            gameOver();
                        }
                    }

                }
                else  
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }

            picCanvas.Invalidate();
        }

        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            Brush snakeColour;

            for (int i = 0; i < Snake.Count; i++)
            {
                if (i == 0)
                {
                    snakeColour = Brushes.Black;
                }
                else
                {
                    snakeColour = Brushes.DarkGreen;
                }

                canvas.FillEllipse(snakeColour, new Rectangle
                    (
                    Snake[i].X * Settings.Width,
                    Snake[i].Y * Settings.Height,
                    Settings.Width, Settings.Height));
            }

            canvas.FillEllipse(Brushes.DarkRed, new Rectangle
                    (
                    food.X * Settings.Width,
                    food.Y * Settings.Height,
                    Settings.Width, Settings.Height));
        }

        private void startGame()
        {
            maxWidth = picCanvas.Width / Settings.Width - 1;
            maxHeight = picCanvas.Height / Settings.Height - 1;

            Snake.Clear();

            btnStart.Enabled = false;
            btnSnap.Enabled = false;
            cmbLevel.Enabled = false;
            btnExit.Enabled = false;
            btnMenu.Enabled = false;

            score = 0;
            txtScore.Text = "Score: " + score;

            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head);

            for (int i = 0; i < 10; i++)
            {
                Circle body = new Circle();
                Snake.Add(body);
            }

            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

            setGameSpeed();
            gameTimer.Start();

        }

        private void restartGame()
        {
            btnStart.Enabled= true;
            btnSnap.Enabled= true;
            cmbLevel.Enabled= true;
            btnExit.Enabled= true;
            btnMenu.Enabled= true;
        }

        private void eatFood()
        {
            score += 10;
            
            txtScore.Text = "Score: " + score;

            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y,
            };

            Snake.Add(body);

            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

            playEatSound();
        }

        private void clickPlay(object sender, EventArgs e)
        {
            pnlGame.Visible = true;
            pnlMenu.Visible = false;
            pnlInfo.Visible = false;
            restartGame();
            Snake.Clear();
        }

        private void clickMenu(object sender, EventArgs e)
        {
            pnlMenu.Visible= true;
            pnlInfo.Visible= false;
            pnlDescription.Visible = false;
        }

        private void clickRestart(object sender, EventArgs e)
        {
            pnlInfo.Visible= false;
            restartGame();
        }

        private void clickDescription(object sender, EventArgs e)
        {
            pnlMenu.Visible = true;
            pbxSnake.Visible = false;
            pnlDescription.Visible = true;

            lblDescription.Visible = true;
            lblDescription.Text = "Açıklama: \n\n" +
                "Kolay - Orta - Zor olmak üzere 3 aşama mevcut \n" +
                "P tuşu = oyun durdurma \n" +
                "Scan butonu = oyunun fotoğrafını çekme";
        }

        private void clickClose(object sender, EventArgs e)
        {
            pnlMenu.Visible = true;
            pbxSnake.Visible = true;
            pnlDescription.Visible = false;
            lblDescription.Visible = false;
        }

        private void clickContinue(object sender, EventArgs e)
        {
            pnlInfo.Visible = false;
            this.Focus();
            gameTimer.Enabled = true;

        }

        private void clickExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClickExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gameOver()
        {
            gameTimer.Stop();
            btnStart.Enabled= false;
            btnSnap.Enabled= true; 
            btnExit.Enabled= true;
            btnMenu.Enabled= true;

            if(score>highScore)
            {
                highScore = score;
                txtHighScore.Text = "High Score: " + Environment.NewLine + highScore;
                txtHighScore.ForeColor = Color.Maroon;
                txtHighScore.TextAlign = ContentAlignment.MiddleCenter;
            }

            playEndSound();

            showPanel(1);
        }

        private void showPanel(int status)
        {
            txtTitle.TextAlign = ContentAlignment.MiddleCenter;
            pnlInfo.Visible = true;
            gameTimer.Enabled = false;

            btnExit.Enabled = true;
            btnMenu.Enabled= true;
            btnSnap.Enabled = true;

            if (status == 0)
            {
                txtTitle.Text = "Pause";
                btnContinue.Visible = true;
            }
            else if(status == 1)
            {
                txtTitle.Text = "Game Over \nScore is: " + score;
                btnContinue.Visible = false;
            }
        }

        private void setGameSpeed()
        {
            switch(cmbLevel.SelectedIndex)
            {
                case 0:
                    gameTimer.Interval = 40;
                    break;
                case 1:
                    gameTimer.Interval = 30;
                    break;
                case 2:
                    gameTimer.Interval = 16;
                    break;
            }
        }

        private void playEatSound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"eat.wav");
            player.Play();
        }

        private void playEndSound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"end.wav");
            player.Play();
        }

    }
}
