using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Controller
    {
        private Model _model;

        public Controller(Model model)
        {
            this._model = model;
        }

        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            CheckKey(sender, e.KeyCode.ToString());
        }

        public void CheckKey(object sender, string keyCode)
        {
            switch (keyCode)
            {
                case "D":

                    _model.dirY = 0;
                    _model.dirX = 1;
                    break;
                case "A":
                    _model.dirX = -1;
                    _model.dirY = 0;
                    break;
                case "W":
                    _model.dirX = 0;
                    _model.dirY = -1;
                    break;
                case "S":
                    _model.dirX = 0;
                    _model.dirY = 1;
                    break;
            }
        }
    }
}
