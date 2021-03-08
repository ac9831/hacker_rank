// using System;

// namespace max_min
// {
//     class Program
//     {
//         public static void Main(string[] args)
//         {
//             int n = Convert.ToInt32(Console.ReadLine());
//             int k = Convert.ToInt32(Console.ReadLine());

//             int[] arr = new int[n];
//             for(int i = 0; i < n; i++)
//             {
//                 arr[i] = Convert.ToInt32(Console.ReadLine());
//             }
//             Array.Sort(arr);

//             int min = int.MaxValue;
//             for(int i = 0; i < n - k + 1; i++)
//             {
//                 if(min > arr[i+k-1] - arr[i])
//                 {
//                     min = arr[i+k-1] - arr[i];
//                 }
//             }

//             Console.WriteLine(min);
//         }
//     }
// }