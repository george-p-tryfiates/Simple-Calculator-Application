using System;
using Calculator;


namespace Calculator
{
    class Program
    {
       
        static void Main(string[] args){

            /// Example to get you started,
            /// Remove the following code below after you run the app to ensure it works.

            bool control = true;

            while (control)
            {
                Console.WriteLine();
                //Display title as the Calculator App.
                Console.WriteLine("Calculator App");
                Console.WriteLine();
                CalculatorApp calculator = new CalculatorApp();

                //Declare 3 variables and set to empty.

                //*Hint* numInput1= ; numInput2= ; result = ;
                //String numbInput1 = "";





                //Ask the user to type the first number
                Console.WriteLine("Type a space-separated operation: number operator number (i.e., 1 + 1): ");
                string[] input = Console.ReadLine().Split(" ");

                int a = Convert.ToInt32(input[0]);
                char op = Convert.ToChar(input[1]);
                int b = Convert.ToInt32(input[2]);
                int result = 0;

                try
                {
                    switch (op)
                    {
                        case '+':
                            result = calculator.Add(a, b);
                            break;
                        case '-':
                            result = calculator.Sub(a, b);
                            break;
                        case '*':
                            result = calculator.Mult(a, b);
                            break;
                        case '/':
                            result = calculator.Div(a, b);
                            break;
                        default:
                            throw new Exception("Invalid Operator");
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("Enter valid operator: ");
                    op = Convert.ToChar(Console.ReadLine());
                }
                finally
                {
                    switch (op)
                    {
                        case '+':
                            result = calculator.Add(a, b);
                            break;
                        case '-':
                            result = calculator.Sub(a, b);
                            break;
                        case '*':
                            result = calculator.Mult(a, b);
                            break;
                        case '/':
                            result = calculator.Div(a, b);
                            break;
                        default:
                            throw new Exception("Invalid Operator");
                    }
                }
                
               

                Console.WriteLine("{0} {1} {2} = {3}", a, op, b, result);

                Console.WriteLine();
                Console.WriteLine("Do you want to continue? Enter 'true' or 'false'");
                control = Convert.ToBoolean(Console.ReadLine());
            }

            //Ask the user to type the second number.
            //Ask the user to the user to choose an operator.
            //If a non-numeric is entered add try/catch block to handle the exception.
            //Use a switch statement to do the calculations
            //Wait for the user to respond before closing.


        }


    }
}