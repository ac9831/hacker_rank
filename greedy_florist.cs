// using System;

// namespace greedy_florist
// {
//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//             string[] inputStr = Console.ReadLine().Split(' ');
//             int n = Convert.ToInt32(inputStr[0]);
//             int k = Convert.ToInt32(inputStr[1]);

//             int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), arrTmp => Convert.ToInt32(arrTmp));
//             Array.Sort(c);
//             Array.Reverse(c);
//             long ret = 0;
//             int num = 0;
//             foreach(int item in c)
//             {
//                 int multiple = num / k + 1;
//                 ret += item * multiple;
//                 num++;
//             }

//             Console.WriteLine(ret);
//         }
//     }
// }