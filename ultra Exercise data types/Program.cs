using System;

namespace ultra_Exercise_data_tzpes
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			while (input != "END")
			{
				if (int.TryParse(input, out int r1))
				{
					Console.WriteLine($"{input} is integer type");
				}
				else if (double.TryParse(input, out double r2))
				{
					Console.WriteLine($"{input} is floating point type");
				}
				else if (char.TryParse(input, out char r3))
				{
					Console.WriteLine($"{input} is character type");
				}
				else if (bool.TryParse(input, out bool r4))
				{
					Console.WriteLine($"{input} is boolean type");
				}
				else
				{
					Console.WriteLine($"{input} is string type");
				}
				input = Console.ReadLine();
			}
		}
	}
}
