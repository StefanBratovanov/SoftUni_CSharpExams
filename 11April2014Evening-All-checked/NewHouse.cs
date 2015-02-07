using System;

class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i < n ; i += 2)
			{
                string dash = new string('-', (n - i) / 2);
                string star = new string('*', i);
              Console.WriteLine("{0}{1}{0}", dash, star);
			}
        string midStars = new string('*', n);
        Console.WriteLine(midStars);
        for (int i = 0; i < n; i++)
        {
            string pipe = new string('|', 1);
            string star = new string('*', n - 2);
            Console.WriteLine("{0}{1}{0}", pipe, star);
        }
       
        
    }
}

