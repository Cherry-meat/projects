namespace ur4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Label label1;
        private Label label2;

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
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.textBox3 = new TextBox();
            this.textBox4 = new TextBox();
            this.textBox5 = new TextBox();
            this.button1 = new Button();
            this.label1 = new Label();
            this.label2 = new Label();

            this.Text = "Реверс массива";
            this.Size = new Size(400, 250);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label labelEnter = new Label();
            labelEnter.Location = new Point(30, 10);
            labelEnter.Size = new Size(100, 20);
            labelEnter.Text = "Введите 5 чисел:";

            this.textBox1.Location = new Point(30, 40);
            this.textBox1.Size = new Size(50, 20);
            this.textBox1.Text = "1";

            this.textBox2.Location = new Point(90, 40);
            this.textBox2.Size = new Size(50, 20);
            this.textBox2.Text = "2";

            this.textBox3.Location = new Point(150, 40);
            this.textBox3.Size = new Size(50, 20);
            this.textBox3.Text = "3";

            this.textBox4.Location = new Point(210, 40);
            this.textBox4.Size = new Size(50, 20);
            this.textBox4.Text = "4";

            this.textBox5.Location = new Point(270, 40);
            this.textBox5.Size = new Size(50, 20);
            this.textBox5.Text = "5";

            this.button1.Location = new Point(150, 80);
            this.button1.Size = new Size(100, 30);
            this.button1.Text = "Реверс";
            this.button1.Click += new EventHandler(this.button1_Click);

            this.label1.Location = new Point(30, 130);
            this.label1.Size = new Size(330, 30);
            this.label1.Text = "Исходный массив: ";
            this.label1.TextAlign = ContentAlignment.MiddleLeft;

            this.label2.Location = new Point(30, 170);
            this.label2.Size = new Size(330, 30);
            this.label2.Text = "Перевернутый массив: ";
            this.label2.TextAlign = ContentAlignment.MiddleLeft;

            this.Controls.Add(labelEnter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
        }
    }
}