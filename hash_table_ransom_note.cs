//using System;
//using System.Collections.Generic;

//namespace hash_table_ransom_note
//{
//    class RansomNote
//    {
//        public static void Main(string[] args)
//        {
//            string[] twoSpace = Console.ReadLine().Split(' ');
//            int m = Int32.Parse(twoSpace[0]);
//            int n = Int32.Parse(twoSpace[1]);

//            string magazine = Console.ReadLine();
//            string note = Console.ReadLine();

//            Dictionary<string, int> magazineDic = new Dictionary<string, int>();

//            bool ret = true;

//            foreach (string word in magazine.Split(' '))
//            {
//                if (!magazineDic.ContainsKey(word))
//                {
//                    magazineDic.Add(word, 1);
//                }
//                else
//                {
//                    magazineDic[word]++;
//                }

//            }

//            foreach (string word in note.Split(' '))
//            {
//                if (magazineDic.ContainsKey(word) && magazineDic[word] > 0)
//                {
//                    magazineDic[word]--;
//                }
//                else
//                {
//                    ret = false;
//                    break;
//                }
//            }

//            if (ret)
//            {
//                Console.WriteLine("Yes");
//            }
//            else
//            {
//                Console.WriteLine("No");
//            }
//        }
//    }
//}