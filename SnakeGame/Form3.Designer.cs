using System.Windows.Forms;

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
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonContinue
            // 
            buttonContinue.BackColor = Color.Transparent;
            buttonContinue.FlatAppearance.BorderSize = 0;
            buttonContinue.FlatStyle = FlatStyle.Flat;
            buttonContinue.ForeColor = Color.IndianRed;
            buttonContinue.Location = new Point(-9, 388);
            buttonContinue.Margin = new Padding(0);
            buttonContinue.Name = "buttonContinue";
            buttonContinue.Size = new Size(526, 164);
            buttonContinue.TabIndex = 12;
            buttonContinue.Text = "Start";
            buttonContinue.UseVisualStyleBackColor = false;
            buttonContinue.Click += buttonContinue_Click;
            // 
            // LabelTextScreen
            // 
            LabelTextScreen.AutoSize = true;
            LabelTextScreen.BackColor = Color.Transparent;
            LabelTextScreen.ForeColor = Color.White;
            LabelTextScreen.Location = new Point(123, 86);
            LabelTextScreen.Name = "LabelTextScreen";
            LabelTextScreen.Size = new Size(254, 15);
            LabelTextScreen.TabIndex = 1;
            LabelTextScreen.Text = "Для управления змейкой используйте WASD";
            LabelTextScreen.Click += LabelTextScreen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(158, 24);
            label1.Name = "label1";
            label1.Size = new Size(183, 15);
            label1.TabIndex = 13;
            label1.Text = "Приветствуем вас в SnakeGame!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(111, 155);
            label2.Name = "label2";
            label2.Size = new Size(294, 15);
            label2.TabIndex = 14;
            label2.Text = "Для начала игры нажмите START на главном экране";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(502, 707);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonContinue);
            Controls.Add(LabelTextScreen);
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
        private Label LabelTextScreen;
        private Button buttonContinue;
        private Label label1;
        private Label label2;
    }
}