//using System;
//using System.Collections.Generic;

//namespace hacker_rank
//{
//    public class two_string
//    {
//        public static void Main(string[] args)
//        {
//            int p = Int32.Parse(Console.ReadLine());
//            for(int i = 0; i < p; i++)
//            {
//                bool isRet = false;
//                Dictionary<char, int> sDic = new Dictionary<char, int>();

//                string s1 = Console.ReadLine();
//                foreach(char c in s1.ToCharArray())
//                {
//                    if(!sDic.ContainsKey(c))
//                        sDic.Add(c, 1);
//                }

//                string s2 = Console.ReadLine();
//                foreach(char c in s2.ToCharArray())
//                {
//                    if (sDic.ContainsKey(c))
//                        isRet = true;
//                }

//                if(isRet)
//                {
//                    Console.WriteLine("YES");
//                }
//                else
//                {
//                    Console.WriteLine("NO");
//                }
//            }
//        }
//    }
//}
