using System;

    class Problem01
    {
        static void Main()
        {
            string normalYear = "normal";
            string leapYear = "leap";
            string inputYear = Console.ReadLine();
            int numberHolidays = int.Parse(Console.ReadLine());
            int weekendsHome = int.Parse(Console.ReadLine());
            double volleyWeekendsPlay = 0.75*(48 - weekendsHome);
            double holidaysPlay = numberHolidays * ((double)2 / 3);
            double totalPlays = 0;
            if (inputYear == normalYear)
            {
                totalPlays = (int)(weekendsHome + volleyWeekendsPlay + holidaysPlay);
                Console.WriteLine(totalPlays);
            }
            else if (inputYear == leapYear)
            {
                totalPlays = (int)(weekendsHome + volleyWeekendsPlay + holidaysPlay + (0.15 * (weekendsHome + volleyWeekendsPlay + holidaysPlay)));
                Console.WriteLine(totalPlays);
            }
        }
    }