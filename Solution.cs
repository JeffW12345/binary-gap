// Solution to the challenge at https://app.codility.com/programmers/lessons/1-iterations/binary_gap/

namespace CodilityChallenges
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Solution
    {
        public static int solution(int N)
        {
            string asBinary = Convert.ToString(N, 2);
            List<int> numZeros = new List<int>();
            int count = 0;
            for (int i = 0; i < asBinary.Length; i++)
            {
                if (asBinary[i] == '0')
                {
                    count++;
                }
                if (asBinary[i] == '1')
                {
                    numZeros.Add(count);
                    count = 0;
                }
            }
            return numZeros.Max();
        }


        public static void Main(string[] args)
        {
            Console.WriteLine(solution(1041));
        }
    }
}
