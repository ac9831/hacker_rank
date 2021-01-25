/* using System;
using System.Collections.Generic;

namespace hacker_rank
{
    class Program
    {
        static void Main(string[] args)
        {
            int ret = 0;
            int socks = Convert.ToInt32(Console.ReadLine());
            string[] sock_ary = Console.ReadLine().Split();
            Dictionary<int, int> dic_sock = new Dictionary<int, int>();
            foreach (var item in sock_ary)
            {
                int key = Convert.ToInt32(item);
                if(dic_sock.ContainsKey(key))
                {
                    dic_sock[key] = ++dic_sock[key];
                }
                else
                {
                    dic_sock.Add(key, 1);
                }
            }

            foreach (var item in dic_sock)
            {
                ret += item.Value / 2;
            }
            Console.WriteLine(ret);
        }
    }
}
 */