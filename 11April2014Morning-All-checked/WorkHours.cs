using System;

class WorkHours
{
    static void Main()
    {
        int requaredHoures = int.Parse(Console.ReadLine());
        int daysAvailable = int.Parse(Console.ReadLine());
        int percent = int.Parse(Console.ReadLine());
        double workTime = (daysAvailable - daysAvailable * 0.1) * 12 ;
        int efficientWork = (int)(workTime * (percent * 0.01));
        if (efficientWork >= requaredHoures)
        {
            Console.WriteLine("Yes");
            Console.WriteLine(efficientWork - requaredHoures);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine(efficientWork - requaredHoures);
        }
    }
}
