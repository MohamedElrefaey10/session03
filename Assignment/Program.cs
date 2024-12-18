using System;

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

            Console.WriteLine("Enter Number");
            int number = int.Parse(Console.ReadLine());

            if (number % 3 == 0 && number % 4 == 0)
                Console.WriteLine("yes");
            else if (number % 4 == 0)
                Console.WriteLine("Even number");
            else
                Console.WriteLine("Individual number");
            #endregion


        }
    }
}
