namespace ur3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBox1;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();

            textBox1.Location = new Point(134, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 27);
            textBox1.TabIndex = 1;

            button1.Location = new Point(125, 175);
            button1.Name = "button1";
            button1.Size = new Size(150, 30);
            button1.TabIndex = 5;
            button1.Text = "Конвертировать";
            button1.Click += button1_Click;

            radioButton1.Location = new Point(97, 90);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(189, 24);
            radioButton1.TabIndex = 3;
            radioButton1.Text = "Цельсий > Фаренгейт";

            radioButton2.Location = new Point(97, 120);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(189, 27);
            radioButton2.TabIndex = 4;
            radioButton2.Text = "Фаренгейт > Цельсий";

            label1.Location = new Point(114, 20);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите температуру:";

            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 2;

            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(50, 220);
            label3.Name = "label3";
            label3.Size = new Size(300, 58);
            label3.TabIndex = 7;
            label3.Text = "Результат:";
            label3.TextAlign = ContentAlignment.MiddleCenter;

            ClientSize = new Size(382, 287);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(radioButton1);
            Controls.Add(radioButton2);
            Controls.Add(button1);
            Controls.Add(label3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Термометр";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}