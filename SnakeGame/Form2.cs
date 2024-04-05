using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form2 : Form
    {

        private Controller controller;

        public Form2()
        {
            InitializeComponent();

        }

        private void Music_Click(object sender, EventArgs e)
        {

        }


        /* закрте окна меню */
        private void BackToForm1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* закрытие окна на esc*/
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


    }
}
