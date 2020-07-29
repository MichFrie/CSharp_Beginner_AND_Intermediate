using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketBallEquipment
{
	class Program
	{
		static void Main(string[] args)
		{
			int fee = int.Parse(Console.ReadLine());

			double trainers = fee * 0.6;
			double outfit = trainers * 0.8;
			double ball = outfit * 0.25;
			double accessories = ball * 0.2;

			double Total = fee + trainers + outfit + ball + accessories;
			Console.WriteLine("{0:0.00}", Total);
		}
	}
}
