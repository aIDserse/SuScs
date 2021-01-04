using System;
using System.Collections.Generic;
using System.Text;

namespace SusCalc
{
    class Operations
    {
        //Values
        private double A;
        private double B;
        //Constructor
        public Operations(double A1, double B1)
        {
            A = A1;
            B = B1;
        }
        //Addition
        public double addition()
        {
            double C = A + B;
            return C;
        }
        public double subtraction()
        {
            double C = A - B;
            return C;
        }
        public double moltiplication()
        {
            double C = A * B;
            return C;
        }
        public double division()
        {
            double C = A / B;
            return C;
        }
        public double squaring()
        {
            double C = A * A;
            return C;
        }
        public double cubing()
        {
            double C = A * A * A;
            return C;
        }
        public double sqrt()
        {
            double C = Math.Sqrt(A);
            return C;
        }
        public double cbrt()
        {
            double C = Math.Cbrt(A);
            return C;
        }
        public double sin()
        {
            A = A * 3.1415926535897931 / 180;
            double C = Math.Sin(A);
            return C;
        }
        public double cos()
        {
            A = A * 3.1415926535897931 / 180;
            double C = Math.Cos(A);
            return C;
        }
        public double tan()
        {
            A = A * 3.1415926535897931 / 180;
            double C = Math.Tan(A);
            return C;
        }
        public double asin()
        {

            double C = Math.Asin(A);
            C = C * 180 / 3.1415926535897931;
            return C;
        }
        public double acos()
        {
            double C = Math.Acos(A);
            C = C * 180 / 3.1415926535897931;
            return C;
        }
        public double atan()
        {
            double C = Math.Atan(A);
            C = C * 180 / 3.1415926535897931;
            return C;
        }
    }
}
