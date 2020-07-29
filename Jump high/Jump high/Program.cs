using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jump_high
{
	class Program
	{
		static void Main(string[] args)
		{
			int DesiredHigh = int.Parse(Console.ReadLine());

			int CurrentHigh = DesiredHigh - 30;

			int attempts = 3;
			int jump = 0;
			int jumpCount = 0;

			while (attempts >= 0)
			{
				jump = int.Parse(Console.ReadLine());
				jumpCount++;

				if (jump >= 100 && jump <= 300)
				{
					if (jump > CurrentHigh)
					{
						CurrentHigh += 5;
						attempts = 3;
					}

					if (jump > DesiredHigh)
					{
						break;
					}

					if (attempts == 0)
					{
						break;
					}
					else if (jump <= CurrentHigh)
						attempts--;
				}
			}

			if(attempts == 0)
				Console.WriteLine($"Tihomir failed at {CurrentHigh}cm after {jumpCount} jumps.");

			if(jump > DesiredHigh)
			Console.WriteLine($"Tihomir succeeded, he jumped over {DesiredHigh}cm after {jumpCount} jumps.");
		}
	}
}
