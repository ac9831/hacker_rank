// using System;

// namespace left_rotation
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string[] input_nd = Console.ReadLine().Split(' ');
//             int n = Int32.Parse(input_nd[0]);
//             int d = Int32.Parse(input_nd[1]);

//             int[] input_array = Array.ConvertAll(Console.ReadLine().Split(' '), tmp => Int32.Parse(tmp));
//             int[] result_array = new int[n];

//             d = d % n;
//             for(int i = 0; i < input_array.Length; i++)
//             {
//                 int rotation = (i + d) % n;
//                 Console.WriteLine(rotation);

//                 result_array[i] = input_array[rotation];
//             }

//             Console.WriteLine(string.Join(" ", result_array));
//         }
//     }
// }