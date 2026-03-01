using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace ur3
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[15];
            int evenCount = 0;
            int oddCount = 0;

            listBox1.Items.Clear();
            for (int i = 0; i < 15; i++)
            {
                numbers[i] = random.Next(10, 51); 
                listBox1.Items.Add(numbers[i]);
            }

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            label1.Text = "Четных чисел: " + evenCount;
            label2.Text = "Нечетных чисел: " + oddCount;
        }
    }
}