// using System;

// namespace strong_password
// {
//     public class strong_password
//     {
//         public static void Main(string[] args)
//         {
//             const int Length = 6;
//             const int Contain = 4;
//             int n = Int32.Parse(Console.ReadLine());
//             string password = Console.ReadLine();
//             char[] passwordChars = password.ToCharArray();
//             bool[] checks = new bool[4];
//             int contains = 0;
//             int passwordLength = passwordChars.Length;
//             int ret;

//             foreach(char c in passwordChars)
//             {
//                 checks[CheckCharacter(c)] = true;
//             }

//             foreach(bool check in checks)
//             {
//                 if(check)
//                     contains++;
//             }

//             if(passwordLength >= Length && contains == Contain)
//             {
//                 ret = 0;
//             }
//             else
//             {
//                 ret = Math.Max(Length - passwordLength, Contain - contains);
//             }

//             Console.WriteLine(ret);
//         }

//         public static int CheckCharacter(char c)
//         {
//             if(c >= '0' && c <= '9') return 0;
//             else if(c >= 'a' && c <= 'z') return 1;
//             else if(c >= 'A' && c <= 'Z') return 2;
//             else return 3;
//         }
//     }
// }