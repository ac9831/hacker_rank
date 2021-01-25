/* using System;

namespace new_year_choase
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Int32.Parse(Console.ReadLine());
            for(int i=0;i<t;i++)
            {

                int ret = 0;
                int n = Int32.Parse(Console.ReadLine());
                int[] people = Array.ConvertAll(Console.ReadLine().Split(' '), tmp => Int32.Parse(tmp));
                bool isChaotic = false;
                for(int j = n - 1; j > -1; j--)
                {
                    if(people[j] != j + 1)
                    {
                        if(((j - 1) >= 0) && people[j - 1] == (j + 1))
                        {
                            ret++;
                            int tmp = people[j-1];
                            people[j - 1] = people[j];
                            people[j] = tmp;
                        }
                        else if(((j - 2) >= 0) && people[j-2] == (j + 1)) {
                            ret += 2;
                            people[j-2] = people[j-1];
                            people[j-1] = people[j];
                            people[j] = j + 1;
                        } else {
                            isChaotic = true;
                            break;
                        }

                    }

                }

                if(isChaotic)
                {
                    Console.WriteLine("Too chaotic");
                }
                else
                {
                    Console.WriteLine(ret);
                }

            }
        }
    }
} */