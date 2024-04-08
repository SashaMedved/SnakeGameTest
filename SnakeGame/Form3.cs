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

        public Font guno;

        public Form3(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            LoadFont();
            buttonContinue.Font = guno;
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            form1.Enabled = true;
            this.Close();
        }

        private void LoadFont()
        {
            PrivateFontCollection custom_font = new PrivateFontCollection();
            custom_font.AddFontFile("guno.otf");
            guno = new Font(custom_font.Families[0], 30);
        }
    }
}
