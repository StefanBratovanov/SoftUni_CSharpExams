using System;

class Program51
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        string inputBits = "";
        int counter = 0;
        for (int i = 0; i < n; i++)
        {
            inputBits += Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(8, '0');
        }
        string resulBits = "";
        int index = 1;

        for (int j = 0; j < inputBits.Length; j++)
        {
            if (j == index)
            {
                index += step;
            }
            else
            {
                    resulBits += inputBits[j];
            }
        }
        if (resulBits.Length %8 !=0)
        {
            resulBits += new String('0',8 - (resulBits.Length % 8));
            
        }
        for (int i = 0; i < resulBits.Length; i += 8)
        {
            string EightBitss = resulBits.Substring(i, 8);
            Console.WriteLine(Convert.ToInt32(EightBitss, 2));
        }
       
        
    }
}

