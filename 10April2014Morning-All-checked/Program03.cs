using System;

class Program03
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < 1; i++)
        {
            string stars = new string('*', 2 * n);
            string empty = new string(' ', n);
            Console.WriteLine("{0}{1}{0}", stars, empty);
        }

        for (int i = 0; i < n / 2 - 1; i++)
        {
            string star = new string('*', 1);
            string middleSlash = new string('/', 2 * n - 2);
            string empty = new string(' ', n);
            Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", star, middleSlash, empty);
        }
        for (int i = 0; i < 1; i++)
        {
            string star = new string('*', 1);
            string middleSlash = new string('/', 2 * n - 2);
            string pipe = new string('|', n);
            Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", star, middleSlash, pipe);
        }
        for (int i = 0; i < n / 2 - 1; i++)
        {
            string star = new string('*', 1);
            string middleSlash = new string('/', 2 * n - 2);
            string empty = new string(' ', n);
            Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", star, middleSlash, empty);
        }
        for (int i = 0; i < 1; i++)
        {
            string stars = new string('*', 2 * n);
            string empty = new string(' ', n);
            Console.WriteLine("{0}{1}{0}", stars, empty);
        }

    }
}
