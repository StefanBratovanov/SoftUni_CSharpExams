using System;

class Program
{
    static void Main()
    {
        int inputStart = int.Parse(Console.ReadLine());
        int inputEnd = int.Parse(Console.ReadLine());
        int magicWeight = int.Parse(Console.ReadLine());
        int weight = 0;
        DateTime start = new DateTime(inputStart, 1, 1);
        DateTime end = new DateTime(inputEnd, 12, 31);
        Console.WriteLine(start.ToString("dd-MM-yyyy"));
        Console.WriteLine(end.ToString("dd-MM-yyyy"));

        for (DateTime i = start; i <= end; i = i.AddDays(1))
        {
            string dateFirst = i.Day.ToString();
            Console.WriteLine(dateFirst);
        }
    }
}

