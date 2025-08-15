using System;

namespace Basic_Calculator
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Enter 1st Number: ");
			int num1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter 2nd Number: ");
			int num2 = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Select Operator \n1. + \n2. -");
			Console.Write("?: ");
			int input = Convert.ToInt32(Console.ReadLine());
			
			switch (input)
			{
			
				case 1:
					Console.Write("Result " + (num1 + num2));
					break;
					
				case 2:
					Console.Write("Result " + (num1 - num2));
					break;
				
				default:
                Console.WriteLine("Invalid choice.");
                break;
			}
			
		}
	}

}
