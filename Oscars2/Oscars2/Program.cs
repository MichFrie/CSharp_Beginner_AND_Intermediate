using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscars2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Rent hall cost: ");
			int RentHall = int.Parse(Console.ReadLine());

			double statuettes = RentHall - (RentHall * 0.3);
			double catering = statuettes - (statuettes * 0.15);
			double SRecording = catering - (catering * 0.5);

			double Total_Cost = RentHall + statuettes + catering + SRecording;
			Console.WriteLine(Total_Cost);

			Console.ReadKey();
		}
	}
}
