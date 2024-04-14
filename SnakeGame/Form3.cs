using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form3 : Form
    {
        private Form1 form1;

        public Font Lato_Regular;
        public Font guno;

        public Form3(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            LoadFont();
            buttonContinue.Font = guno;
            label1.Font = Lato_Regular;
            label2.Font = Lato_Regular;
            label3.Font = Lato_Regular;
        }

        private void buttonContinue_Click(object sender, EventArgs e) //Нажатие кнопки PLAY
        {
            form1.Enabled = true;
            this.Close();
        }

        private void LoadFont() //Загрузка шрифта
        {
            PrivateFontCollection custom_font1 = new PrivateFontCollection();
            PrivateFontCollection custom_font2 = new PrivateFontCollection();

            custom_font1.AddFontFile("guno.otf");
            custom_font2.AddFontFile("Lato_Regular.ttf");
            Lato_Regular = new Font(custom_font1.Families[0], 13);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
