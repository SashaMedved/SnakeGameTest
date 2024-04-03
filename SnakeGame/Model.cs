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
        public int dirX = 1;
        public int dirY = 0;

        public Model(Form1 form1)
        {
            this.form1 = form1;
            snake = form1.Controls["snake"] as PictureBox;
        }

        public void SnakeMove(object myObject, EventArgs eventArgs)
        {
            snake.Location = new Point(snake.Location.X + form1._sizePlane * dirX, snake.Location.Y + form1._sizePlane * dirY);
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
