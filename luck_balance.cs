using System;

namespace luck_blance
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            int[] L = new int[n];
            int[] T = new int[n];

            for(int i = 0; i < n; i++)
            {
                string[] inputData = Console.ReadLine();
                L[i] = Convert.ToInt32(inputData[0]);
                T[i] = Convert.ToInt32(inputData[1]);
            }
        }
    }
}