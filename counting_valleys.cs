/* using System;

namespace hacker_rank
{
    class Program
    {
        static void Main(string[] args)
        {
            int step = Convert.ToInt32(Console.ReadLine());
            char[] paths = Console.ReadLine().ToCharArray();
            int deeper = 0;
            int[] hiking = new int[2];
            int ret = 0;
            foreach(char path in paths)
            {
                if(path == 'U')
                {
                    deeper += 1;
                    if(deeper == 0)
                    {
                        ret++;
                    }
                }
                else if(path == 'D')
                {
                    deeper -= 1;
                }
            }
            Console.WriteLine(ret);
        }
    }
} */