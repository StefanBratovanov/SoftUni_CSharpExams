using System;

class WineGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string slash = new string('\\', 1); 
        string backslash = new string('/', 1);
        for (int i = n - 2, counter = 0; i >= 0; i -= 2, counter++)
        {
            string askerisk = new string('*', i);
            string dots = new string('.', counter);
            Console.WriteLine("{0}{1}{2}{3}{0}", dots, slash, askerisk, backslash);
        }
        string chair = new string('|', 2);

        if (n >= 12)
        {
            for (int i = 0; i < n / 2 - 2; i++)
            {
                
                string dotsChair = new string('.', n / 2 - 1 );
                Console.WriteLine("{0}{1}{0}", dotsChair, chair);
            }

            for (int i = 0; i < 2; i++)
            {
                string dashes = new string('-', n);
                Console.WriteLine("{0}", dashes);
            }
        }
        else
        {
            for (int i = 0; i < n / 2 - 1; i++)
            {
                string dotsChair = new string('.', n / 2 - 1);
                Console.WriteLine("{0}{1}{0}", dotsChair, chair);
            }
            for (int i = 0; i < 1; i++)
            {
                string dashes = new string('-', n);
                Console.WriteLine("{0}", dashes);
            }
        }
    }
}


