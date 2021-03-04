// using System;
// using System.Collections.Generic;

// namespace luck_blance
// {
//     class Program
//     {
//         public static void Main(string[] args)
//         {
//             string[] str = Console.ReadLine().Split(' ');
//             int n = Convert.ToInt32(str[0]);
//             int k = Convert.ToInt32(str[1]);
//             int[] L = new int[n];
//             int[] T = new int[n];
//             List<int> M = new List<int>();

//             for(int i = 0; i < n; i++)
//             {
//                 string[] inputData = Console.ReadLine().Split(' ');
//                 L[i] = Convert.ToInt32(inputData[0]);
//                 T[i] = Convert.ToInt32(inputData[1]);
//             }

//             int calK = 0;
//             int totalResult = 0;
//             int mCount = 0;
//             for(int i = 0; i < n; i++)
//             {
//                 if(T[i] == 0)
//                 {
//                     totalResult += L[i];
//                 }
//                 else
//                 {
//                     totalResult += L[i];
//                     M.Add(L[i]);
//                     mCount++;
//                     calK++;
//                 }
//             }

//             if(calK > k)
//             {
//                 M.Sort();
//                 for(int i = 0; i < calK - k; i++)
//                 {
//                     totalResult -= M[i] * 2;
//                 }
//             }

//             Console.WriteLine(totalResult);
//         }
//     }
// }