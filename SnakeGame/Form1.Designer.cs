
namespace SnakeGame
{
    partial class s
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(s));
            snake = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            Score = new Label();
            food = new PictureBox();
            buttonRight = new Button();
            buttonUp = new Button();
            buttonDown = new Button();
            buttonLeft = new Button();
            ((System.ComponentModel.ISupportInitialize)snake).BeginInit();
            ((System.ComponentModel.ISupportInitialize)food).BeginInit();
            SuspendLayout();
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
            // food
            // 
            food.BackColor = Color.Red;
            food.Location = new Point(0, 0);
            food.Name = "food";
            food.Size = new Size(100, 50);
            food.TabIndex = 0;
            food.TabStop = false;
            // 
            // buttonRight
            // 
            buttonRight.Location = new Point(150, 560);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(22, 22);
            buttonRight.TabIndex = 2;
            buttonRight.Text = " ";
            buttonRight.UseVisualStyleBackColor = true;
            // 
            // buttonUp
            // 
            buttonUp.Location = new Point(112, 520);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(22, 22);
            buttonUp.TabIndex = 3;
            buttonUp.Text = " ";
            buttonUp.UseVisualStyleBackColor = true;
            // 
            // buttonDown
            // 
            buttonDown.Location = new Point(112, 599);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(22, 22);
            buttonDown.TabIndex = 4;
            buttonDown.Text = " ";
            buttonDown.UseVisualStyleBackColor = true;
            // 
            // buttonLeft
            // 
            buttonLeft.Location = new Point(73, 560);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(22, 22);
            buttonLeft.TabIndex = 5;
            buttonLeft.Text = " ";
            buttonLeft.UseVisualStyleBackColor = true;
            // 
            // s
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(497, 706);
            Controls.Add(buttonLeft);
            Controls.Add(buttonDown);
            Controls.Add(buttonUp);
            Controls.Add(buttonRight);
            Controls.Add(Score);
            Controls.Add(snake);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(497, 730);
            Name = "s";
            Text = "Snake";
            ((System.ComponentModel.ISupportInitialize)snake).EndInit();
            ((System.ComponentModel.ISupportInitialize)food).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        public PictureBox food;
        public PictureBox snake;
        private System.Windows.Forms.Timer timer;
        private Label Score;
        private Button buttonRight;
        private Button buttonUp;
        private Button buttonDown;
        private Button buttonLeft;
    }
}
