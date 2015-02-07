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
        int counter = 0;

        for (DateTime i = start; i <= end; i = i.AddDays(1))
        {
            int dateFirst = int.Parse(i.Day.ToString("00").Substring(0, 1));
            int dateSecond = int.Parse(i.Day.ToString("00").Substring(1, 1));

            int monthFirst = int.Parse(i.Month.ToString("00").Substring(0, 1));
            int monthSecond = int.Parse(i.Month.ToString("00").Substring(1, 1));

            int yearFirst = int.Parse(i.Year.ToString("0000").Substring(0, 1));
            int yearSecond = int.Parse(i.Year.ToString("0000").Substring(1, 1));
            int yearThird = int.Parse(i.Year.ToString("0000").Substring(2, 1));
            int yearFourth = int.Parse(i.Year.ToString("0000").Substring(3, 1));

            weight = dateFirst * dateSecond + dateFirst * monthFirst + dateFirst * monthSecond + dateFirst * yearFirst + dateFirst * yearSecond + dateFirst * yearThird + dateFirst * yearFourth +
            dateSecond * monthFirst + dateSecond * monthSecond + dateSecond * yearFirst + dateSecond * yearSecond + dateSecond * yearThird + dateSecond * yearFourth +
            monthFirst * monthSecond + monthFirst * yearFirst + monthFirst * yearSecond + monthFirst * yearThird + monthFirst * yearFourth +
            monthSecond * yearFirst + monthSecond * yearSecond + monthSecond * yearThird + monthSecond * yearFourth +
            yearFirst * yearSecond + yearFirst * yearThird + yearFirst * yearFourth +
            yearSecond * yearThird + yearSecond * yearFourth +
            yearThird * yearFourth;
            if (weight == magicWeight)
            {
                Console.WriteLine(i.ToString("dd-MM-yyyy"));
                counter++;
            }
        }
        if (counter<1)
        {
            Console.WriteLine("No");
        }
    }
}

