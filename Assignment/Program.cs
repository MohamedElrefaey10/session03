﻿using System;
using static System.Net.Mime.MediaTypeNames;
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

            #region Q7
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

            #region Q9

            //Console.WriteLine("Enter Number");

            //string inputX = Console.ReadLine();


            //string[ ] SS = inputX.Split(' ');


            //int X = int.Parse(SS[0]);
            //int Y = int.Parse(SS[1]);

            ////int X = int.Parse(Console.ReadLine());
            ////int Y = int.Parse(Console.ReadLine());

            //double Result = Math.Pow(X, Y);

            //Console.WriteLine(Result);


            #endregion


            #region Q10

            //Console.WriteLine("Enter Marks of five subjects: ");

            //string inputs = Console.ReadLine();

            //string[] input = inputs.Split(" ");

            //int sub1 = int.Parse(input[0]);
            //int sub2 = int.Parse(input[1]);
            //int sub3 = int.Parse(input[2]);
            //int sub4 = int.Parse(input[3]);
            //int sub5 = int.Parse(input[4]);

            //double TotalMarks = sub1 + sub2 + sub3 + sub4 + sub5;

            //double AverageMarks = TotalMarks / 5;

            //double Percentage = (TotalMarks / 500) * 100;

            //Console.WriteLine("Total Marks : "+ TotalMarks);

            //Console.WriteLine("AverageMarks : "+AverageMarks);

            //Console.WriteLine("Percentage : "+ Percentage);


            #endregion

            #region Q11

            Console.WriteLine("Enter number of the month");

            int Numb = int.Parse(Console.ReadLine());

            switch (Numb)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Days in Month: 31");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Days in Month: 30");
                    break;
                case 2:
                    Console.WriteLine("Days in Month: 28");
                    break;
            }




            #endregion


        }
    }
}
