using System;

class Program05
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int firstNumber = int.Parse(Console.ReadLine());
        int rightDiagonalCouples = 0;
        int leftDiagonalCouples = 0;
        int verticallCouples = 0;
        for (int i = 0; i < n - 1; i++)
        {
            int secondNumber = int.Parse(Console.ReadLine());
            for (int j = 0; j < 32; j++)
            {
                int maskFirst = firstNumber >> j;
                int maskSecond = secondNumber >> j;
                if (((1 & maskFirst) == 1) && ((1 & maskSecond) == 1))
                {
                    verticallCouples++;
                }
                if (((1 & maskFirst) == 1) && ((1 & (secondNumber >> (j+1))) == 1))
                {
                    leftDiagonalCouples++;
                }
                if (((1 & maskFirst) == 1) && ((1 & (secondNumber >> (j - 1))) == 1))
                {
                    rightDiagonalCouples++;
                }
            }
            firstNumber = secondNumber;
        }

        Console.WriteLine(rightDiagonalCouples);
        Console.WriteLine(leftDiagonalCouples);
        Console.WriteLine(verticallCouples);
       
    }
}

