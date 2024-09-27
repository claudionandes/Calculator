using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result = 0;
            int op;
            bool calculating = true;

            while (calculating)
            {
                Console.WriteLine("Simple Calculator:");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multiplication");
                Console.WriteLine("4 - Division");
                Console.WriteLine("5 - Exit\n");

                Console.Write("Select an operation: ");
                op = Convert.ToInt32(Console.ReadLine());

                if (op == 5)
                {
                    calculating = false;
                    Console.WriteLine("Calculator closed");
                    return;
                }
                else if (op >= 1 && op <= 4)
                {
                    Console.Write("Enter the first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    if (op == 4 && num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero\n");
                    }
                    else
                    {
                        switch (op)
                        {
                            case 1:
                                result = Operations.Sum(num1, num2);
                                break;
                            case 2:
                                result = Operations.Sub(num1, num2);
                                break;
                            case 3:
                                result = Operations.Mult(num1, num2);
                                break;
                            case 4:
                                result = Operations.Div(num1, num2);
                                break;
                        }

                        Console.WriteLine($"The result of the operation between {num1} and {num2} is: {result}\n");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid operation\n");
                }
            }
        }
    }
}