namespace SnakeGame
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
            ((System.ComponentModel.ISupportInitialize)snake).BeginInit();
            SuspendLayout();
            // 
            // snake
            // 
            snake.BackColor = Color.Transparent;
            snake.Image = Properties.Resources.snakeHead;
            snake.Location = new Point(0, 0);
            snake.Name = "snake";
            snake.Size = new Size(20, 20);
            snake.TabIndex = 0;
            snake.TabStop = false;
            // 
            // buttonRight
            // 
            buttonRight.Location = new Point(154, 561);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(20, 20);
            buttonRight.TabIndex = 1;
            buttonRight.TabStop = false;
            buttonRight.UseVisualStyleBackColor = true;
            // 
            // buttonLeft
            // 
            buttonLeft.Location = new Point(73, 561);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(20, 20);
            buttonLeft.TabIndex = 2;
            buttonLeft.TabStop = false;
            buttonLeft.UseVisualStyleBackColor = true;
            // 
            // buttonUp
            // 
            buttonUp.Location = new Point(113, 520);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(20, 20);
            buttonUp.TabIndex = 3;
            buttonUp.TabStop = false;
            buttonUp.UseVisualStyleBackColor = true;
            // 
            // buttonDown
            // 
            buttonDown.Location = new Point(113, 600);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(20, 20);
            buttonDown.TabIndex = 4;
            buttonDown.TabStop = false;
            buttonDown.UseVisualStyleBackColor = true;
            // 
            // TaskBar
            // 
            TaskBar.BackgroundImage = (Image)resources.GetObject("TaskBar.BackgroundImage");
            TaskBar.Enabled = false;
            TaskBar.Location = new Point(0, 0);
            TaskBar.Name = "TaskBar";
            TaskBar.Size = new Size(496, 20);
            TaskBar.TabIndex = 5;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = SystemColors.Control;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Location = new Point(342, 84);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(25, 10);
            buttonExit.TabIndex = 8;
            buttonExit.Text = " ";
            buttonExit.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.GameBoy1;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(496, 700);
            ControlBox = false;
            Controls.Add(buttonExit);
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
    }
}
