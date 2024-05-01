using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    internal class Controller
    {
        private Direction currentDirection = Direction.Right;

        private Model model;
        private Form1 form1;
        private DeadForm deadForm;

        public Controller(Model model, Form1 form1, DeadForm deadForm)
        {
            this.model = model;
            this.form1 = form1;
            this.deadForm = deadForm;
        }
        
        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            model.CheckKey(sender, e.KeyCode.ToString());
        }      

        public void GamePad() //Обработчик нажатий кнопок на формах
        {
            form1.buttonRight.Click += (sender, args) => model.CheckKey(sender, "D");
            form1.buttonLeft.Click += (sender, args) => model.CheckKey(sender, "A");
            form1.buttonUp.Click += (sender, args) => model.CheckKey(sender, "W");
            form1.buttonDown.Click += (sender, args) => model.CheckKey(sender, "S");

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
