namespace ur2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private ListBox listBox1;

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
            listBox1 = new ListBox();
            labelSize = new Label();
            SuspendLayout();

            textBox1.Location = new Point(150, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "5";

            button1.Location = new Point(128, 72);
            button1.Name = "button1";
            button1.Size = new Size(146, 30);
            button1.TabIndex = 2;
            button1.Text = "Создать и найти";
            button1.Click += button1_Click;

            label1.Font = new Font("Arial", 10F, FontStyle.Bold);
            label1.Location = new Point(50, 290);
            label1.Name = "label1";
            label1.Size = new Size(300, 50);
            label1.TabIndex = 4;
            label1.Text = "Результат: ";
            label1.TextAlign = ContentAlignment.MiddleCenter;

            listBox1.Location = new Point(50, 120);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(300, 144);
            listBox1.TabIndex = 3;

            labelSize.Location = new Point(50, 30);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(90, 20);
            labelSize.TabIndex = 0;
            labelSize.Text = "Размер массива:";

            ClientSize = new Size(382, 353);
            Controls.Add(labelSize);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Поиск максимума и минимума";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelSize;
    }
}