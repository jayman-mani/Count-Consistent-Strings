using System;

namespace CountConsistentStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string allowed = "ab";
            string[] words = new string[] { "ad", "bd", "aaab", "baa", "badab" };
            var solution = new Solution();
            int result = solution.CountConsistentStrings(allowed, words);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        int[] table = new int[201];
        public int CountConsistentStrings(string allowed, string[] words)
        {
            int count = 0;            
            for (int i = 0; i < allowed.Length; i++)
            {
                table[allowed[i]] = allowed[i];
            }

            for (int i = 0; i < words.Length; i++)
            {
                count += checkWordAllowed(words[i]);
            }


            return count;
        }

        private int checkWordAllowed(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (table[input[i]] != input[i])
                    return 0;                
            }

            return 1;
        }
    }
}
