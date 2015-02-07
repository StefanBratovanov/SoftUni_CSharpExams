using System;

class Program02
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int countNumbersInSet = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();

        string Odd = "odd";
        string Even = "even";

        int oddCount = 0;
        int evenCount = 0;
        int maxOdd = int.MinValue;
        int maxEven = int.MinValue;
        int maxName = 0;

        string[] names = { "First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh", "Eight", "Ninth", "Tenth" };
        //  int [];

        if (input == Odd)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < countNumbersInSet; j++)
                {
                    int number = int.Parse(Console.ReadLine());
                    if (number % 2 == 1)
                    {
                        oddCount++;
                    }
                }
                if (oddCount > maxOdd)
                {
                    maxOdd = oddCount;
                    maxName = i;
                }
                oddCount = 0;
            }

            if (maxOdd > 0)
            {
                Console.WriteLine("{0} set has the most odd numbers: {1}", names[maxName], maxOdd);
            }
            if (maxOdd < 1)
            {
                Console.WriteLine("No");
            }

        }
        else if (input == Even)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < countNumbersInSet; j++)
                {
                    int number = int.Parse(Console.ReadLine());
                    if (number % 2 == 0)
                    {
                        evenCount++;
                    }
                }
                if (evenCount > maxEven)
                {
                    maxEven = evenCount;
                    maxName = i;
                }
                evenCount = 0;
            }
            if (maxEven > 0)
            {
                Console.WriteLine("{0} set has the most even numbers: {1}", names[maxName], maxEven);
            }
            if (maxEven < 1)
            {
                Console.WriteLine("No");
            }

        }
    }
}

