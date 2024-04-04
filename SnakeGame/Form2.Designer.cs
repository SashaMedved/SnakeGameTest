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
            Music = new Button();
            BackToForm1 = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Music
            // 
            Music.Location = new Point(119, 66);
            Music.Name = "Music";
            Music.Size = new Size(75, 23);
            Music.TabIndex = 0;
            Music.Text = "muzik";
            Music.UseVisualStyleBackColor = true;
            Music.Click += Music_Click;
            // 
            // BackToForm1
            // 
            BackToForm1.Location = new Point(124, 237);
            BackToForm1.Name = "BackToForm1";
            BackToForm1.Size = new Size(75, 23);
            BackToForm1.TabIndex = 1;
            BackToForm1.Text = "back";
            BackToForm1.UseVisualStyleBackColor = true;
            BackToForm1.Click += BackToForm1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 361);
            Controls.Add(BackToForm1);
            Controls.Add(Music);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Button BackToForm1;
        private Button Music;
    }
}