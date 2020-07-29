using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscars3
{
	class Program
	{
		static void Main(string[] args)
		{
			double Budget = double.Parse(Console.ReadLine());
			
			double Statistics = double.Parse(Console.ReadLine());

			double CPrice = double.Parse(Console.ReadLine());

			double Decor = Budget * 0.1;

			double Clothin_Cost = 0;

			double Total = 0;

			if(Statistics > 150)
			{
				Clothin_Cost = Statistics * CPrice;
				Clothin_Cost = Clothin_Cost * 0.9; 
			}
			else
			{
				Clothin_Cost = Statistics * CPrice;
			}

			Total = Decor + Clothin_Cost;
			
			if(Budget >= Total)
			{
				double remain = Budget - Total;
				Console.WriteLine("Action!");
				Console.WriteLine("Wingard starts filming with {0:0.00} leva left.", remain);
			}
			else if(Budget < Total)
			{
				double need = Total - Budget;
				Console.WriteLine("Not enough money!");
				Console.WriteLine("Wingard needs {0:0.00} leva more.", need);
			}
		}
	}
}
