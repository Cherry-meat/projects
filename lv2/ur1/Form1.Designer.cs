namespace ur1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBox1;
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
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(180, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(140, 80);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 2;
            button1.Text = "Рассчитать";
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Location = new Point(50, 40);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите сумму покупки:";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Arial", 10F);
            label2.Location = new Point(50, 130);
            label2.Name = "label2";
            label2.Size = new Size(300, 115);
            label2.TabIndex = 3;
            label2.Text = "Результат:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            ClientSize = new Size(382, 272);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Калькулятор скидок";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}