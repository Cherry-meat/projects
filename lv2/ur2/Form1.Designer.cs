namespace ur2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();

            textBox1.Location = new Point(50, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 27);
            textBox1.TabIndex = 2;
            textBox1.UseSystemPasswordChar = true;

            button1.Location = new Point(140, 140);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 3;
            button1.Text = "Проверить";
            button1.Click += button1_Click;

            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(25, 40);
            label1.Name = "label1";
            label1.Size = new Size(236, 34);
            label1.TabIndex = 0;
            label1.Text = "Введите пароль:";

            label2.Font = new Font("Arial", 8F, FontStyle.Italic);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(25, 74);
            label2.Name = "label2";
            label2.Size = new Size(326, 23);
            label2.TabIndex = 1;
            label2.Text = "(минимум 8 символов, нужна хотя бы 1 цифра)";

            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Arial", 10F);
            label3.Location = new Point(50, 188);
            label3.Name = "label3";
            label3.Size = new Size(280, 148);
            label3.TabIndex = 4;
            label3.Text = "Результат проверки:";
            label3.TextAlign = ContentAlignment.MiddleLeft;

            ClientSize = new Size(382, 380);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Проверка пароля";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}