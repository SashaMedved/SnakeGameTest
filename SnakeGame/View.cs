using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    internal class View
    {
        public void CreateMap(Form form, int width, int height, int sizePlane)
        {           
            for (int i = 0; i <= width / sizePlane; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.BackColor = Color.DarkGray;
                pictureBox.Location = new Point(0, sizePlane * i);
                pictureBox.Size = new Size(width, 1);
                form.Controls.Add(pictureBox);
            }
            for (int i = 0; i <= height / sizePlane; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.BackColor = Color.DarkGray;
                pictureBox.Location = new Point(sizePlane * i, 0);
                pictureBox.Size = new Size(1, height - 220);
                form.Controls.Add(pictureBox);
            }
        }
    }
}
