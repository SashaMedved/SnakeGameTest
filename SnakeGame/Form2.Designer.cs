﻿namespace SnakeGame
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
            buttonBack.Location = new Point(35, 302);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonExitGame
            // 
            buttonExitGame.Location = new Point(222, 302);
            buttonExitGame.Name = "buttonExitGame";
            buttonExitGame.Size = new Size(75, 23);
            buttonExitGame.TabIndex = 1;
            buttonExitGame.Text = "exit";
            buttonExitGame.UseVisualStyleBackColor = true;
            buttonExitGame.Click += buttonExitGame_Click;
            // 
            // buttonMusic
            // 
            buttonMusic.Location = new Point(132, 81);
            buttonMusic.Name = "buttonMusic";
            buttonMusic.Size = new Size(75, 23);
            buttonMusic.TabIndex = 2;
            buttonMusic.Text = "music";
            buttonMusic.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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