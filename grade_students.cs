// using System;

// namespace grade_students
// {
//     class GradeStudents
//     {
//         public static void Main(string[] args)
//         {
//             int n = Int32.Parse(Console.ReadLine());
//             for(int i = 0; i < n; i++)
//             {
//                 int grade = Int32.Parse(Console.ReadLine());
//                 if(grade < 35)
//                 {
//                     Console.WriteLine(grade);
//                 }
//                 else if(grade % 5 > 2)
//                 {
//                     Console.WriteLine(grade + (5 - (grade % 5)));
//                 }
//                 else
//                 {
//                     Console.WriteLine(grade);
//                 }
//             }
//         }
//     }
// }