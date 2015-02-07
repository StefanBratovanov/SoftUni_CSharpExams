using System;

class Program
{
    static void Main()
    {
        string inputYear = Console.ReadLine();
        int contractMonth = int.Parse(Console.ReadLine());
        int familyMonth = int.Parse(Console.ReadLine());

        int contractFlys = 4 * 3 * contractMonth;
        int familyFlys = 2 * 2 * familyMonth;
        double normalFlys = (12 - contractMonth - familyMonth) * 12 * 3 / 5.0;
        double totalFlys = contractFlys + familyFlys + normalFlys;
        if (inputYear=="leap")
        {
            totalFlys = totalFlys * 1.05;
            Console.WriteLine((int)totalFlys);
        }
        else if (inputYear == "normal")
        {
            Console.WriteLine((int)totalFlys);
        }
    }
}

