namespace ur1
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
        private Label label1;

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
            this.label1 = new Label();

            this.Text = "Сумма элементов массива";
            this.Size = new Size(400, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            this.textBox1.Location = new Point(30, 30);
            this.textBox1.Size = new Size(60, 20);
            this.textBox1.Text = "0";

            this.textBox2.Location = new Point(100, 30);
            this.textBox2.Size = new Size(60, 20);
            this.textBox2.Text = "0";

            this.textBox3.Location = new Point(170, 30);
            this.textBox3.Size = new Size(60, 20);
            this.textBox3.Text = "0";

            this.textBox4.Location = new Point(240, 30);
            this.textBox4.Size = new Size(60, 20);
            this.textBox4.Text = "0";

            this.textBox5.Location = new Point(310, 30);
            this.textBox5.Size = new Size(60, 20);
            this.textBox5.Text = "0";

            this.textBox6.Location = new Point(30, 70);
            this.textBox6.Size = new Size(60, 20);
            this.textBox6.Text = "0";

            this.textBox7.Location = new Point(100, 70);
            this.textBox7.Size = new Size(60, 20);
            this.textBox7.Text = "0";

            this.textBox8.Location = new Point(170, 70);
            this.textBox8.Size = new Size(60, 20);
            this.textBox8.Text = "0";

            this.textBox9.Location = new Point(240, 70);
            this.textBox9.Size = new Size(60, 20);
            this.textBox9.Text = "0";

            this.textBox10.Location = new Point(310, 70);
            this.textBox10.Size = new Size(60, 20);
            this.textBox10.Text = "0";

            this.button1.Location = new Point(150, 120);
            this.button1.Size = new Size(100, 30);
            this.button1.Text = "Вычислить сумму";
            this.button1.Click += new EventHandler(this.button1_Click);

            this.label1.Location = new Point(30, 170);
            this.label1.Size = new Size(340, 50);
            this.label1.Text = "Сумма: ";
            this.label1.TextAlign = ContentAlignment.MiddleCenter;
            this.label1.Font = new Font("Arial", 10, FontStyle.Bold);

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
            this.Controls.Add(this.label1);
        }
    }
}