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
    public partial class Form3 : Form
    {
        private Form1 form1;
        public Form3(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            form1.Enabled = true;
            this.Close();
        }
    }
}
