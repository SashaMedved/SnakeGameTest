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
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonContinue
            // 
            buttonContinue.BackColor = Color.Transparent;
            buttonContinue.FlatAppearance.BorderSize = 0;
            buttonContinue.FlatStyle = FlatStyle.Popup;
            buttonContinue.ForeColor = Color.IndianRed;
            buttonContinue.Location = new Point(152, 358);
            buttonContinue.Margin = new Padding(0);
            buttonContinue.Name = "buttonContinue";
            buttonContinue.Size = new Size(200, 50);
            buttonContinue.TabIndex = 12;
            buttonContinue.UseVisualStyleBackColor = false;
            buttonContinue.Click += buttonContinue_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(54, 116);
            label3.Name = "label3";
            label3.Size = new Size(254, 15);
            label3.TabIndex = 1;
            label3.Text = "Для управления змейкой используйте WASD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(79, 62);
            label1.Name = "label1";
            label1.Size = new Size(180, 15);
            label1.TabIndex = 13;
            label1.Text = "Приветствуем вас в SnakeGame";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(31, 174);
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
            BackgroundImage = Properties.Resources.playForm;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(502, 707);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonContinue);
            Controls.Add(label3);
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
        private Label label3;
        private Button buttonContinue;
        private Label label1;
        private Label label2;
    }
}