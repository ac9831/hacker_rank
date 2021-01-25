//using System;
//using System.Collections.Generic;

//namespace MakingAnagrams
//{
//    public class MakingAnagrams
//    {
//        public static void Main(string[] args)
//        {
//            string a = Console.ReadLine();
//            string b = Console.ReadLine();

//            Dictionary<char, int> dic = new Dictionary<char, int>();
//            foreach (var c in a.ToCharArray())
//            {
//                if(!dic.ContainsKey(c))
//                {
//                     dic.Add(c, 1);
//                }
//                else
//                {
//                    dic[c]++;
//                }
//            }

//            int ret = a.ToCharArray().Length + b.ToCharArray().Length;
//            foreach (var c in b.ToCharArray())
//            {
//                if(dic.ContainsKey(c))
//                {
//                    if(dic[c] > 1)
//                    {
//                        dic[c]--;
//                    }
//                    else
//                    {
//                        dic.Remove(c);
//                    }
//                    ret -= 2;
//                }
//            }

//            Console.WriteLine(ret);
//        }
//    }
//}