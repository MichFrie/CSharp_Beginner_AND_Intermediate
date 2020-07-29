using System;

namespace Exercises
{
	class Program
	{
		static void Main(string[] args)
		{
			int loses = int.Parse(Console.ReadLine());
			double hPrice = double.Parse(Console.ReadLine());
			double mPrice = double.Parse(Console.ReadLine());
			double kPrice = double.Parse(Console.ReadLine());
			double dPrice = double.Parse(Console.ReadLine());

			int hTrashed = 0, mTrashed = 0, kTrashed = 0, dTrashed = 0;

			for (int i = 1; i <= loses; i++)
			{
				if (i % 2 == 0 && i % 3 == 0)
				{
					kTrashed++;
					mTrashed++;
					hTrashed++;
					if (kTrashed % 2 == 0)
					{
						dTrashed++;
					}
				}
				else if (i % 2 == 0)
				{
					hTrashed++;
				}
				else if (i % 3 == 0)
				{
					mTrashed++;
				}

				
			}
			Console.WriteLine($"Rage expenses: {dTrashed*dPrice + kTrashed*kPrice + mTrashed*mPrice + hTrashed*hPrice:f2} lv.");
		}
	}
}
