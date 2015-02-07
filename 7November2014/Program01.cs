using System;

class Program01
{
    static void Main()
    {
        int moneyForTheMonth = int.Parse(Console.ReadLine());
        int weekDaysOut = int.Parse(Console.ReadLine());
        int weekendsHomeTown = int.Parse(Console.ReadLine());

        int expensesNormalW = ((4 - weekendsHomeTown) * 2) * 20;

        int totalWeekdays = 30 - 8;
        int normalWeekdays = totalWeekdays - weekDaysOut;


        int normalDaysExpence = normalWeekdays * 10;
        int rent = 150;
        int outDaysExpence = weekDaysOut * ((int)((double)3 / 100 * moneyForTheMonth) + 10);

        int expensesTotal = expensesNormalW + outDaysExpence + normalDaysExpence + rent;
        int diff = Math.Abs(expensesTotal - moneyForTheMonth);
        if (expensesTotal < moneyForTheMonth)
        {
            Console.WriteLine("Yes, leftover {0}.", diff);
        }
        else if (expensesTotal > moneyForTheMonth)
        {
            Console.WriteLine("No, not enough {0}.", diff);
        }
        else
            Console.WriteLine("Exact Budget.");
    }
}

