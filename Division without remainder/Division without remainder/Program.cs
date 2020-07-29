using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division_without_remainder
{
	class Program
	{
		static void Main(string[] args)
		{
			int NumCounts = int.Parse(Console.ReadLine());
			int TotalNums = NumCounts;

			if(NumCounts <= 1000 && NumCounts > 0)
			{
				double Num2WithoutDivision = 0;
				double Num3WithoutDivision = 0;
				double Num4WithoutDivision = 0;

				while (NumCounts > 0)
				{
					double CurrentNum = int.Parse(Console.ReadLine());

					if (CurrentNum % 2 == 0)
					{
						Num2WithoutDivision++;
						if (CurrentNum % 3 == 0)
						{
							Num3WithoutDivision++;
							if (CurrentNum % 4 == 0)
							{
								Num4WithoutDivision++;
							}
						}
						if (CurrentNum % 4 == 0 && CurrentNum % 3 != 0)
						{
							Num4WithoutDivision++;
						}
					}
					else if (CurrentNum % 3 == 0)
					{
						Num3WithoutDivision++;
						if (CurrentNum % 4 == 0)
						{
							Num4WithoutDivision++;
						}
					}
					NumCounts--;
				}

				if (NumCounts == 0)
				{
					double Num2WDinPercent = Num2WithoutDivision * 100 / TotalNums;
					Console.WriteLine("{0:0.00}%", Num2WDinPercent);

					double Num3WDinPercent = Num3WithoutDivision * 100 / TotalNums;
					Console.WriteLine("{0:0.00}%", Num3WDinPercent);

					double Num4WDinPercent = Num4WithoutDivision * 100 / TotalNums;
					Console.WriteLine("{0:0.00}%", Num4WDinPercent);
				}
			}
		}
	}
}
