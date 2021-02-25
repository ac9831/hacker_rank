// using System;

// namespace minimum_absolute_difference_in_an_array
// {
//     class Program
//     {
//         public static void Main(string[] args)
//         {
//             int n = Convert.ToInt32(Console.ReadLine());
//             int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

//             Array.Sort(arr);
//             int minimum = int.MaxValue;
//             for(int i = 0; i < arr.Length - 1; i++)
//             {
//                 if(minimum > Math.Abs(arr[i] - arr[i + 1]))
//                 {
//                     minimum = Math.Abs(arr[i] - arr[i + 1]);
//                 }
//             }

//             Console.WriteLine(minimum);
//         }
//     }
// }