﻿using System;
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
        public Form1 form1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Enabled = true;
            form1.buttonStart.Enabled = true;
            form1.BringToFront();
        }

        private void buttonExitGame_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Enabled = true;
            form1.buttonStart.Enabled = true;
            form1.BringToFront();
            form1.Close();
        }
    }
}
