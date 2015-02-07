using System;

class Triangle
{
    static void Main()
    {
        double aX = double.Parse(Console.ReadLine());
        double aY = double.Parse(Console.ReadLine());
        double bX = double.Parse(Console.ReadLine());
        double bY = double.Parse(Console.ReadLine());
        double cX = double.Parse(Console.ReadLine());
        double cY = double.Parse(Console.ReadLine());

        double sideA = Math.Sqrt(Math.Pow((bX - cX), 2) + Math.Pow((bY - cY), 2));
        double sideB = Math.Sqrt(Math.Pow((aX - cX), 2) + Math.Pow((aY - cY), 2));
        double sideC = Math.Sqrt(Math.Pow((aX - bX), 2) + Math.Pow((aY - bY), 2));

        if (sideA + sideB == sideC)
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:n2}", sideC);
        }
        else if (sideA + sideC == sideB)
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:n2}", sideC);
        }
        else if (sideB + sideC == sideA)
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:n2}", sideC);
        }
        else 
        {
            Console.WriteLine("Yes");
            double p = Math.Abs((sideA + sideB + sideC) / 2);
            double area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            Console.WriteLine("{0:f2}", area);
        }
    }
}