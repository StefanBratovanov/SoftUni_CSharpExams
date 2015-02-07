using System;

class Program02
{
    static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        int secondNumber = input.Length;
        int sumDecimal = 0;
        for (int i = 0; i < secondNumber; i++)
        {
            if (input[i] >= 'a' && input[i] <= 'z')
            {
                sumDecimal += input[i] - 'a' + 1;
            }
            else if (input[i] >= 'A' && input[i] <= 'Z')
            {
                sumDecimal += input[i] - 'A' + 1;
            }
            else
            {
                sumDecimal += input[i];
            }
        }
        string thirdNumReversed = "";
        for (int i = sumDecimal, j = sumDecimal; i > 0; i = j)
        {
            i %= key;
            j /= key;
            thirdNumReversed += i;
        }
        char[] thirdNumber = new char[thirdNumReversed.Length];
        for (int i = 0; i < thirdNumber.Length; i++)
        {
            thirdNumber[i] = thirdNumReversed[thirdNumReversed.Length - i - 1];
        }
        string finalPart = new string(thirdNumber);
        string codedAnswer = "" + key + secondNumber + finalPart;
        Console.WriteLine(codedAnswer);
    }
}

