using System;

namespace Amazon_CutOffRank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(cutOffRank(3, new int[] { 100, 75,50, 50, 25 }));
        }

        static int cutOffRank(int cutOff, int[] scores)
        {

            int[] freq = new int[100001];
            int max = int.MinValue;
            foreach(int score in scores)
            {
                freq[score]++;
                if (max < score) 
                    max = score;
            }

            int i = max, res = 0, rank = 1;
            while (i >= 0 && rank <= cutOff)
            {
                if (freq[i] != 0)
                {
                    res += freq[i];
                    rank += freq[i];
                }
                i--;
            }
            return res;
        }
    }
}
