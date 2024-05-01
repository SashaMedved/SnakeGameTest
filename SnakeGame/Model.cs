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
    public enum Direction //Направление змеи в настоящее время
    {
        Up,
        Down,
        Left,
        Right
    }

    internal class Model
    {
        private Form1 form1;
        private DeadForm deadForm;
        private View view;

        private Direction currentDirection = Direction.Right;
        public PictureBox food;

        public bool flagDeadCheckBorder;     
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

        public void SnakeMove(object myObject, EventArgs eventArgs) //Обработчик перемещения змеи
        {
            BorderCheck();
            EatFood();
            MovingSnake();
        }

        public void MovingSnake() //Перемещение змеи
        {
            for (int i = form1.score; i >= 1; i--)
            {
                view.snakeBody[i].Location = view.snakeBody[i - 1].Location;
            }
            view.snakeBody[0].Location = new Point(view.snakeBody[0].Location.X + form1._sizePlane * dirX, view.snakeBody[0].Location.Y + form1._sizePlane * dirY);
            eatIfSelf();
        }

        public void CreateFood() //Генерация фрукта в случайном месте
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

        public void EatFood() //Если фрукт съедается змея растет
        {
            if (view.snakeBody[0].Location.X == rI && view.snakeBody[0].Location.Y == rJ)
            {
                form1.ScoreText.Text = (form1.score + 1).ToString();
                ++form1.score;

                view.PaintBodySnake(dirX, dirY);

                CreateFood();
            }
        }

        public void eatIfSelf() //Если змея врезалась в саму себя
        {
            for (int i = 1; i < form1.score; ++i)
            {
                if (view.snakeBody[0].Location == view.snakeBody[i].Location)
                {
                    TimerSnakeDead();
                    form1.score = form1.score - (form1.score - i + 1);
                }
            }
        }

        public void TimerSnakeDead() //Обработчик таймера при смерти
        {
            form1.timer.Stop();
            count = form1.score;
            replaceCount = form1.score;

            form1.eatTimer.Tick += new EventHandler(SnakeDestroyTimer);
            form1.eatTimer.Interval = 350;
            form1.removeBodyTimer.Tick += new EventHandler(SnakeReplaceBody);
            form1.removeBodyTimer.Interval = 150;

            form1.sndPlayer.Stop();
            form1.removeBodyTimer.Start();
            form1.eatTimer.Start();         
        }

        public void SnakeReplaceBody(object sender, EventArgs eventArgs) //Замена текстуры змеи на мертвую змею
        {
            if (replaceCount > 1) view.snakeBody[replaceCount].Image = Properties.Resources.deadBody;
            else if (replaceCount == 1)
            {
                if (flagDeadCheckBorder) view.snakeBody[1].Image = Properties.Resources.DeeadSnakeHead;
                else view.snakeBody[1].Image = Properties.Resources.deadBody;
            }   
            else if (replaceCount == 0) view.snakeBody[0].Image = Properties.Resources.DeeadSnakeHead;
            if (replaceCount == -1) form1.removeBodyTimer.Stop();
            replaceCount--;
        }

        public void SnakeDestroyTimer(object sender, EventArgs eventArgs) //Удаление змеи с экрана
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

        public void BorderCheck() //Обработчик врезания в стену
        {
            if (view.snakeBody[0].Location.X < 0 || view.snakeBody[0].Location.X > form1._width || view.snakeBody[0].Location.Y < 20 || view.snakeBody[0].Location.Y > form1._width - 20)
            {
                flagDeadCheckBorder = true;
                form1.Controls.Remove(view.snakeBody[0]);
                view.PaintSnakeDeadBorder(dirX, dirY);
                view.snakeBody[1].Image = Properties.Resources.snakeHead;
                form1.score++;
                TimerSnakeDead();
                form1.score = 0;
            }          
        }

        public void CheckKey(object sender, string keyCode) //Проверка какая кнопка нажата
        {
            Direction direction = currentDirection;

            switch (keyCode) //Тут идет проверка чтобы змея не могла ползать сквозь себя
            {
                case "D":
                    if (form1.score != 0)
                    {
                        if (currentDirection != Direction.Left)
                            AcceptXY(Direction.Right, 1, 0);
                    }
                    else
                        AcceptXY(Direction.Right, 1, 0);
                    break;
                case "A":
                    if (form1.score != 0)
                    {
                        if (currentDirection != Direction.Right)
                            AcceptXY(Direction.Left, -1, 0);
                    }
                    else
                        AcceptXY(Direction.Left, -1, 0);
                    break;
                case "W":
                    if (form1.score != 0)
                    {
                        if (currentDirection != Direction.Down)
                            AcceptXY(Direction.Up, 0, -1);
                    }
                    else
                        AcceptXY(Direction.Up, 0, -1);
                    break;
                case "S":
                    if (form1.score != 0)
                    {
                        if (currentDirection != Direction.Up)
                            AcceptXY(Direction.Down, 0, 1);
                    }
                    else
                        AcceptXY(Direction.Down, 0, 1);
                    break;
            }
        }

        public void AcceptXY(Direction direction, int dirX, int dirY)
        {
            currentDirection = direction;
            this.dirX = dirX;
            this.dirY = dirY;
        }

        public void StartProgram() //Старт программы
        {           
            form1.StartPosition = FormStartPosition.CenterScreen;
            form1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            form1.MaximizeBox = false;
        }
    }
}
