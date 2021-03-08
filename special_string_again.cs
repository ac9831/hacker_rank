using System;

namespace special_string_again
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string str = Console.ReadLine();
            char[] charAry = str.ToCharArray();
            char[] tmpAry = new char[n];
            int ret = n;
            for(int i = 0; i < n; i++)
            {
                int differentChar = -1;
                for(int j = i + 1; j < n; j++)
                {
                    if(charAry[i] == charAry[j])
                    {
                        if(differentChar == -1 || i - differentChar == differentChar - j)
                        {
                            ret++;
                        }
                    }
                    else
                    {
                        if(differentChar != -1)
                            break;

                        differentChar = j;
                    }
                }
            }

            Console.WriteLine(ret);
        }
    }
}