// using System;
// using System.Collections.Generic;

// namespace hacker_rank
// {
    // public class sherlock_anagrams
    // {
    //     public static void Main(string[] args)
    //     {

    //         int q = Int32.Parse(Console.ReadLine());
    //         for(int i = 0; i < q; i++)
    //         {
    //             Dictionary<string, int> orgAlphabat = new Dictionary<string, int>();
    //             int ret = 0;
    //             char[] s = Console.ReadLine().ToCharArray();
    //             for(int j = 0; j < s.Length; j++)
    //             {
    //                 for(int k=j+1; k < s.Length + 1; k++)
    //                 {
    //                     char[] org = new char[k - j];
    //                     Array.Copy(s, j, org, 0, k - j);
    //                     Array.Sort(org);
    //                     string orgStr = new string(org);
    //                     if(orgAlphabat.ContainsKey(orgStr))
    //                     {
    //                         ret += orgAlphabat[orgStr];
    //                         orgAlphabat[orgStr]++;
    //                     }
    //                     else
    //                     {
    //                         orgAlphabat.Add(orgStr, 1);
    //                     }
    //                 }
    //             }
    //             Console.WriteLine(ret);
    //         }
    //     }




        //// Complete the sherlockAndAnagrams function below.
        //static int sherlockAndAnagrams(string s)
        //{
        //    int ret = 0;
        //    char[] arrayChr = s.ToCharArray();
        //    for (int j = 0; j < arrayChr.Length - 1; j++)
        //    {
        //        for (int k = 0; k < arrayChr.Length - 1; k++)
        //        {
        //            for (int l = k + 1; l < arrayChr.Length - j; l++)
        //            {
        //                char[] org = new char[j + 1];
        //                char[] anagrams = new char[j + 1];
        //                Array.Copy(arrayChr, k, org, 0, j + 1);
        //                Array.Copy(arrayChr, l, anagrams, 0, j + 1);
        //                ret += anagramsCal(org, anagrams);
        //            }
        //        }
        //    }

        //    return ret;
        //}

        //static int anagramsCal(char[] org, char[] anagrams)
        //{
        //    Dictionary<char, int> orgAlphabat = new Dictionary<char, int>();

        //    foreach (char c in org)
        //    {
        //        if (orgAlphabat.ContainsKey(c))
        //            orgAlphabat[c]++;
        //        else
        //            orgAlphabat.Add(c, 1);
        //    }

        //    foreach (char c in anagrams)
        //    {
        //        if (orgAlphabat.ContainsKey(c))
        //            if (orgAlphabat[c] == 0)
        //                return 0;
        //            else
        //                orgAlphabat[c]--;
        //        else
        //            return 0;
        //    }

        //    return 1;
        //}

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int q = Convert.ToInt32(Console.ReadLine());

        //    for (int qItr = 0; qItr < q; qItr++)
        //    {
        //        string s = Console.ReadLine();

        //        int result = sherlockAndAnagrams(s);

        //        textWriter.WriteLine(result);
        //    }

        //    textWriter.Flush();
        //    textWriter.Close();
        //}
//     }
// }
