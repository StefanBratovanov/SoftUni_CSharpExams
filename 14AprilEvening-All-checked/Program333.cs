using System;

class Program03
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char startingLetter = Convert.ToChar(Console.ReadLine());
        int counter = 0;
        for (int i = 0; i < n; i++)
        {
            int startDotsUp = 3;
            int numberOfLettersUp = 1;


            for (int j = 0; j < 4; j++)
            {

                string dots = new string('.', startDotsUp);
                Console.Write("{0}", dots);

                //WRITE LETTERS
                for (int k = 0; k < numberOfLettersUp; k++)
                {
                    string letters = new string(startingLetter, 1);
                    Console.Write("{0}", letters);
                    startingLetter = (char)(startingLetter + 1);
                    if (startingLetter > 'G')
                    {
                        startingLetter = 'A';
                    }
                }

                Console.WriteLine("{0}", dots);
                numberOfLettersUp += 2;
                startDotsUp--;
                counter++;
                if (counter == n)
                {
                    break;
                }
            }
            if (counter == n)
            {
                break;
            }
            // bottom
            int startDots = 1;
            int numberOfLetters = 5;
            for (int j = 0; j < 3; j++)
            {
                string dots = new string('.', startDots);
                Console.Write("{0}", dots);

                //WRITE LETTERS
                for (int k = 0; k < numberOfLetters; k++)
                {
                    string letters = new string(startingLetter, 1);
                    Console.Write("{0}", letters);
                    startingLetter = (char)(startingLetter + 1);
                    if (startingLetter > 'G')
                    {
                        startingLetter = 'A';
                    }
                }

                Console.WriteLine("{0}", dots);
                numberOfLetters -= 2;
                startDots++;
                counter++;
               
                if (counter == n)
                {
                    break;
                }

            }
            if (counter == n)
            {
                break;
            }
        }

    }
}
