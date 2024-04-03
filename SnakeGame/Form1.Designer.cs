﻿namespace SnakeGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            snake = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            buttonRight = new Button();
            buttonLeft = new Button();
            buttonUp = new Button();
            buttonDown = new Button();
            TaskBar = new Panel();
            buttonExit = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)snake).BeginInit();
            TaskBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // snake
            // 
            snake.BackColor = Color.Transparent;
            snake.Image = Properties.Resources.snakeHead;
            snake.Location = new Point(100, 140);
            snake.Name = "snake";
            snake.Size = new Size(20, 20);
            snake.TabIndex = 0;
            snake.TabStop = false;
            // 
            // buttonRight
            // 
            buttonRight.Location = new Point(137, 570);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(49, 43);
            buttonRight.TabIndex = 1;
            buttonRight.TabStop = false;
            buttonRight.UseVisualStyleBackColor = true;
            // 
            // buttonLeft
            // 
            buttonLeft.Location = new Point(37, 570);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(49, 43);
            buttonLeft.TabIndex = 2;
            buttonLeft.TabStop = false;
            buttonLeft.UseVisualStyleBackColor = true;
            // 
            // buttonUp
            // 
            buttonUp.Location = new Point(90, 516);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(43, 49);
            buttonUp.TabIndex = 3;
            buttonUp.TabStop = false;
            buttonUp.UseVisualStyleBackColor = true;
            // 
            // buttonDown
            // 
            buttonDown.Location = new Point(90, 614);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(43, 49);
            buttonDown.TabIndex = 4;
            buttonDown.TabStop = false;
            buttonDown.UseVisualStyleBackColor = true;
            // 
            // TaskBar
            // 
            TaskBar.BackColor = Color.FromArgb(238, 229, 208);
            TaskBar.BackgroundImage = (Image)resources.GetObject("TaskBar.BackgroundImage");
            TaskBar.Controls.Add(buttonExit);
            TaskBar.Location = new Point(0, 0);
            TaskBar.Name = "TaskBar";
            TaskBar.Size = new Size(497, 20);
            TaskBar.TabIndex = 8;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Transparent;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Location = new Point(467, 5);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(25, 10);
            buttonExit.TabIndex = 8;
            buttonExit.Text = " ";
            buttonExit.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Food;
            pictureBox1.Location = new Point(320, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.GameBoy1;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(496, 700);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(TaskBar);
            Controls.Add(buttonDown);
            Controls.Add(buttonUp);
            Controls.Add(buttonLeft);
            Controls.Add(buttonRight);
            Controls.Add(snake);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(496, 700);
            Name = "Form1";
            ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)snake).EndInit();
            TaskBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox snake;
        private System.Windows.Forms.Timer timer;
        private Button buttonRight;
        private Button buttonLeft;
        private Button buttonUp;
        private Button buttonDown;
        private Panel TaskBar;
        private Button buttonExit;
        private PictureBox pictureBox1;
    }
}
