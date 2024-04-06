namespace SnakeGame
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonBack = new Button();
            buttonExitGame = new Button();
            buttonMusic = new Button();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.FromArgb(236, 108, 85);
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Location = new Point(75, 198);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(200, 50);
            buttonBack.TabIndex = 0;
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonExitGame
            // 
            buttonExitGame.BackColor = Color.FromArgb(236, 108, 85);
            buttonExitGame.FlatAppearance.BorderSize = 0;
            buttonExitGame.FlatStyle = FlatStyle.Flat;
            buttonExitGame.Location = new Point(75, 329);
            buttonExitGame.Name = "buttonExitGame";
            buttonExitGame.Size = new Size(200, 50);
            buttonExitGame.TabIndex = 1;
            buttonExitGame.UseVisualStyleBackColor = false;
            buttonExitGame.Click += buttonExitGame_Click;
            // 
            // buttonMusic
            // 
            buttonMusic.BackColor = Color.MediumSeaGreen;
            buttonMusic.FlatAppearance.BorderSize = 0;
            buttonMusic.FlatStyle = FlatStyle.Flat;
            buttonMusic.Location = new Point(75, 63);
            buttonMusic.Name = "buttonMusic";
            buttonMusic.Size = new Size(200, 50);
            buttonMusic.TabIndex = 2;
            buttonMusic.UseVisualStyleBackColor = false;
            buttonMusic.Click += buttonMusic_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.menu__2_;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(350, 400);
            Controls.Add(buttonMusic);
            Controls.Add(buttonExitGame);
            Controls.Add(buttonBack);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion
        public Button buttonBack;
        public Button buttonExitGame;
        public Button buttonMusic;
    }
}