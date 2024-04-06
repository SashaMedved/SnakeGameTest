using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Numerics;
using System.Windows.Forms;
using System.Reflection;

namespace SnakeGame
{
    internal class Model
    {
        public Form1 form1;
        public DeadForm deadForm;
        public View view;
        public PictureBox food;
        public int dirX = 1;
        public int dirY = 0;
        public int rI, rJ;
        public int count;
        public int replaceCount;

        public Model(Form1 form1, View view, DeadForm deadForm)
        {
            this.form1 = form1;
            food = form1.Controls["food"] as PictureBox;
            this.view = view;
            this.deadForm = deadForm;
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
            eatIfSelf();
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

        public void eatIfSelf()
        {
            for (int i = 1; i < form1.score; ++i)
            {
                if (view.snakeBody[0].Location == view.snakeBody[i].Location)
                {                 
                    form1.timer.Stop();
                    count = form1.score;
                    replaceCount = form1.score;

                    form1.eatTimer.Tick += new EventHandler(SnakeDestroyTimer);
                    form1.eatTimer.Interval = 350;
                    form1.removeBodyTimer.Tick += new EventHandler(SnakeReplaceBody);
                    form1.removeBodyTimer.Interval = 150;

                    form1.removeBodyTimer.Start();
                    form1.eatTimer.Start();    
                    form1.score = form1.score - (form1.score - i + 1);
                }
            }
        }

        public void SnakeReplaceBody(object sender, EventArgs eventArgs)
        {
            if (replaceCount == -1) form1.removeBodyTimer.Stop();
            else if (replaceCount == 0) view.snakeBody[0].Image = Properties.Resources.DeeadSnakeHead;
            else view.snakeBody[replaceCount].Image = Properties.Resources.deadBody;
            replaceCount--;
        }

        public void SnakeDestroyTimer(object sender, EventArgs eventArgs)
        {
            if (count == -1)
            {
                form1.eatTimer.Stop();
                form1.Enabled = false;
                deadForm.Show();
            }
            else form1.Controls.Remove(view.snakeBody[count]);
            count--;
        }

        public void BorderCheck()
        {

        }     

        public void StartProgram()
        {           
            form1.StartPosition = FormStartPosition.CenterScreen;
            form1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            form1.MaximizeBox = false;
        }
    }
}
