using System;

class Program01
{
    static void Main()
    {
        int priceTank = int.Parse(Console.ReadLine());
        int partyDays = int.Parse(Console.ReadLine());

        int savings = (30 - partyDays) * 2 - partyDays * 5;
        int neededMonths = (int)Math.Ceiling(priceTank * 1.0 / savings);
        if (savings<=0)
        {
            Console.WriteLine("never");
        }
        else
        {
            int years = neededMonths / 12;
            int months = neededMonths - years * 12;
            Console.WriteLine("{0} years, {1} months", years,months);
        }
    }
}

