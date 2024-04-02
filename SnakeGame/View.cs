using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    
    internal class View
    {
        public void CreateMap(Form form, int width, int height, int _sizeHead)
        {

            form.BackColor = Color.White;


            for (int i=0; i <= width/ _sizeHead; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.BackColor = Color.DarkGray;
                pictureBox.Location = new Point(0, _sizeHead * i);
                pictureBox.Size = new Size(width, 1);
                form.Controls.Add(pictureBox);
            }
            for (int i = 0; i <= height / _sizeHead; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.BackColor = Color.DarkGray;
                pictureBox.Location = new Point(_sizeHead * i, 0);
                pictureBox.Size = new Size(1, height - 220);
                form.Controls.Add(pictureBox);
            }
        }
    }
}
