using System;

class Program01
{
    static void Main()
    {
        string normal = "f";
        string leap = "t";
        string input = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int homeWeekendsPlay = int.Parse(Console.ReadLine());
        int normalWeekends = 52 - homeWeekendsPlay;
        double normalWeekendsPlay = normalWeekends * (double)2 / 3;
        double holidaysPlay = (double)holidays * 0.5;
        double totalPlays = 0;
        int result = 0;
        if (input == normal)
        {
            totalPlays = homeWeekendsPlay + normalWeekendsPlay + holidaysPlay;
            result = (int)totalPlays;
        }
        else if (input == leap)
        {
            totalPlays = homeWeekendsPlay + normalWeekendsPlay + holidaysPlay + 3;
            result = (int)totalPlays;
        }
        Console.WriteLine(result);
    }
}

