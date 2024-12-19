using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //Console.WriteLine("Enter Number");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 3 == 0 && number % 4 ==0)
            //    Console.WriteLine("yes");
            //else if (number % 4 == 0)
            //    Console.WriteLine("yes");
            //else
            //    Console.WriteLine("No");



            #endregion

            #region Q2

            // Console.WriteLine("Enter Number");
            // int number = int.Parse(Console.ReadLine());
            // switch (number)
            // {
            //     case > 0:
            //         Console.WriteLine("positive");
            //         break;
            //     default:
            //         Console.WriteLine("negative");
            //         break;
            // }

            #endregion

            #region Q3
            //Console.WriteLine("Enter Number");
            //int A = int.Parse(Console.ReadLine());
            //int B = int.Parse(Console.ReadLine());
            //int C = int.Parse(Console.ReadLine());

            //if (A > B && A > C)
            //    Console.WriteLine($"max element {A}");
            //else if (B > A && B > C)
            //    Console.WriteLine($"max element {B}");
            //else if (C > A && C > B)
            //    Console.WriteLine($"max element {C}");
            //if (A < B && A < C)
            //    Console.WriteLine($"min element {A}");
            //else if (B < A && B < C)
            //    Console.WriteLine($"min element {B}");
            //else if (C < A && C < B)
            //    Console.WriteLine($"min element {C}");






            #endregion

            #region Q4

            //Console.WriteLine("Enter Number");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 3 == 0 && number % 4 == 0)
            //    Console.WriteLine("yes");
            //else if (number % 4 == 0)
            //    Console.WriteLine("Even number");
            //else
            //    Console.WriteLine("Individual number");
            #endregion

            #region Q5

            //Console.WriteLine("Enter a letter");
            //string X = (Console.ReadLine());
            //switch (X)
            //{
            //    case "a":
            //    case "e":
            //    case "I":
            //    case "o":
            //    case "u":
            //        Console.WriteLine("vowel");
            //        break;
            //    default:
            //        Console.WriteLine("Consonant");
            //        break;
            //}


            #endregion

            #region Q6
            //Console.WriteLine("Enter Number");
            //int X = int.Parse(Console.ReadLine());
            //Console.Clear();

            //Console.WriteLine(X * 1);
            //Console.WriteLine(X * 2);
            //Console.WriteLine(X * 3);
            //Console.WriteLine(X * 4);
            //Console.WriteLine(X * 5);
            //Console.WriteLine(X * 6);
            //Console.WriteLine(X * 7);
            //Console.WriteLine(X * 8);
            //Console.WriteLine(X * 9);
            //Console.WriteLine(X * 10);
            //Console.WriteLine(X * 11);
            //Console.WriteLine(X * 12);

            #endregion

            #region Q7

            Console.WriteLine("Enter Number");

            string inputX = Console.ReadLine();

            
            string[ ] SS = inputX.Split(' ');

            
            int X = int.Parse(SS[0]);
            int Y = int.Parse(SS[1]);

            //int X = int.Parse(Console.ReadLine());
            //int Y = int.Parse(Console.ReadLine());

            double Result = Math.Pow(X, Y);

            Console.WriteLine(Result);

        
            #endregion


        }
    }
}
