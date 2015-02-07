using System;

class CarNumbers
{
    static void Main()
    {
        int weight = int.Parse(Console.ReadLine());
        int magic = weight - 40;
        int counter = 0;
        if (weight <= 40)
        {
            Console.WriteLine("Not a valid number:");
        }
        else
        {
            for (int a = 0; a <= 9; a++)
            {
                for (int b = 0; b <= 9; b++)
                {
                    for (int i = 1, x = 0; i <= 10; i++)
                    {
                        switch (i)
                        {
                            case 1: x = 10; break;
                            case 2: x = 20; break;
                            case 3: x = 30; break;
                            case 4: x = 50; break;
                            case 5: x = 80; break;
                            case 6: x = 110; break;
                            case 7: x = 130; break;
                            case 8: x = 160; break;
                            case 9: x = 200; break;
                            case 10: x = 240; break;
                        }
                        for (int j = 1, y = 0; j <= 10; j++)
                        {
                            switch (j)
                            {
                                case 1: y = 10; break;
                                case 2: y = 20; break;
                                case 3: y = 30; break;
                                case 4: y = 50; break;
                                case 5: y = 80; break;
                                case 6: y = 110; break;
                                case 7: y = 130; break;
                                case 8: y = 160; break;
                                case 9: y = 200; break;
                                case 10: y = 240; break;
                            }
                            if (a + a + a + a + x + y == magic)
                            {
                                counter ++;
                            }
                            if (a + a + a + b + x + y == magic)
                            {
                                counter ++;
                                if (a == b)
                                {
                                    counter -= 1;
                                }
                            }
                            if (a + a + b + b + x + y == magic)
                            {
                                counter ++;
                                if (a == b)
                                {
                                    counter -= 4;
                                }
                            }
                            if (a + b + b + b + x + y == magic)
                            {
                                counter ++;
                                if (a == b)
                                {
                                    counter -= 1;
                                }
                            }
                            if (a + b + a + b + x + y == magic)
                            {
                                counter ++;
                                if (a == b)
                                {
                                    counter -= 4;
                                }
                            }
                            if (a + b + b + a + x + y == magic)
                            {
                                counter ++;
                                if (a == b)
                                {
                                    counter -=4;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
