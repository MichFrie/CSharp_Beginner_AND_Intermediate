using System;
using System.Data;
using System.Net.Http.Headers;

namespace methods
{
	class Program
	{
		static double calc(int a,char op ,int b)
		{
			if (op == '+')
			{
				return a + b; 
			}
			else if (op == '-')
			{
				return a - b;

			}
			else if (op == '*')
			{
				return a * b;

			}
			else if (op == '/')
			{
				return a / b;

			}
			else
			{
				return 0;
			}
		}
		

		static void Main(string[] args)
		{
			int num1 = int.Parse(Console.ReadLine());
			char com = char.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());

			Console.WriteLine($"{calc(num1, com, num2)}");
		}
	}
}
