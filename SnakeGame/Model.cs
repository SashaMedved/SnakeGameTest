using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Model
    {
        public Form1 form1;
        public PictureBox snake;
        public PictureBox food;
        public int dirX = 1;
        public int dirY = 0;

        public Model(Form1 form1)
        {
            this.form1 = form1;
            snake = form1.Controls["snake"] as PictureBox;
            food = form1.Controls["food"] as PictureBox;
        }

        public void SnakeMove(object myObject, EventArgs eventArgs)
        {
            snake.Location = new Point(snake.Location.X + form1._sizePlane * dirX, snake.Location.Y + form1._sizePlane * dirY);
        }

        public void CreateFood(int width, int sizeBorder)
        {
            Random r = new Random();

            var rI = r.Next(20, width - sizeBorder);
            int tempI = rI % sizeBorder;
            rI -= tempI;

            var rJ = r.Next(20, width - sizeBorder);
            int tempJ = rJ % sizeBorder;
            rJ -= tempJ;

            food.Location = new Point(rI, rJ);
            form1.Controls.Add(food);
        }

        public void EatFood()
        {
            
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
