using System.Text;

namespace LeetCode75
{
    // 1768. Merge Strings Alternately
    public class Solution
    {
        public string MergeAlternately(string word1, string word2)
        {
            StringBuilder sb = new StringBuilder();

            int firstString = word1.Length;
            int secondString = word2.Length;

            int i = 0;
            while (i < firstString || i < secondString) 
            {
                if (i < firstString)
                {
                    sb.Append(word1[i]);
                }

                if (i < secondString)
                {
                    sb.Append(word2[i]);
                }
                i++;
            }

            return sb.ToString();
        }

        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            var result = solution.MergeAlternately("abc", "pqrst");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}