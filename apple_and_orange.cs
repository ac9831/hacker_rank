// using System;
// using System.Collections.Generic;

// namespace apple_and_orange
// {
//     public class apple_and_orange
//     {
//         public static void Main(string[] args)
//         {
//             int[] sams = Array.ConvertAll(Console.ReadLine().Split(' '), tmp => Int32.Parse(tmp));
//             int[] trees = Array.ConvertAll(Console.ReadLine().Split(' '), tmp => Int32.Parse(tmp));
//             int[] apple_orange = Array.ConvertAll(Console.ReadLine().Split(' '), tmp => Int32.Parse(tmp));

//             int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), tmp => Int32.Parse(tmp));
//             int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), tmp => Int32.Parse(tmp));

//             int[] apple_location = new int[apple_orange[0]];
//             int[] orange_location = new int[apple_orange[1]];

//             int apple_result = 0;
//             int orange_result = 0;

//             for(int a = 0; a < apple_orange[0]; a++)
//             {
//                 int location = trees[0] + apples[a];
//                 if(sams[0] <= location && location <= sams[1])
//                     apple_result++;
//             }

//             for(int o = 0; o < apple_orange[1]; o++)
//             {
//                 int location = trees[1] + oranges[o];
//                 if(sams[0] <= location && location <= sams[1])
//                     orange_result++;
//             }

//             Console.WriteLine(apple_result);
//             Console.WriteLine(orange_result);
//         }
//     }
// }