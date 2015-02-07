using System;

class Bits
{
    static void Main()
    {
        ulong input = ulong.Parse(Console.ReadLine());
        ulong deadBits = 0;

        for (int i = 0; i < 3; i++)
        {
            string[] shootParams = Console.ReadLine().Split(' ');
            ulong[] numberParamsShoot = new ulong[shootParams.Length];
            int centerShot = int.Parse(shootParams[0]);
            int sizeShot = int.Parse(shootParams[1]);
            int startShoot = centerShot - sizeShot / 2;
            int endShoot = centerShot + sizeShot / 2;

            for (int bitToShoot = startShoot; bitToShoot <= endShoot; bitToShoot++)
            {
                if ((bitToShoot >= 0) && (bitToShoot <= 63))
                {
                    ulong mask = ((ulong)1 << bitToShoot);
                    deadBits = deadBits | mask;
                }
            }
        }
        ulong result = input & (~deadBits);
        
        int counterRight = 0;
        int counterLeft = 0;

        for (int i = 0; i < 32; i++)
        {

            if (((result >> i) & 1) == 1)
            {
                counterRight++;
            }
        }
        for (int i = 32; i < 64; i++)
        {

            if (((result >> i) & 1) == 1)
            {
                counterLeft++;
            }
        }
        Console.WriteLine("left: {0}",counterLeft);
        Console.WriteLine("right: {0}",counterRight);
    }
}

