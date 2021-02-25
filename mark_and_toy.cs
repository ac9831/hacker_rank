// using System;

// namespace mark_and_toy
// {
//     class Programe
//     {
//         public static void ain(string[] args)
//         {
//             string[] attrs = Console.ReadLine().Split(' ');
//             int n = Int32.Parse(attrs[0]);
//             int k = Int32.Parse(attrs[1]);

//             int[] prices = Array.ConvertAll(Console.ReadLine().Split(' '), tmp => Int32.Parse(tmp));
//             Array.Sort(prices);
//             int totalPrice = 0;
//             int toyCount = 0;
//             foreach(int price in prices)
//             {
//                 totalPrice += price;
//                 if(totalPrice > k)
//                     break;

//                 toyCount++;
//             }

//             Console.WriteLine(toyCount);
//         }
//     }
// }