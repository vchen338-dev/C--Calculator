using System;

namespace Basic_Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter 1st Number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter 2nd Number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Select Operator (+, -, *, /, %, ^)");
                Console.Write("?: ");
                string op = Console.ReadLine();

                double result;

                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine("Result: " + result);
                        break;

                    case "-":
                        result = num1 - num2;
                        Console.WriteLine("Result: " + result);
                        break;

                    case "*":
                        result = num1 * num2;
                        Console.WriteLine("Result: " + result);
                        break;

                    case "/":
                        if (num2 == 0)
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        else
                        {
                            result = num1 / num2;
                            Console.WriteLine("Result: " + result);
                        }
                        break;

                    case "%":
                        if (num2 == 0)
                            Console.WriteLine("Error: Modulus by zero is not allowed.");
                        else
                        {
                            result = num1 % num2;
                            Console.WriteLine("Result: " + result);
                        }
                        break;

                    case "^":
                        result = Math.Pow(num1, num2);
                        Console.WriteLine("Result: " + result);
                        break;

                    default:
                        Console.WriteLine("Invalid operator.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid numbers.");
            }
        }
    }
}
