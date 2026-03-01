using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ur4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] original = new int[5];

            original[0] = Convert.ToInt32(textBox1.Text);
            original[1] = Convert.ToInt32(textBox2.Text);
            original[2] = Convert.ToInt32(textBox3.Text);
            original[3] = Convert.ToInt32(textBox4.Text);
            original[4] = Convert.ToInt32(textBox5.Text);

            label1.Text = "Исходный массив: ";
            for (int i = 0; i < 5; i++)
            {
                label1.Text += original[i] + " ";
            }

            for (int i = 0; i < 5 / 2; i++)
            {
                int temp = original[i];
                original[i] = original[4 - i];
                original[4 - i] = temp;
            }

            label2.Text = "Перевернутый массив: ";
            for (int i = 0; i < 5; i++)
            {
                label2.Text += original[i] + " ";
            }
        }
    }
}