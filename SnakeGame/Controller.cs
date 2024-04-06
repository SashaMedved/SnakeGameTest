using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

    internal class Controller
    {
        private Direction currentDirection = Direction.Right;

        public Model model;
        public View view;
        public Form1 form1;

        public Controller(Model model, Form1 form1, View view)
        {
            this.view = view;
            this.model = model;
            this.form1 = form1;
        }
        
        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            CheckKey(sender, e.KeyCode.ToString());
        }
        
        public void CheckKey(object sender, string keyCode)
        {
            Direction direction = currentDirection;

            switch (keyCode)
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

        public void buttonEXIT_Click(object sender, EventArgs e)
        {
            form1.Close();
        }
    }
}
