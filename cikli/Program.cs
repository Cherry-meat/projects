    internal class Program
    {
        static void Main(string[] args)
        {
            //1 решение
            for (int i = 11; i < 20; i = i + 2)
            {
                Console.WriteLine(i);
            }
            
            //2 решение
            int count = 0;
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

            //3 решение
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            for (int i = 0; i < n; i++)
            {
                x += n;
            }
            Console.Write(x);
            
            //4 решение
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }

        //5 решение
            Console.WriteLine("Введите пароль(12345)");
            while (true)
            {
                try
                {
                    int password = int.Parse(Console.ReadLine());
                    if (password == 12345)
                    {
                        Console.WriteLine("Верный пароль");
                        break;  
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
        }

        //6 решение
        Console.WriteLine("Введите число:");
            string input = Console.ReadLine();
            int sum = 0;

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    int digit = int.Parse(c.ToString());
                    sum += digit * digit;
                }
            }

            Console.WriteLine($"Сумма квадратов цифр: {sum}");
            Console.ReadKey();
        }
    }