namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region implicit casting - safe casting
            //int x = 4;         // 4butes
            //long y = /*(long)*/x;
            #endregion

            #region Explicit casting - unsafe casting
            //long x = 101010101010;   //8 Bytes
            //int y;
            //checked
            //{
            //    y = (int)x;
            //}
            //Console.WriteLine(y);

            //double x = 88.878;
            //int y = (int)x;

            //Console.WriteLine(y);

            #endregion

            #region parse [ convert from string to any datatype ]
            // int number = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Data user");
            //Console.Write("Enter Name : ");
            //string Name = Console.ReadLine();
            //Console.Write("Enter Age : ");
            //int Age = int.Parse(Console.ReadLine());
            //Console.Write("Enter Salary : ");
            //double Salary = double.Parse(Console.ReadLine());

            //Console.Clear();
            //Console.WriteLine(" Name :"+Name + " Age :" + Age + " Salary :" + Salary);

            #endregion

            #region convert [convert from any Datatype to any Datatype]

            //Console.WriteLine("Enter Data user");
            //Console.Write("Enter Name : ");
            //string Name = Console.ReadLine();
            //Console.Write("Enter Age : ");
            //int Age = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter Salary : ");
            //double Salary =Convert.ToDouble(Console.ReadLine());

            //Console.Clear();
            //Console.WriteLine(" Name :" + Name + " Age :" + Age + " Salary :" + Salary);

            #endregion

            #region Unary operators[ ++ , -- ]
            //int X = 5;

            //// X++
            //// ++X

            ////Console.WriteLine(++X);    //  6   prefix
            ////Console.WriteLine(X);      //  5
            ////Console.WriteLine(X++);    //  5   postfix

            //Console.WriteLine(--X);    //  6   prefix
            //Console.WriteLine(X);      //  5
            //Console.WriteLine(X--);    //  5   postfix
            #endregion

            #region Binary operator

            //int Sum, Mul, Sub, Div, Mod;

            //int A = 10;
            //int B = 5;

            //Mod = A % B;  //
            //Sum = A + B;  //
            //Mul = A - B;  //
            //Div = A / B;  //
            //Mul = A * B;  //

            //Console.WriteLine(Div);


            #endregion

            #region Assignment  Operator

            //int X = 10;

            //X += 10;  // X = X +10;
            //X %= 10;
            //X -= 10;
            //X /= 10;
            //X *= 10;

            #endregion

            #region Relational Operators

            //int A = 5;
            //int B = 10;

            //Console.WriteLine(A < B);  // true
            #endregion

            #region  logical operators [ short circut]

            //Console.WriteLine(!true);        // false
            //Console.WriteLine(true && false);
            //// true && true   => true
            //// true && false  => false
            //// false && true  => false
            //// false && false => false

            //Console.WriteLine(true || false);
            //// true  || true   => true
            //// true  || false  => true
            //// false || true   => true
            //// false || false  => false

            #endregion

            #region  Bitwise operators [ long circut]


            //Console.WriteLine(true & false);  // false
            //// true  & true   => true
            //// true  & false  => false
            //// false & true  => false
            //// false & false => false

            //Console.WriteLine(true | false);  // true
            //// true  | true   => true
            //// true  | false  => true
            //// false | true   => true
            //// false | false  => false

            #endregion

            #region  Ternary operators [conditional operator]

            //int X = 3;

            //string Massage = X > 4 ? "good" : "bad";
            //Console.WriteLine(Massage);

            #endregion

            #region Operator periorety
            /*
            1. Unary [prefix]
            2. ( )
            3. * / %
            4. + -
            */

            //int A = 20;
            //int B = 15;
            //int C = 10;
            //int D = 5;

            //int Result;

            //Result = (A + B) * C / D;  // 70
            //Result = ++A * C;          // 210
            //Result = A++ * C;          // 200
            //Result = A * C;            // 200
            //Console.WriteLine(Result);
            #endregion

            #region  string Formating

            // Eqution = X + Y = Result
            // Eqution = 10 + 5 = 15

            //int X = 10;
            //int Y = 5;
            //int Result = X + Y;
            //Console.WriteLine("Eqution : " + X + "+" + Y + "=" + Result);

            // string => Immutable Datatype
            // string Name = "Ahmed";
            // Name = "Ali";

            #region MyRegion

            #endregion
            #endregion

            #region 1.Composite Format 
            //int X = 10;
            //int Y = 5;
            //int Result = X + Y;
            //string Massge = string.Format("Equation = {0} + {1} = {2}", X, Y, Result);
            //Console.WriteLine(Massge);
            //Console.WriteLine("Equation = {0} + {1} = {2}", X, Y, Result);

            #endregion

            #region String Manipolition

            // string  Interpolation => $

            //int X = 10;
            //int Y = 5;
            //int Result = X + Y;

            //Console.WriteLine($"Equation = {X} + {Y} = {Result}");

            #endregion

            #region If Else - - Switch Case

            //Console.WriteLine("Enter Month Number");
            //int MonthNumber = int.Parse(Console.ReadLine());
            // 1  => Month is Jan
            // 2  => Month is Feb
            // 3  => Month is Mar
            // Invalid Input
            #region  if
            //if (MonthNumber == 1)
            //{
            //    Console.WriteLine("Month is Jan");
            //}
            //else if(MonthNumber == 2)
            //{
            //    Console.WriteLine("Month is Feb");
            //}
            //else if (MonthNumber == 3)
            //{
            //    Console.WriteLine("Month is Mar");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input");
            //}
            #endregion

            #region Switch
            //switch (MonthNumber)
            //{
            //    case 1 :
            //        Console.WriteLine("Month is Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Month is Feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("Month is Mar");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Input");
            //        break;
            //}
            #endregion
            #endregion

            #region  GoTo
            //Console.WriteLine("Enter option");

            // 3000 => "option 01" ,"option 02","option 03" 
            // 2000 => "option 01" ,"option 02"
            // 1000 => "option 01"

            //int option = int.Parse(Console.ReadLine());
            //switch(option)
            //{
            //    case 3000:
            //        Console.WriteLine("option 03");
            //        goto case 2000;
            //    case 2000: 
            //        Console.WriteLine("option 03");
            //        goto case 1000;
            //    case 1000:
            //        Console.WriteLine("option 01");
            //        break;

            //}

            #endregion

            #region Evaluation of switch Case
            #region C# 06
            //Console.WriteLine("Enter Age");
            //int Age = int.Parse(Console.ReadLine());
            //switch (Age)
            //{
            //    case > 22:
            //        Console.WriteLine("Age Greter Than 22");
            //        break;
            //    case < 22:
            //        Console.WriteLine("Age less Than 22");
            //        break;
            //    default:
            //        Console.WriteLine("Age Greter Than 22");
            //        break;
            //}
            #endregion
            #region C# 07

            //object obj = new object();

            //obj = "ahmed";
            //obj = 15;
            //obj = true;

            //switch (obj)
            //{
            //    case int Numb when Numb > 10 && Numb < 20:
            //        Console.WriteLine($"{Numb} is int");
            //        break;
            //    case string Name:
            //        Console.WriteLine($"{Name} is string ");
            //        break;
            //    case bool flag:
            //        Console.WriteLine($"{flag} is bool ");
            //        break;
            //}
            #endregion
            #region C# 08

            //Console.WriteLine("Enter option");
            //int opation = int.Parse(Console.ReadLine());
            //string Massage = opation switch
            //{
            //    1 => "option 01",
            //    2 => "option 02",
            //    3 => "option 03",
            //    _ => "Invalid"
            //};
            //Console.WriteLine(Massage);
            #endregion
            #endregion

        }
    }
}
