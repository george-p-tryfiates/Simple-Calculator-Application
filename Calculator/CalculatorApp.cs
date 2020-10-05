using System;
using System.ComponentModel;

namespace Calculator
{
    public class CalculatorApp
    {
        ///Add your code for application here
        ///Write a method for Subtraction, Multiplication, Division

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Div(int a, int b)
        {
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
            if (b == 0)
            {
                Console.WriteLine("The denominator must be non-zero.");
            }
            return a / b;

            /*catch (DivideByZeroException e)
            {

                Console.WriteLine("Denominator cannot be zero.");
                Console.WriteLine("Please re-enter denominator: ");
                float v = (float)Console.Read();
                return Div(a, v);
            }*/
        }

        public double Div(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("The denominator must be non-zero.");
            }
            return a / b;
        }
    }
}
