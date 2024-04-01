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

        public void EatFood()
        {

        }

        public void SnakeMove()
        {

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
