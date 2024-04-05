using System.Windows.Forms;

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
            fileSystemWatcher1 = new FileSystemWatcher();
            BackToForm1 = new Button();
            buttonMusic = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // BackToForm1
            // 
            BackToForm1.FlatAppearance.BorderSize = 0;
            BackToForm1.BackColor = Color.FromArgb(236, 108, 85);
            BackToForm1.FlatStyle = FlatStyle.Popup;
            BackToForm1.Location = new Point(75, 266);
            BackToForm1.Margin = new Padding(0);
            BackToForm1.Name = "BackToForm1";
            BackToForm1.Size = new Size(200, 50);
            BackToForm1.TabIndex = 1;
            BackToForm1.UseMnemonic = false;
            BackToForm1.UseVisualStyleBackColor = false;
            BackToForm1.Click += BackToForm1_Click;
            // 
            // buttonMusic
            // 
            buttonMusic.FlatAppearance.BorderSize = 0;
            buttonMusic.BackColor = Color.FromArgb(236, 108, 85);
            buttonMusic.FlatStyle = FlatStyle.Popup;
            buttonMusic.ForeColor = Color.Transparent;
            buttonMusic.Location = new Point(75, 131);
            buttonMusic.Margin = new Padding(0);
            buttonMusic.Name = "buttonMusic";
            buttonMusic.Size = new Size(200, 50);
            buttonMusic.TabIndex = 0;
            buttonMusic.UseMnemonic = false;
            buttonMusic.UseVisualStyleBackColor = false;
            buttonMusic.Click += Music_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.menu;
            ClientSize = new Size(350, 400);
            Controls.Add(BackToForm1);
            Controls.Add(buttonMusic);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(350, 400);
            MinimumSize = new Size(350, 400);
            Name = "Form2";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Button BackToForm1;
        private Button buttonMusic;
    }
}