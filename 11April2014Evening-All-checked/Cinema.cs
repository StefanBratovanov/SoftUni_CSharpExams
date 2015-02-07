using System;

class Cinema
{
    static void Main()
    {
        string premiera = "Premiere";
        string normal = "Normal";
        string discount = "Discount";
        string input = Console.ReadLine();
        decimal rows = decimal.Parse(Console.ReadLine());
        decimal cols = decimal.Parse(Console.ReadLine());
        decimal price = 1;

        if ((rows == 0) || (cols == 0))
        {
            Console.WriteLine("{0:f2} leva", 0);
        }

        else if (input == premiera)
        {
            price = rows * cols * 12m;
            Console.WriteLine("{0:f2} leva", price);
        }
        else if (input == normal)
        {
            price = rows * cols * 7.5m;
            Console.WriteLine("{0:f2} leva", price);
        }
        else if (input == discount)
        {
            price = rows * cols * 5m;
            Console.WriteLine("{0:f2} leva", price);
        }

    }
}
