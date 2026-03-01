namespace ur6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private Button button1;
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
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.textBox3 = new TextBox();
            this.textBox4 = new TextBox();
            this.textBox5 = new TextBox();
            this.textBox6 = new TextBox();
            this.textBox7 = new TextBox();
            this.textBox8 = new TextBox();
            this.textBox9 = new TextBox();
            this.textBox10 = new TextBox();
            this.button1 = new Button();
            this.listBox1 = new ListBox();

            this.Text = "Подсчет дубликатов";
            this.Size = new Size(450, 400);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label labelEnter = new Label();
            labelEnter.Location = new Point(30, 10);
            labelEnter.Size = new Size(200, 20);
            labelEnter.Text = "Введите 10 чисел:";

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

            this.textBox6.Location = new Point(330, 40);
            this.textBox6.Size = new Size(50, 20);
            this.textBox6.Text = "6";

            this.textBox7.Location = new Point(30, 80);
            this.textBox7.Size = new Size(50, 20);
            this.textBox7.Text = "7";

            this.textBox8.Location = new Point(90, 80);
            this.textBox8.Size = new Size(50, 20);
            this.textBox8.Text = "8";

            this.textBox9.Location = new Point(150, 80);
            this.textBox9.Size = new Size(50, 20);
            this.textBox9.Text = "9";

            this.textBox10.Location = new Point(210, 80);
            this.textBox10.Size = new Size(50, 20);
            this.textBox10.Text = "10";

            this.button1.Location = new Point(170, 120);
            this.button1.Size = new Size(100, 30);
            this.button1.Text = "Посчитать";
            this.button1.Click += new EventHandler(this.button1_Click);

            this.listBox1.Location = new Point(30, 170);
            this.listBox1.Size = new Size(380, 180);

            this.Controls.Add(labelEnter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
        }
    }
}