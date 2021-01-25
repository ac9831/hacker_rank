// using System;

// namespace hacker_rank
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int n = Convert.ToInt32(Console.ReadLine());
//             string[] c = Console.ReadLine().Split();
//             int count = 0;
//             int result = 0;

//             while(count < n - 1)
//             {
//                 if(count == n - 2)
//                 {
//                     count += 1;
//                 }
//                 else if(c[count + 2] == "0")
//                 {
//                     count += 2;
//                 }
//                 else
//                 {
//                     count += 1;
//                 }
//                 result++;
//                 Console.WriteLine(count + "/" + result);
//             }

//             Console.WriteLine(result);
//         }
//     }
// }