namespace ur3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button button1;
        private Label label1;
        private Label label2;
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
            this.button1 = new Button();
            this.label1 = new Label();
            this.label2 = new Label();
            this.listBox1 = new ListBox();

            this.Text = "Подсчет четных и нечетных";
            this.Size = new Size(400, 350);
            this.StartPosition = FormStartPosition.CenterScreen;

            this.button1.Location = new Point(150, 30);
            this.button1.Size = new Size(100, 30);
            this.button1.Text = "Заполнить";
            this.button1.Click += new EventHandler(this.button1_Click);

            this.listBox1.Location = new Point(50, 80);
            this.listBox1.Size = new Size(300, 150);

            this.label1.Location = new Point(50, 240);
            this.label1.Size = new Size(300, 30);
            this.label1.Text = "Четных чисел: ";
            this.label1.TextAlign = ContentAlignment.MiddleLeft;
            this.label1.Font = new Font("Arial", 10, FontStyle.Regular);

            this.label2.Location = new Point(50, 270);
            this.label2.Size = new Size(300, 30);
            this.label2.Text = "Нечетных чисел: ";
            this.label2.TextAlign = ContentAlignment.MiddleLeft;
            this.label2.Font = new Font("Arial", 10, FontStyle.Regular);

            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
        }
    }
}