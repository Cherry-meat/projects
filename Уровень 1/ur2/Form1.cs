using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ur2
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
            int N = Convert.ToInt32(textBox1.Text);
            int[] numbers = new int[N];

            listBox1.Items.Clear();
            for (int i = 0; i < N; i++)
            {
                numbers[i] = random.Next(1, 101); 
                listBox1.Items.Add(numbers[i]);
            }

            int max = numbers[0];
            int min = numbers[0];
            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 0; i < N; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                    maxIndex = i;
                }

                if (numbers[i] < min)
                {
                    min = numbers[i];
                    minIndex = i;
                }
            }

            label1.Text = $"Максимум: {max} (индекс {maxIndex}), Минимум: {min} (индекс {minIndex})";
        }
    }
}