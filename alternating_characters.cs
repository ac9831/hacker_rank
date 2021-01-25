//using System;
//namespace hacker_rank
//{
//    public class alternating_characters
//    {
//        public static void Main(string[] args)
//        {

//            int q = Int32.Parse(Console.ReadLine());
//            for(int i = 0; i < q; i++)
//            {
//                char[] s = Console.ReadLine().ToCharArray();
//                int ret = 0;
//                int s_length = s.Length;

//                for(int j = 0; j < s_length-1; j++)
//                {
//                    if (s[j] == s[j + 1])
//                        ret++;
//                }

//                Console.WriteLine(ret);
//            }
//        }
//    }
//}
