using System;
using System.Windows.Forms;

namespace ur1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
            int[] numbers = new int[10];

            numbers[0] = Convert.ToInt32(textBox1.Text);
            numbers[1] = Convert.ToInt32(textBox2.Text);
            numbers[2] = Convert.ToInt32(textBox3.Text);
            numbers[3] = Convert.ToInt32(textBox4.Text);
            numbers[4] = Convert.ToInt32(textBox5.Text);
            numbers[5] = Convert.ToInt32(textBox6.Text);
            numbers[6] = Convert.ToInt32(textBox7.Text);
            numbers[7] = Convert.ToInt32(textBox8.Text);
            numbers[8] = Convert.ToInt32(textBox9.Text);
            numbers[9] = Convert.ToInt32(textBox10.Text);

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }

            label1.Text = "Сумма всех элементов: " + sum;
        }
    }
}