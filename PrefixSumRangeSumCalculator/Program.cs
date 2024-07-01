using System;

namespace PrefixSumRangeSumCalculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var N = 5;
            var M = 3;
            var A = new [] { 5, 4, 3, 2, 1 };
            var S = new int[A.Length + 1];
            var i = 2;
            var j = 4;
            Console.WriteLine($"S[0]: {S[0]}");
            for (var k = 1; k <= A.Length; k++)
            {
                S[k] = S[k - 1] + A[k - 1];
                Console.WriteLine($"S[{k}]: {S[k]}");
            }

            Console.WriteLine(S[j] - S[i - 1]);
        }
    }
}