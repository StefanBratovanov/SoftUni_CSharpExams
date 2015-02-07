using System;
using System.Numerics;
class Program01
{
    static void Main()
    {
        int X = int.Parse(Console.ReadLine());
        int Y = int.Parse(Console.ReadLine());
        int number = int.Parse(Console.ReadLine());
        int index = 0;
        double value = 0;
        if (X == 0 && Y == 0)
        {
            index = 1;
            value = number;
        }
        else if ((X == 1 && Y == 0))
        {
            index = 2;
            value = number +1 ;
        }
        else if ((X == 2 && Y == 0))
        {
            index = 3;
            value = number + 2;
        }
        else if ((X == 0 && Y == 1))
        {
            index = 4;
            value = number + 3;
        }
        else if ((X == 1 && Y == 1))
        {
            index = 5;
            value = number + 4;
        }
        else if ((X == 2 && Y == 1))
        {
            index = 6;
            value = number + 5;
        }
        else if ((X == 0 && Y == 2))
        {
            index = 7;
            value = number + 6;
        }
        else if ((X == 1 && Y == 2))
        {
            index = 8;
            value = number + 7;
        }
        else if ((X == 2 && Y == 2))
        {
            index = 9;
            value = number + 8;
        }

        BigInteger result = (BigInteger)Math.Pow(value, index);
        Console.WriteLine(result);

    }
}

