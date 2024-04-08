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
    public partial class DeadForm : Form
    {
        private Form1 form1;
        public DeadForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void buttonExitFull_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Close();
        }
    }
}
