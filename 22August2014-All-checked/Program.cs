using System;

class Program02
{
    static void Main()
    {
        double numOrders = double.Parse(Console.ReadLine());
        double packets = 0;
        double booksPerPacket = 0;
        double price = 0;
        double totalBooks = 0;
        double discount = 0;
        double allBooksCost = 0;

        for (double i = 0; i < numOrders; i++)
        {
            packets = double.Parse(Console.ReadLine());
            booksPerPacket = double.Parse(Console.ReadLine());
            price = double.Parse(Console.ReadLine());

            if (packets < 10)
            {
                discount = 0;
            }
            else if ((packets >= 10) && (packets < 110))
            {
                discount = (int)(packets / 10) + 4;
            }
            else
            {
                discount = 15;
            }

            totalBooks += packets * booksPerPacket;
            allBooksCost += (price - price * discount * 0.01) * (packets * booksPerPacket);
        }
        Console.WriteLine(totalBooks);
        Console.WriteLine("{0:f2}", allBooksCost);
    }
}

