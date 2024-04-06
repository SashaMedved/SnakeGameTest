using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Numerics;
using System.Windows.Forms;

namespace SnakeGame
{
    internal class Model
    {
        public Form1 form1;
        public View view;
        public PictureBox food;
        public int dirX = 1;
        public int dirY = 0;
        public int rI, rJ;

        public Model(Form1 form1, View view)
        {
            this.form1 = form1;
            food = form1.Controls["food"] as PictureBox;
            this.view = view;
        }

        public void SnakeMove(object myObject, EventArgs eventArgs)
        {
            EatFood();
            MovingSnake();
        }

        public void MovingSnake()
        {
            for (int i = form1.score; i >= 1; i--)
            {
                view.snakeBody[i].Location = view.snakeBody[i - 1].Location;
            }
            view.snakeBody[0].Location = new Point(view.snakeBody[0].Location.X + form1._sizePlane * dirX, view.snakeBody[0].Location.Y + form1._sizePlane * dirY);
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
            if (view.snakeBody[0].Location.X == rI && view.snakeBody[0].Location.Y == rJ)
            {
                form1.ScoreText.Text = (form1.score + 1).ToString();
                ++form1.score;

                view.PaintBodySnake(dirX, dirY);

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
