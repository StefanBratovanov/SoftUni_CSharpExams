using System;

class ExamSchedule
{
    static void Main()
    {
        DateTime startingTime;
        string input;

        string hours = Console.ReadLine();
        string minutes = Console.ReadLine();
        string tmieOfDay = Console.ReadLine();
        string durationHours = Console.ReadLine();
        string durationMins = Console.ReadLine();

        input = hours + " : " + minutes + " " + tmieOfDay;
        startingTime = DateTime.Parse(input);



        double longDuration = double.Parse(durationHours);
        TimeSpan durationH = TimeSpan.FromHours(longDuration);
        double longMins = double.Parse(durationMins);
        TimeSpan durationM = TimeSpan.FromMinutes(longMins);
        TimeSpan durationExam = durationH.Add(durationM);

        Console.WriteLine(startingTime);
        Console.WriteLine(durationExam);
        DateTime endExam = startingTime.Add(durationExam);
        Console.WriteLine(endExam);


    }
}
