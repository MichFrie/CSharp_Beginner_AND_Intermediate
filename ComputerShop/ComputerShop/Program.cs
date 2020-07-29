using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
	class Program
	{
		static void Main(string[] args)
		{
			int CompCount = int.Parse(Console.ReadLine());
			int Comps = CompCount;

			if(CompCount > 0 && CompCount < 11)
			{
				int WholeNum = 0;
				double Rating = 0;
				int Sells = 0;

				double SellsCount = 0;
				double TotalRating = 0;

				while (CompCount > 0)
				{
					WholeNum = int.Parse(Console.ReadLine());

					if (WholeNum > 31 && WholeNum < 307)
					{
						Rating = WholeNum % (10);
						TotalRating += Rating;

						Sells = Convert.ToInt32(WholeNum.ToString().Substring(0, 2));

						if (Rating == 3)
						{
							SellsCount = SellsCount + Sells * 0.5;
						}
						else if (Rating == 4)
						{
							SellsCount = SellsCount + Sells * 0.7;

						}
						else if (Rating == 5)
						{
							SellsCount = SellsCount + Sells * 0.85;

						}
						else if (Rating == 6)
						{
							SellsCount = SellsCount + Sells;

						}
					}

					CompCount--;

				}

				double AverageRat = TotalRating / Comps;

				Console.WriteLine("{0:0.00}", SellsCount);
				Console.WriteLine("{0:0.00}", AverageRat);
			}
		}
	}
}
