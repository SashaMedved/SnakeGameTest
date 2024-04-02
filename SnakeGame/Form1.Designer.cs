
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
            Score = new Label();
            food = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)snake).BeginInit();
            SuspendLayout();
            // 
            // food
            // 

            food.BackColor = Color.Red;
            food.Size = new Size(_sizeHead, _sizeHead);
            // 
            // snake
            // 
            snake.BackColor = Color.FromArgb(64, 64, 64);
            snake.Image = (Image)resources.GetObject("snake.Image");
            snake.Location = new Point(260, 260);
            snake.Name = "snake";
            snake.Size = new Size(20, 20);
            snake.TabIndex = 0;
            snake.TabStop = false;
            // 
            // Score
            // 
            Score.Anchor = AnchorStyles.Left;
            Score.AutoSize = true;
            Score.BackColor = Color.Transparent;
            Score.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Score.Location = new Point(299, 560);
            Score.Margin = new Padding(0);
            Score.Name = "Score";
            Score.Size = new Size(148, 37);
            Score.TabIndex = 1;
            Score.Text = "SCORE: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(497, 706);
            Controls.Add(Score);
            Controls.Add(snake);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(497, 730);
            Name = "Form1";
            Text = "Snake";
            ((System.ComponentModel.ISupportInitialize)snake).EndInit();
            ResumeLayout(false);
            PerformLayout();

            
        }


        #endregion
        public PictureBox food;
        public PictureBox snake;
        private System.Windows.Forms.Timer timer;
        private Label Score;
        
    }
}
