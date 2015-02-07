using System;

class Program03
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < 1; i++)
        {
            string dashes = new string('-', (n - 1) / 2);
            string stars = new string('*', n + 2);
            Console.WriteLine("{0}{1}{0}", dashes, stars);
        }

        for (int i = 0; i < n - 1; i++)
        {
            string dashes = new string('-', (n - 1) / 2);
            string stars = new string('*', 1);
            string mid = new string('-', n);
            Console.WriteLine("{0}{1}{2}{1}{0}", dashes, stars, mid);
        }
        for (int i = 0; i < n / 2 + 1; i++)
        {
            string dashes = new string('-', (n / 2 - i));
            string stars = new string('*', 1 + i * 2);
            string mid = new string('-', n - 2 * i);
            Console.WriteLine("{0}{1}{2}{1}{0}", dashes, stars, mid);
        }
        for (int i = 0; i < n / 2; i++)
        {
            string dashes = new string('-', 1 + i);
            string stars = new string('*', (n - 2 - 2 * i));
            string mid = new string('-', 3 + i * 2);
            Console.WriteLine("{0}{1}{2}{1}{0}", dashes, stars, mid);

        }
    }
}

