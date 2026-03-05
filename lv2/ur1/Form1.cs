using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ur1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double CalculateDiscount(double purchaseAmount)
        {
            if (purchaseAmount < 1000)
            {
                return 0; 
            }
            else if (purchaseAmount >= 1000 && purchaseAmount <= 5000)
            {
                return 5; 
            }
            else
            {
                return 10; 
            }
        }

        private double CalculateFinalPrice(double purchaseAmount, double discount)
        {
            return purchaseAmount - (purchaseAmount * discount / 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double purchaseAmount = Convert.ToDouble(textBox1.Text);
            double discount = CalculateDiscount(purchaseAmount);
            double finalPrice = CalculateFinalPrice(purchaseAmount, discount);
            label2.Text = $"Сумма покупки: {purchaseAmount} руб.\n" +
                         $"Скидка: {discount}%\n" +
                         $"Итоговая сумма: {finalPrice} руб.";
        }
    }
}