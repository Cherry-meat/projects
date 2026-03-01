using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ur5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[5];

            numbers[0] = Convert.ToInt32(textBox1.Text);
            numbers[1] = Convert.ToInt32(textBox2.Text);
            numbers[2] = Convert.ToInt32(textBox3.Text);
            numbers[3] = Convert.ToInt32(textBox4.Text);
            numbers[4] = Convert.ToInt32(textBox5.Text);

            label1.Text = "Исходный массив: ";
            for (int i = 0; i < 5; i++)
            {
                label1.Text += numbers[i] + " ";
            }

            int last = numbers[4];

            for (int i = 4; i > 0; i--)
            {
                numbers[i] = numbers[i - 1];
            }

            numbers[0] = last;

            label2.Text = "После сдвига: ";
            for (int i = 0; i < 5; i++)
            {
                label2.Text += numbers[i] + " ";
            }
        }
    }
}