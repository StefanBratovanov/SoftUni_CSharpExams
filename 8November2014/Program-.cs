using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter your number: ");
        int number = int.Parse(Console.ReadLine());

        if (number == 1)
        {
            Console.WriteLine("This number is prime = False");
        }
        else
        {
            int primeCount = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    primeCount++;
                }
            }

            bool isPrime = true;

            if (primeCount > 2)
            {
                isPrime = false;
            }
            Console.WriteLine("This number is prime = " + isPrime);
        }

    }
}