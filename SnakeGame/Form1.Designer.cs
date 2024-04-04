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
            buttonMenu = new Button();
            Strat = new Button();
            TaskBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)food).BeginInit();
            SuspendLayout();
            // 
            // buttonRight
            // 
            buttonRight.BackColor = Color.Transparent;
            buttonRight.FlatAppearance.BorderSize = 0;
            buttonRight.FlatStyle = FlatStyle.Flat;
            buttonRight.Location = new Point(134, 572);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(50, 40);
            buttonRight.TabIndex = 2;
            buttonRight.Text = " ";
            buttonRight.UseVisualStyleBackColor = false;
            // 
            // buttonLeft
            // 
            buttonLeft.BackColor = Color.Transparent;
            buttonLeft.FlatAppearance.BorderSize = 0;
            buttonLeft.FlatStyle = FlatStyle.Flat;
            buttonLeft.Location = new Point(39, 572);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(50, 40);
            buttonLeft.TabIndex = 5;
            buttonLeft.Text = " ";
            buttonLeft.UseVisualStyleBackColor = false;
            // 
            // buttonUp
            // 
            buttonUp.BackColor = Color.Transparent;
            buttonUp.FlatAppearance.BorderSize = 0;
            buttonUp.FlatStyle = FlatStyle.Flat;
            buttonUp.ForeColor = Color.Transparent;
            buttonUp.Location = new Point(91, 518);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(40, 50);
            buttonUp.TabIndex = 3;
            buttonUp.Text = " ";
            buttonUp.UseVisualStyleBackColor = false;
            // 
            // buttonDown
            // 
            buttonDown.BackColor = Color.Transparent;
            buttonDown.FlatAppearance.BorderSize = 0;
            buttonDown.FlatStyle = FlatStyle.Flat;
            buttonDown.Location = new Point(91, 615);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(40, 50);
            buttonDown.TabIndex = 4;
            buttonDown.Text = " ";
            buttonDown.UseVisualStyleBackColor = false;
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
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Location = new Point(467, 5);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(25, 10);
            buttonExit.TabIndex = 6;
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
            ScoreText.Location = new Point(412, 564);
            ScoreText.Name = "ScoreText";
            ScoreText.Size = new Size(13, 15);
            ScoreText.TabIndex = 10;
            ScoreText.Text = "0";
            // 
            // buttonMenu
            // 
            buttonMenu.Location = new Point(380, 629);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(75, 23);
            buttonMenu.TabIndex = 11;
            buttonMenu.Text = "button1";
            buttonMenu.UseVisualStyleBackColor = true;
            buttonMenu.Click += button1_Click;
            // 
            // Strat
            // 
            Strat.Location = new Point(251, 641);
            Strat.Name = "Strat";
            Strat.Size = new Size(75, 23);
            Strat.TabIndex = 12;
            Strat.Text = "Start";
            Strat.UseVisualStyleBackColor = true;
            Strat.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.GameBoy1;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(496, 700);
            ControlBox = false;
            Controls.Add(Strat);
            Controls.Add(buttonMenu);
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
            ShowInTaskbar = false;
            TaskBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)food).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private Button buttonRight;
        private Button buttonLeft;
        private Button buttonUp;
        private Button buttonDown;
        private Panel TaskBar;
        private Button buttonExit;
        private PictureBox food;
        public Label ScoreText;
        private Button buttonMenu;
        private Button Strat;
    }
}
