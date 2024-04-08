namespace SnakeGame
{
    partial class DeadForm
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
            buttonExitFull = new Button();
            buttonRestart = new Button();
            SuspendLayout();
            // 
            // buttonExitFull
            // 
            buttonExitFull.BackColor = Color.FromArgb(236, 108, 85);
            buttonExitFull.FlatAppearance.BorderSize = 0;
            buttonExitFull.FlatStyle = FlatStyle.Flat;
            buttonExitFull.Location = new Point(74, 310);
            buttonExitFull.Name = "buttonExitFull";
            buttonExitFull.Size = new Size(200, 50);
            buttonExitFull.TabIndex = 1;
            buttonExitFull.UseVisualStyleBackColor = false;
            buttonExitFull.Click += buttonExitFull_Click;
            // 
            // buttonRestart
            // 
            buttonRestart.BackColor = Color.FromArgb(236, 108, 85);
            buttonRestart.FlatAppearance.BorderSize = 0;
            buttonRestart.FlatStyle = FlatStyle.Flat;
            buttonRestart.Location = new Point(74, 167);
            buttonRestart.Name = "buttonRestart";
            buttonRestart.Size = new Size(200, 50);
            buttonRestart.TabIndex = 2;
            buttonRestart.UseVisualStyleBackColor = false;
            // 
            // DeadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.deadForm__2_;
            ClientSize = new Size(350, 400);
            Controls.Add(buttonRestart);
            Controls.Add(buttonExitFull);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeadForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeadForm";
            ResumeLayout(false);
        }

        #endregion

        public Button buttonExitFull;
        public Button buttonRestart;
    }
}