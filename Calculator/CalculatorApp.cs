using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class CalculatorApp
    {

        //Input Validation
        public void valid(object a , object b)
        {
            Regex rx = new Regex(@"00");
            MatchCollection matchesa = rx.Matches((string)a);
            MatchCollection matchesb = rx.Matches((string)b);
            if (matchesa.Count != 0 | matchesb.Count != 0)
            {
                throw new Exception("Do not enter values with leading zeroes");
            }

            Regex r = new Regex(@"\w");
            MatchCollection matchaa = rx.Matches((string)a);
            MatchCollection matchebb = rx.Matches((string)b);
            if (matchaa.Count != 0 | matchebb.Count != 0)
            {
                throw new Exception("Non-numeric characters are invalid");
            }
        }


        ///Write a method for Subtraction, Multiplication, Division

        public int Add(int a, int b)
        {
            valid(a, b);
            return a + b;
        }
        public float Add(float a, float b)
        {
            valid(a, b);
            return a + b;
        }
        public double Add(double a, double b)
        {
            valid(a, b);
            return a + b;
        }


        public int Sub(int a, int b)
        {
            valid(a, b);
            return a - b;
        }
        public double Sub(double a, double b)
        {
            valid(a, b);
            return a - b;
        }

        public int Mult(int a, int b)
        {
            valid(a, b);
            return a * b;
        }
        public double Mult(double a, double b)
        {
            valid(a, b);
            return a * b;
        }

        //Div op & its overloads
        public int Div(int a, int b)
        {
            valid(a, b);
            if (b == 0)
            {
                Console.WriteLine("The denominator must be non-zero.");
            }
            return a / b;
            /*catch (DivideByZeroException e)
            {
                Console.WriteLine("Denominator cannot be zero.");
                Console.WriteLine("Please re-enter denominator: ");
                int v = Console.Read();
                return Div(a, v);
            }*/
        }

        public float Div(float a, float b)
        {
            valid(a, b);
            if (b == 0)
            {
                Console.WriteLine("The denominator must be non-zero.");
            }
            return a / b;
        }

        public double Div(double a, double b)
        {
            valid(a, b);
            if (b == 0)
            {
                Console.WriteLine("The denominator must be non-zero.");
            }
            return a / b;
        }
    }
}
