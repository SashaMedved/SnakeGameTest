
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            snakeHead = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)snakeHead).BeginInit();
            SuspendLayout();
            // 
            // snakeHead
            // 
            snakeHead.BackColor = SystemColors.ActiveCaptionText;
            snakeHead.Location = new Point(326, 275);
            snakeHead.Name = "snakeHead";
            snakeHead.Size = new Size(20, 20);
            snakeHead.TabIndex = 0;
            snakeHead.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 661);
            Controls.Add(snakeHead);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(496, 700);
            MinimumSize = new Size(496, 700);
            Name = "Form1";
            Text = "Snake";
            ((System.ComponentModel.ISupportInitialize)snakeHead).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private PictureBox snakeHead;
    }
}
