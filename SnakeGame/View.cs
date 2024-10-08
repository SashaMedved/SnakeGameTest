﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace SnakeGame
{
    internal class View
    {
        private Form1 form1;

        public PictureBox[] snakeBody = new PictureBox[875]; //Массив тела змеи

        public View(Form1 form1)
        {
            this.form1 = form1;
        }

        public void PaintHeadSnake() //Отрисовка головы
        {
            snakeBody[0] = new PictureBox();
            snakeBody[0].Location = new Point(200, 200);
            snakeBody[0].Size = new Size(20, 20);
            snakeBody[0].Image = Properties.Resources.snakeHead;
            snakeBody[0].BackColor = Color.Transparent;
            form1.Controls.Add(snakeBody[0]);
        }

        public void CreateMap(int width, int height, int sizePlane) //Создание карты
        {           
            for (int i = 0; i <= width / sizePlane; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.BackColor = Color.DarkGray;
                pictureBox.Location = new Point(0, sizePlane * i);
                pictureBox.Size = new Size(width, 1);
                form1.Controls.Add(pictureBox);
            }
            for (int i = 0; i <= height / sizePlane; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.BackColor = Color.DarkGray;
                pictureBox.Location = new Point(sizePlane * i, 0);
                pictureBox.Size = new Size(1, height - 220);
                form1.Controls.Add(pictureBox);
            }
        }

        public void PaintBodySnake(int dirX, int dirY) //Отрисовка тела змеи
        {
            snakeBody[form1.score] = new PictureBox();
            snakeBody[form1.score].Location = new Point(snakeBody[form1.score - 1].Location.X + 20 * dirX, snakeBody[form1.score - 1].Location.Y - 20 * dirY);
            snakeBody[form1.score].Size = new Size(form1._sizePlane, form1._sizePlane);
            snakeBody[form1.score].Image = Properties.Resources.body;
            snakeBody[form1.score].BackColor = Color.Transparent;
            form1.Controls.Add(snakeBody[form1.score]);
        }

        public void PaintSnakeDeadBorder(int dirX, int dirY) //Отрисовка мертвого тела змеи
        {
            snakeBody[form1.score + 1] = new PictureBox();
            snakeBody[form1.score + 1].Location = new Point(snakeBody[form1.score].Location.X + 20 * dirX, snakeBody[form1.score].Location.Y - 20 * dirY);
            snakeBody[form1.score + 1].Size = new Size(form1._sizePlane, form1._sizePlane);
            snakeBody[form1.score + 1].Image = Properties.Resources.body;
            snakeBody[form1.score + 1].BackColor = Color.Transparent;
            form1.Controls.Add(snakeBody[form1.score + 1]);
        }
    }
}
