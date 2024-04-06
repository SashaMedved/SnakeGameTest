namespace SnakeGame
{
    partial class Form3
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
            buttonContinue = new Button();
            LabelTextScreen = new Label();
            SuspendLayout();
            // 
            // buttonContinue
            // 
            buttonContinue.Location = new Point(177, 517);
            buttonContinue.Name = "buttonContinue";
            buttonContinue.Size = new Size(120, 63);
            buttonContinue.TabIndex = 0;
            buttonContinue.Text = "continue";
            buttonContinue.UseVisualStyleBackColor = true;
            buttonContinue.Click += buttonContinue_Click;
            // 
            // LabelTextScreen
            // 
            LabelTextScreen.AutoSize = true;
            LabelTextScreen.BackColor = SystemColors.ActiveBorder;
            LabelTextScreen.Location = new Point(123, 71);
            LabelTextScreen.Name = "LabelTextScreen";
            LabelTextScreen.Size = new Size(254, 15);
            LabelTextScreen.TabIndex = 1;
            LabelTextScreen.Text = "Для управления змейкой используйте WASD";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(502, 707);
            Controls.Add(LabelTextScreen);
            Controls.Add(buttonContinue);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Opacity = 0.9D;
            RightToLeft = RightToLeft.No;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonContinue;
        private Label LabelTextScreen;
    }
}