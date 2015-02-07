using System;

class Program
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int[] points = new int[10];
        bool inOne; bool inTwo; bool inside;
        for (int i = 0; i <= 9; i++)
        {
            points[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int j = 0; j <= 9; j += 2)
        {
            inOne = ((points[j] >= 0 && points[j] <= 3 * h)) && ((points[j + 1] >= 0 && points[j + 1] <= h));
            inTwo = ((points[j] >= h && points[j] <= 2 * h)) && ((points[j + 1] >= h && points[j + 1] <= 4 * h));
            if (inside = (inOne || inTwo))
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }

}
