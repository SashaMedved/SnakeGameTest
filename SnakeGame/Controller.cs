using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Controller
    {
        private Model model;

        public Controller(Model model)
        {
            this.model = model;
        }

        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            CheckKey(sender, e.KeyCode);
        }

        public void CheckKey(object sender, Keys keyCode)
        {
            switch (keyCode)
            {
                case Keys.Right:
                case Keys.D:
                    model.dirY = 0;
                    model.dirX = 1;
                    break;
                case Keys.A:
                case Keys.Left:
                    model.dirX = -1;
                    model.dirY = 0;
                    break;
                case Keys.W:
                case Keys.Up:
                    model.dirX = 0;
                    model.dirY = -1;
                    break;
                case Keys.S:
                case Keys.Down:
                    model.dirX = 0;
                    model.dirY = 1;
                    break;
            }
        }
    }
}
