using System;

namespace SusCalc
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("SUSC#lc");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Addition");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - Squaring");
            Console.WriteLine("6 - Cubing");
            Console.WriteLine("7 - Square Root");
            Console.WriteLine("8 - Cube Root");
            Console.WriteLine("9 - Sin");
            Console.WriteLine("10 - Cos");
            Console.WriteLine("11 - Tan");
            Console.WriteLine("12 - aSin");
            Console.WriteLine("13 - aCos");
            Console.WriteLine("14 - aTan");
            Console.WriteLine("15 - Exit");
            int Option = Convert.ToInt32(Console.ReadLine());
            if (Option == 1)
            {
                Console.WriteLine("Addition");
                Console.WriteLine("First number?");
                double A = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Second number?");
                double B = Convert.ToDouble(Console.ReadLine());
                Operations r = new Operations(A, B);
                double C = r.addition();
                Console.WriteLine(A + " + " + B + " = " + C);
            }
            if (Option == 2)
            {
                Console.WriteLine("Subtraction");
                Console.WriteLine("First number?");
                double A = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Second number?");
                double B = Convert.ToDouble(Console.ReadLine());
                Operations r = new Operations(A, B);
                double C = r.subtraction();
                Console.WriteLine(A + " - " + B + " = " + C);
            }
            if (Option == 3)
            {
                Console.WriteLine("Moltiplication");
                Console.WriteLine("First number?");
                double A = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Second number?");
                double B = Convert.ToDouble(Console.ReadLine());
                Operations r = new Operations(A, B);
                double C = r.moltiplication();
                Console.WriteLine(A + " x " + B + " = " + C);
            }
            if (Option == 4)
            {
                Console.WriteLine("Division"); //Listen to Joy Division!
                Console.WriteLine("First number?");
                double A = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Second number?");
                double B = Convert.ToDouble(Console.ReadLine());
                Operations r = new Operations(A, B);
                double C = r.division();
                Console.WriteLine(A + " : " + B + " = " + C);
            }
            if (Option == 5)
            {
                Console.WriteLine("Squaring");
                Console.WriteLine("Number to square?");
                double A = Convert.ToDouble(Console.ReadLine());
                double B = 0;
                Operations r = new Operations(A, B);
                double C = r.squaring();
                Console.WriteLine(A + "^2" + " = " + C);
            }
            if (Option == 6)
            {
                Console.WriteLine("Cubing");
                Console.WriteLine("Number to cube?");
                double A = Convert.ToDouble(Console.ReadLine());
                double B = 0;
                Operations r = new Operations(A, B);
                double C = r.cubing();
                Console.WriteLine(A + "^3" + " = " + C);
            }
            if (Option == 7)
            {
                Console.WriteLine("Sqrt");
                Console.WriteLine("Number to square root?");
                double A = Convert.ToDouble(Console.ReadLine());
                double B = 0;
                Operations r = new Operations(A, B);
                double C = r.sqrt();
                Console.WriteLine("Sqrt of: " + A + " = " + C);
            }
            if (Option == 8)
            {
                Console.WriteLine("Cbrt");
                Console.WriteLine("Number to cube root?");
                double A = Convert.ToDouble(Console.ReadLine());
                double B = 0;
                Operations r = new Operations(A, B);
                double C = r.cbrt();
                Console.WriteLine("Cbrt of: " + A + " = " + C);
            }
            if (Option == 9)
            {
                Console.WriteLine("Sin");
                Console.WriteLine("Sin of?");
                double A = Convert.ToDouble(Console.ReadLine());
                double B = 0;
                Operations r = new Operations(A, B);
                double C = r.sin();
                Console.WriteLine("Sin of:" + A + " = " + C);
            }
            if (Option == 10)
            {
                Console.WriteLine("Cos");
                Console.WriteLine("Cos of?");
                double A = Convert.ToDouble(Console.ReadLine());
                double B = 0;
                Operations r = new Operations(A, B);
                double C = r.cos();
                Console.WriteLine("Cos of:" + A + " = " + C);
            }
            if (Option == 11)
            {
                Console.WriteLine("Tan");
                Console.WriteLine("Tan of?");
                double A = Convert.ToDouble(Console.ReadLine());
                double B = 0;
                Operations r = new Operations(A, B);
                double C = r.tan();
                Console.WriteLine("Tan of:" + A + " = " + C);
            }
            if (Option == 12)
            {
                Console.WriteLine("aSin");
                Console.WriteLine("aSin of?");
                double A = Convert.ToDouble(Console.ReadLine());
                double B = 0;
                Operations r = new Operations(A, B);
                double C = r.asin();
                Console.WriteLine("aSin of:" + A + " = " + C);
            }
            if (Option == 13)
            {
                Console.WriteLine("aCos");
                Console.WriteLine("aCos of?");
                double A = Convert.ToDouble(Console.ReadLine());
                double B = 0;
                Operations r = new Operations(A, B);
                double C = r.acos();
                Console.WriteLine("aCos of:" + A + " = " + C);
            }
            if (Option == 14)
            {
                Console.WriteLine("aTan");
                Console.WriteLine("aTan of?");
                double A = Convert.ToDouble(Console.ReadLine());
                double B = 0;
                Operations r = new Operations(A, B);
                double C = r.atan();
                Console.WriteLine("aTan of:" + A + " = " + C);
            }
            if (Option == 15)
            {
                Console.WriteLine("Ok, goodbye;)");
            }
        }
    }
}
