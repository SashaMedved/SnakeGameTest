using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Numerics;

namespace SnakeGame
{
    internal class Model
    {
        public Form1 form1;
        public PictureBox food;
        public int dirX = 1;
        public int dirY = 0;
        public int rI, rJ;

        public Model(Form1 form1)
        {
            this.form1 = form1;
            food = form1.Controls["food"] as PictureBox;
        }

        public void SnakeMove(object myObject, EventArgs eventArgs)
        {
            EatFood();
            MovingSnake(form1.score);
        }

        public void MovingSnake(int score)
        {
            for (int i = score; i >= 1; i--)
            {
                form1.snakeBody[i].Location = form1.snakeBody[i - 1].Location;
            }
            form1.snakeBody[0].Location = new Point(form1.snakeBody[0].Location.X + form1._sizePlane * dirX, form1.snakeBody[0].Location.Y + form1._sizePlane * dirY);
        }

        public void CreateFood()
        {
            Random r = new Random();

            rI = r.Next(20, form1._width - form1._sizePlane);
            int tempI = rI % form1._sizePlane;
            rI -= tempI;

            rJ = r.Next(20, form1._width - form1._sizePlane);
            int tempJ = rJ % form1._sizePlane;
            rJ -= tempJ;

            food.Location = new Point(rI, rJ);
            form1.Controls.Add(food);
        }

        public void EatFood()
        {
            if (form1.snakeBody[0].Location.X == rI && form1.snakeBody[0].Location.Y == rJ)
            {
                form1.ScoreText.Text = (form1.score + 1).ToString();
                ++form1.score;
                form1.snakeBody[form1.score] = new PictureBox();
                form1.snakeBody[form1.score].Location = new Point(form1.snakeBody[form1.score - 1].Location.X + 20 * dirX, form1.snakeBody[form1.score - 1].Location.Y - 20 * dirY);
                form1.snakeBody[form1.score].Size = new Size(form1._sizePlane, form1._sizePlane);
                form1.snakeBody[form1.score].Image = Properties.Resources.body;
                form1.snakeBody[form1.score].BackColor = Color.Transparent;
                form1.Controls.Add(form1.snakeBody[form1.score]);
                CreateFood();
            }
        }

        public void BorderCheck()
        {

        }

        public void StartProgram()
        {
            SoundPlayer sndPlayer = new SoundPlayer();
            sndPlayer.Stream = Properties.Resources.snake;
            sndPlayer.PlayLooping();

            form1.StartPosition = FormStartPosition.CenterScreen;
            form1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            form1.MaximizeBox = false;
        }
    }
}
