using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public enum Direction //Направление змеи в настоящее время
    {
        Up,
        Down,
        Left,
        Right
    }

    internal class Controller
    {
        private Direction currentDirection = Direction.Right;

        private Model model;
        private View view;
        private Form1 form1;
        private DeadForm deadForm;

        public Controller(Model model, Form1 form1, View view, DeadForm deadForm)
        {
            this.view = view;
            this.model = model;
            this.form1 = form1;
            this.deadForm = deadForm;
        }
        
        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            CheckKey(sender, e.KeyCode.ToString());
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
            model.dirX = dirX;
            model.dirY = dirY;
        }

        public void GamePad() //Обработчик нажатий кнопок на формах
        {
            form1.buttonRight.Click += (sender, args) => CheckKey(sender, "D");
            form1.buttonLeft.Click += (sender, args) => CheckKey(sender, "A");
            form1.buttonUp.Click += (sender, args) => CheckKey(sender, "W");
            form1.buttonDown.Click += (sender, args) => CheckKey(sender, "S");

            form1.buttonExit.Click += (sender, args) => form1.Close();
            form1.buttonStart.Click += (sender, args) => form1.Timer();
            form1.buttonMenu.Click += (sender, args) => form1.OpenMenu();

            deadForm.buttonRestart.Click += (sender, args) =>
            {
                deadForm.Close();
                Process.Start(Application.ExecutablePath);
                form1.Close();
            };
        }
    }
}
