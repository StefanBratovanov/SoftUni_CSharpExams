using System;

class LongestWord
{
    static void Main()
    {
        string word = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        string[] letters = new string[word.Length];
        for (int i = 0; i < letters.Length; i++)
        {
            letters[i] = word.Substring(i, 1);
        }

        string[] fullWord = new string[n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < letters.Length; j++)
            {
                Console.Write(word.Substring(j, 1));
            }
            Console.WriteLine();
        }
       
    }
}

