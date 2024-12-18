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

            Console.WriteLine("Enter Number");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case > 0:
           Console.WriteLine("positive");
                    break;
                default:
                    Console.WriteLine("negative");
                    break;
            }

            #endregion
        }
    }
}
