// using System;
// namespace hacker_rank
// {
//     public class sherlock_valid_string
//     {
//         public static void Main(string[] args)
//         {
//             string s = Console.ReadLine();
//             int[] nums = new int[26];

//             foreach(char c in s.ToCharArray())
//             {
//                 nums[c - 'a']++;
//             }

//             Array.Sort(nums);

//             int nextIdx = -1;
//             bool isYes = false;
//             int min = -1;
//             int max = nums[25];

//             for(int i = 0; i < 26; i++)
//             {

//                 if (nums[i] == 0)
//                     continue;

//                 if (min == -1)
//                 {
//                     min = nums[i];
//                     nextIdx = i + 1;
//                 }


//                 if (min == max)
//                 {
//                     isYes = true;
//                     break;
//                 }


//                 if (min == 1 && nums[nextIdx] == max)
//                 {
//                     isYes = true;
//                     break;
//                 }


//                 if (max - min == 1 && max > nums[24])
//                 {
//                     isYes = true;
//                     break;
//                 }

//             }

//             if (isYes)
//                 Console.WriteLine("YES");
//             else
//                 Console.WriteLine("NO");
//         }
//     }
// }
