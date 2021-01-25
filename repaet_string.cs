/* using System;

namespace hacker_rank
{
    class Program
    {
        static void Main(string[] args) {
            string s = Console.ReadLine();
            Int64 n = Convert.ToInt64(Console.ReadLine());
            Int64 substring_find_a = 0;
            Int64 ret = 0;

            foreach(char c in s.ToCharArray())
            {
                if(c == 'a')
                    substring_find_a++;
            }

            Int64 repeatNum = n / s.Length;
            ret += repeatNum * substring_find_a;

            for(int i = 0; i < n % s.Length; i++)
            {
                if(s.ToCharArray()[i] == 'a')
                    ret++;
            }

            Console.WriteLine(ret);
        }
    }
} */