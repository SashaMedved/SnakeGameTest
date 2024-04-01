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
            snake = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)snake).BeginInit();
            SuspendLayout();
            // 
            // snake
            // 
            snake.BackColor = Color.Red;
            snake.Location = new Point(0, 0);
            snake.Name = "snake";
            snake.Size = new Size(40, 40);
            snake.TabIndex = 0;
            snake.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(snake);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)snake).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox snake;
        private System.Windows.Forms.Timer timer;
    }
}
