using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Recursion
{
	class Program
	{
		static void Main()
		{
			string num = Console.ReadLine();

			Console.WriteLine(GetLastNum(num));
			Console.ReadKey();

			
		}
		static string GetLastNum(string number)
		{
			string lastInteger = number.Substring(number.Length - 1);
			switch (lastInteger)
			{
				case  "1":
					return "one";
				case "2":
					return "two";
				case "3":
					return "three";
				case "4":
					return "four";
				case "5":
					return "five";
				case "6":
					return "six";
				case "7":
					return "seven";
				case "8":
					return "eight";
				case "9":
					return "nine";

				default: return "Error";
					
			}
		}
	}
}

