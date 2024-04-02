using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SnakeGame
{
    internal class Model
    {
        public Form1 form1;
        public PictureBox snake;
        public PictureBox food;

        public int rI, rJ;
        public int dirX = 1;
        public int dirY = 0;

        public Model(Form1 form1)
        {
            this.form1 = form1;
            snake = form1.Controls["snake"] as PictureBox;            
        }

        public void CreateFood(int width, int _sizeHead)
        {
            Random r = new Random();
            rI = r.Next(0, width - _sizeHead);
            int tempI = rI % _sizeHead;
            rI -= tempI;
            rJ = r.Next(0, width - _sizeHead);
            int tempJ = rJ % _sizeHead;
            rJ -= tempJ;
            food.Location = new Point(rI, rJ);
            form1.Controls.Add(food);
        }


        public void EatFood()
        {
            
        }

        public void SnakeMove(object myObject, EventArgs eventArgs)
        {
            snake.Location = new Point(snake.Location.X + form1._sizeHead * dirX, snake.Location.Y + form1._sizeHead * dirY);
        }

        public void BorderCheck()
        {

        }

        public void StartProgram(Form form)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
