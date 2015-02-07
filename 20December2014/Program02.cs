using System;

class Program02
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        long startNumVertical = long.Parse(Console.ReadLine());
        long startNumHorizon = long.Parse(Console.ReadLine());

        string line = "";
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write((startNumVertical + i) * (startNumHorizon + j));
                if (j < cols - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}

/* for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write((startNumVertical + i) * (startNumHorizon + j) + " ");
            }
            Console.WriteLine();
        }*/