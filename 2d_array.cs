// using System;
// using System.Linq;

// namespace twod_array
// {
//     class Program
//     {
//         static void Main(string[] args) {
//             int[][] twod_array = new int[6][];
//             string[] input_array = new string[6];
//             int max = -64;
//             int sum = 0;

//             for (int i = 0; i < 6; i++) {
//                 twod_array[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
//             }

//             for(int i=0; i < 4; i++) {
//                 for(int j=0; j < 4; j++) {
//                     sum = twod_array[i][j] + twod_array[i][j+1] + twod_array[i][j+2] + twod_array[i+1][j+1] + twod_array[i+2][j] + twod_array[i+2][j+1] + twod_array[i+2][j+2];
//                     if(sum > max) {
//                         max = sum;
//                     }
//                 }
//             }

//             Console.WriteLine(max);
//         }
//     }
// }