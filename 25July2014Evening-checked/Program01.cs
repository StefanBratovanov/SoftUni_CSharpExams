using System;
using System.Globalization;
class Program01
{
    static void Main()
    {
        double floors = double.Parse(Console.ReadLine());
        double flats = double.Parse(Console.ReadLine());
        string inputTime = Console.ReadLine();
        TimeSpan inputTimeOfDay;
        inputTimeOfDay = TimeSpan.Parse(inputTime);
        double consumption = 0L;
       

        TimeSpan durMorning = new TimeSpan(8, 59, 0);
        TimeSpan endMorning = durMorning.Duration();

        TimeSpan earlyDayBegin = new TimeSpan(9, 0, 0);
        TimeSpan earlyDayEnd = new TimeSpan(13, 59, 0);

        TimeSpan midDayBegin = new TimeSpan(14, 0, 0);
        TimeSpan midDayEnd = new TimeSpan(18, 59, 0);

        TimeSpan eveningBegin = new TimeSpan(19, 0, 0);
        TimeSpan eveningDayEnd = new TimeSpan(23, 59, 0);

        


        if (inputTimeOfDay < endMorning)
        {
            flats = (flats * (100.53 + 8 * 125.90));
            consumption = (int)(floors * flats);
            Console.WriteLine("{0} Watts", consumption);
        }
        else if ((inputTimeOfDay >= earlyDayBegin) && (inputTimeOfDay <= earlyDayEnd))
        {
            Console.WriteLine("0 Watts");
        }
        else if ((inputTimeOfDay >= midDayBegin) && (inputTimeOfDay <= midDayEnd))
        {
            flats = (flats * (2 * 100.53 + 2 * 125.90));
            consumption = (int)(floors * flats);
            Console.WriteLine("{0} Watts", consumption);
        }
        else if ((inputTimeOfDay >= eveningBegin) && (inputTimeOfDay <= eveningDayEnd))
        {
            flats = (flats * (7 * 100.53 + 6 * 125.90));
            consumption = (int)(floors * flats);
            Console.WriteLine("{0} Watts", consumption);
        }


    }
}
