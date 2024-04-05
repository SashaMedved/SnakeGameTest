using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    internal class Controller
    {
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
            Image flipImage = view.snakeBody[0].Image;
            switch (keyCode)
            {
                case "D":
                    flipImage.RotateFlip(RotateFlipType.Rotate90FlipY);
                    model.dirY = 0;
                    model.dirX = 1;
                    break;
                case "A":
                    model.dirX = -1;
                    model.dirY = 0;
                    break;
                case "W":
                    model.dirX = 0;
                    model.dirY = -1;
                    break;
                case "S":
                    model.dirX = 0;
                    model.dirY = 1;
                    break;
            }
        }

        public void buttonEXIT_Click(object sender, EventArgs e)
        {
            form1.Close();
        }
    }
}
