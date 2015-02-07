using System;

class TheExplorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
         
        for (int i = 0; i < 1; i++)
        {
            string dash = new string('-', n / 2);
            string star = new string('*', 1);
            Console.WriteLine("{0}{1}{0}", dash, star);
        }
        for (int i = n / 2 - 1, j = 1; i >= 0; i--, j+=2)
        {
            string dash = new string('-', i);
            string star = new string('*', 1);
            string middleDash = new string('-', j);
            Console.WriteLine("{0}{1}{2}{1}{0}", dash, star, middleDash);
        }

        for (int  j = 1; j < n/2 ; j ++)
        {
            string dash = new string('-', j);
            string star = new string('*', 1);
            string middleDash = new string('-', n - 2 - 2 * j);
            Console.WriteLine("{0}{1}{2}{1}{0}", dash, star, middleDash);
        }

        Console.WriteLine("{0}{1}{0}", new string('-', n / 2), new string('*', 1));

    }
}
