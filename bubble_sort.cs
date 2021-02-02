// using System;

// namespace bubble_sort
// {
//     public class Programe
//     {
//         public static void Main(string[] args)
//         {
//             int n = Int32.Parse(Console.ReadLine());
//             int[] list = Array.ConvertAll(Console.ReadLine().Split(' '), tmp => Int32.Parse(tmp));

//             int ret = 0;
//             for(int i=0;i < n; i++)
//             {
//                 for(int j=0; j < n-1; j++)
//                 {
//                     if(list[j] > list[j+1])
//                     {
//                         swap(j, j+1, list);
//                         ret++;
//                     }
//                 }
//             }

//             Console.WriteLine(string.Format("Array is sorted in {0} swaps.", ret));
//             Console.WriteLine(string.Format("First Element: {0}", list[0]));
//             Console.WriteLine(string.Format("Last Element: {0}", list[n-1]));
//         }

//         public static void swap(int idx, int nextIdx, int[] list)
//         {
//             int tmp = list[idx];
//             list[idx] = list[nextIdx];
//             list[nextIdx] = tmp;
//         }
//     }
// }