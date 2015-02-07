using System;

class Exam2
{
    static void Main()
    {
        string hours = Console.ReadLine();
        string minutes = Console.ReadLine();
        string tmieOfDay = Console.ReadLine();
        int durationHours = int.Parse(Console.ReadLine());
        int durationMins = int.Parse(Console.ReadLine());

        string input;
        DateTime startingTime;

        input = hours + " : " + minutes + " " + tmieOfDay;
        startingTime = DateTime.Parse(input);

        TimeSpan duration = TimeSpan.FromHours(durationHours).Add(TimeSpan.FromMinutes(durationMins));
        DateTime endExam = startingTime.Add(duration);
        string result = endExam.ToString("hh:mm:tt");
        Console.WriteLine(result);
    }
}

