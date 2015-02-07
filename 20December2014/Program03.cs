using System;

class Program03
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n / 2; i++)
        {
            string dots = new string('.', n - 1 - 2 * i);
            string stars = new string('*', 1 + i * 2);
            string sailDots = new string('.', n);
            Console.WriteLine("{0}{1}{2}", dots, stars, sailDots);
        }
        for (int i = 0; i < 1; i++)
        {
            string stars = new string('*', n);
            string sailDots = new string('.', n);
            Console.WriteLine("{0}{1}", stars, sailDots);
        }
        for (int i = 0; i < n / 2; i++)
        {
            string dots = new string('.', 2 + 2 * i);
            string stars = new string('*', n - 2 - 2 * i);
            string sailDots = new string('.', n);
            Console.WriteLine("{0}{1}{2}", dots, stars, sailDots);
        }
        for (int i = 0; i < (n - 1) / 2; i++)
        {
            string dots = new string('.', i);
            string stars = new string('*', 2 * n - 2 * i);
            Console.WriteLine("{0}{1}{0}", dots, stars);
        }

    }
}
