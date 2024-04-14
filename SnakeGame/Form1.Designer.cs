using System.Windows.Forms;

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
            timer = new System.Windows.Forms.Timer(components);
            buttonRight = new Button();
            buttonLeft = new Button();
            buttonUp = new Button();
            buttonDown = new Button();
            TaskBar = new Panel();
            buttonExit = new Button();
            food = new PictureBox();
            ScoreText = new Label();
            buttonStart = new Button();
            buttonMenu = new Button();
            eatTimer = new System.Windows.Forms.Timer(components);
            removeBodyTimer = new System.Windows.Forms.Timer(components);
            TaskBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)food).BeginInit();
            SuspendLayout();
            // 
            // buttonRight
            // 
            buttonRight.BackColor = SystemColors.Control;
            buttonRight.Location = new Point(136, 570);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(49, 43);
            buttonRight.TabIndex = 1;
            buttonRight.TabStop = false;
            buttonRight.UseVisualStyleBackColor = false;
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
            // food
            // 
            food.Image = Properties.Resources.Food;
            food.Location = new Point(320, 125);
            food.Name = "food";
            food.Size = new Size(20, 20);
            food.TabIndex = 9;
            food.TabStop = false;
            // 
            // ScoreText
            // 
            ScoreText.AutoSize = true;
            ScoreText.BackColor = Color.Transparent;
            ScoreText.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ScoreText.ForeColor = Color.FromArgb(54, 46, 45);
            ScoreText.Location = new Point(406, 557);
            ScoreText.Name = "ScoreText";
            ScoreText.Size = new Size(33, 37);
            ScoreText.TabIndex = 10;
            ScoreText.Text = "0";
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.Transparent;
            buttonStart.FlatAppearance.BorderSize = 0;
            buttonStart.FlatStyle = FlatStyle.Flat;
            buttonStart.ForeColor = Color.FromArgb(236, 108, 85);
            buttonStart.Location = new Point(265, 614);
            buttonStart.Margin = new Padding(0);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
            buttonStart.TabIndex = 11;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = false;
            // 
            // buttonMenu
            // 
            buttonMenu.BackColor = Color.Transparent;
            buttonMenu.FlatAppearance.BorderSize = 0;
            buttonMenu.FlatStyle = FlatStyle.Flat;
            buttonMenu.ForeColor = Color.FromArgb(236, 108, 85);
            buttonMenu.Location = new Point(364, 614);
            buttonMenu.Margin = new Padding(0);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(75, 23);
            buttonMenu.TabIndex = 12;
            buttonMenu.Text = "Menu";
            buttonMenu.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.GameBoy1;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(496, 700);
            ControlBox = false;
            Controls.Add(buttonMenu);
            Controls.Add(buttonStart);
            Controls.Add(ScoreText);
            Controls.Add(food);
            Controls.Add(TaskBar);
            Controls.Add(buttonDown);
            Controls.Add(buttonUp);
            Controls.Add(buttonLeft);
            Controls.Add(buttonRight);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(496, 700);
            Name = "Form1";
            TaskBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)food).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel TaskBar;
        private PictureBox food;
        public Label ScoreText;
        public Button buttonRight;
        public Button buttonLeft;
        public Button buttonUp;
        public Button buttonDown;
        public Button buttonStart;
        public Button buttonMenu;
        public Button buttonExit;
        public System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Timer eatTimer;
        public System.Windows.Forms.Timer removeBodyTimer;
    }
}
