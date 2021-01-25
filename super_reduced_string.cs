// using System;
// using System.Text;

// namespace super_reduced_string
// {
//     public class super_reduced_string
//     {
//         public static void Main(string[] args)
//         {
//             string s = Console.ReadLine();
//             StringBuilder ret = new StringBuilder();
//             char[] charArray = s.ToCharArray();

//             for(int i = 0; i < charArray.Length; i++)
//             {
//                 if(i == 0)
//                 {
//                     ret.Append(charArray[i]);
//                 }
//                 else
//                 {
//                     if(ret.ToString().EndsWith(charArray[i]))
//                     {
//                         ret.Length--;
//                     }
//                     else
//                     {
//                         ret.Append(charArray[i]);
//                     }
//                 }
//             }

//             if(ret.Length == 0)
//                 Console.WriteLine("Empty String");
//             else
//                 Console.Write(ret.ToString());

//         }
//     }
// }