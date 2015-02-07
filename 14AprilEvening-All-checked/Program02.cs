using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int totalLenght = 0;
        int cableLenght = 0;
        string measurement;
        int cableCount = n;
        int studentcables = 0;
        int remainig = 0;
        int cutLenght = 0;
        for (int i = 0; i < n; i++)
        {
            cableLenght = int.Parse(Console.ReadLine());
            measurement = Console.ReadLine();
            if ((measurement == "centimeters") && cableLenght < 20)
            {
                cableLenght = 0;
                cableCount = n - 1;
            }
            else if ((measurement == "centimeters") && cableLenght >= 20)
            {
                cableLenght = cableLenght * 1;
            }
            else if (measurement == "meters")
            {
                cableLenght = cableLenght * 100;
            }
            totalLenght += cableLenght;
        }
        if ((cableCount > 1) && (totalLenght >= 507))
        {
            cutLenght = totalLenght - 3 * (cableCount - 1);
            studentcables = cutLenght / 504;
            remainig = cutLenght - (studentcables * 504);
        }
        else if ((cableCount > 1) && (totalLenght < 507))
        {
            cutLenght = totalLenght - 3 * (cableCount - 1);
            studentcables = 0;
            remainig = cutLenght - (studentcables * 504);
           // studentcables = 0;
           // remainig = totalLenght;
        }
        else if ((cableCount == 1) && (totalLenght == 504))
        {
            studentcables = 1;
            remainig = 0;
        }
        else if ((cableCount == 1) && (totalLenght > 504))
        {
            studentcables = totalLenght / 504;
            remainig = totalLenght - (studentcables * 504);
        }
        else if ((cableCount == 1) && (totalLenght < 508))
        {
            studentcables = 0;
            remainig = totalLenght;
        }
        Console.WriteLine(studentcables);
        Console.WriteLine(remainig);
    }
}
