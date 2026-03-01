using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ur6
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

            listBox1.Items.Clear();

            for (int i = 0; i < 10; i++)
            {
                bool alreadyCounted = false;
                for (int k = 0; k < i; k++)
                {
                    if (numbers[k] == numbers[i])
                    {
                        alreadyCounted = true;
                        break;
                    }
                }

                if (!alreadyCounted)
                {
                    int count = 0;
                    for (int j = 0; j < 10; j++)
                    {
                        if (numbers[j] == numbers[i])
                        {
                            count++;
                        }
                    }

                    listBox1.Items.Add($"Число {numbers[i]} встречается {count} раз(а)");
                }
            }
        }
    }
}
