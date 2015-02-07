using System;

class Program04
{
    static void Main()
    {
        int w = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int cardFace = 1; cardFace < 11; cardFace++)
        {
            for (int suit1 = 1; suit1 < 5; suit1++)
            {
                for (int suit2 = 1; suit2 < 5; suit2++)
                {
                    for (int suit3 = 1; suit3 < 5; suit3++)
                    {
                        for (int suit4 = 1; suit4 < 5; suit4++)
                        {
                            for (int suit5 = 1; suit5 < 5; suit5++)
                            {
                             int straightWeight = CalculateHandWeight(cardFace, suit1, suit2, suit3, suit4, suit5);
                                
                                if (straightWeight == w)
                                {
                                    counter++;
                                }
                              
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(counter);
    }

    private static int CalculateHandWeight(int cardFace, int suit1, int suit2, int suit3, int suit4, int suit5)
    {
        int calcWeight = (10 * cardFace + suit1) + (20 * (cardFace + 1) + suit2) + (30 * (cardFace + 2) + suit3) +
        (40*(cardFace + 3) + suit4) + (50*(cardFace + 4) + suit5) ;
        return calcWeight;
    }
}

