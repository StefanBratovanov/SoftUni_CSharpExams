using System;

class Program01
{
    static void Main()
    {
        long bund1 = long.Parse(Console.ReadLine());
        long bund2 = long.Parse(Console.ReadLine());
        long bund3 = long.Parse(Console.ReadLine());
        long bund4 = long.Parse(Console.ReadLine());
        long tableTops = long.Parse(Console.ReadLine());
        long TablesToMade = long.Parse(Console.ReadLine());
        long legasTotal = bund1 + bund2 * 2 + bund3 * 3 + bund4 * 4;
        long diff =Math.Abs(tableTops - TablesToMade);
        long tablesPossible = Math.Min(tableTops, legasTotal / 4);


        if  (tableTops < TablesToMade)
        {
            long legsNeeded = legasTotal > TablesToMade * 4 ? 0 : Math.Abs(legasTotal - TablesToMade * 4);
            Console.WriteLine("less: {0}", diff * -1);
            Console.WriteLine("tops needed: {0}, legs needed: {1}", diff, legsNeeded);
        }
        else if ((tablesPossible > TablesToMade))
        {
            long legsLeft = legasTotal > TablesToMade * 4 ? Math.Abs(legasTotal - TablesToMade * 4) : 0;
            Console.WriteLine("more: {0}", tablesPossible - TablesToMade);
            Console.WriteLine("tops left: {0}, legs left: {1}", diff, legsLeft);
        }

        else if ((tablesPossible == TablesToMade))
        {
            Console.WriteLine("Just enough tables made: {0}", TablesToMade);
        }
    }
}

