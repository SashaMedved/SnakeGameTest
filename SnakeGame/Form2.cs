using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form2 : Form
    {
        public Form1 form1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

            OnCheckMusic();
        }

        private void buttonBack_Click(object sender, EventArgs e) //Выход из меню
        {
            this.Close();
            form1.Enabled = true;
            form1.buttonStart.Enabled = true;
            form1.BringToFront();
        }

        private void buttonExitGame_Click(object sender, EventArgs e) //Выход их игры
        {
            this.Close();
            form1.Enabled = true;
            form1.buttonStart.Enabled = true;
            form1.BringToFront();
            form1.Close();
        }

        public void OnCheckMusic() //Проверка кнопки музыки
        {
            if (form1.flagMusic == false) buttonMusic.BackColor = Color.MediumSeaGreen;
            else if (form1.flagMusic == true) buttonMusic.BackColor = Color.FromArgb(236, 108, 85);
        }

        private void buttonMusic_Click(object sender, EventArgs e) //Нажатие кнопки музыки
        {
            if (form1.flagMusic == false)
            {
                buttonMusic.BackColor = Color.FromArgb(236, 108, 85);
                form1.flagMusic = true;
            }
            else if (form1.flagMusic == true)
            {
                buttonMusic.BackColor = Color.MediumSeaGreen;
                form1.flagMusic = false;
            }
        }
    }
}
