﻿using System;
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

        public void CheckKey(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Right":
                    model.dirY = 0;
                    model.dirX = 1;
                    break;
                case "Left":
                    model.dirX = -1;
                    model.dirY = 0;
                    break;
                case "Up":
                    model.dirX = 0;
                    model.dirY = -1;
                    break;
                case "Down":
                    model.dirX = 0;
                    model.dirY = 1;
                    break;
            }
        }
    }
}
