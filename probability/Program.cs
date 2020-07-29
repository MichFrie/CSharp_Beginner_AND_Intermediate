using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probability
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the command posibility calculator.");
			
			/// ammount of balls declaration ///
			Console.WriteLine("Insert different ammount of ball from each color");
			int[] ball_color_amount = new int[2];
			int all_objects = 0;

			for (int i = 0; i < 2; i++)
			{
				switch(i)
				{
					case 0:
						Console.Write("White balls: ");
						break;
					case 1:
						Console.Write("Black balls: ");
						break;
				}
				ball_color_amount[i] = int.Parse(Console.ReadLine());
				all_objects += ball_color_amount[i];
			}

			/// duty task ///
			Console.Write("How many balls do you have to pull out: ");
			int task = int.Parse(Console.ReadLine());

			/// aim ///
			Console.Write("What's your aim:" +
				"\nA)to pull out only black balls" +
				"\nB)to pull out only white balls" +
				"\nC)to pull out one black and one white" +
				"\nChoice[A,B,C]: ");

			string choice = Console.ReadLine();


			double possibility;
			switch(choice)
			{
				case "A":
					possibility = Combination(ball_color_amount[1], task) / Combination(all_objects, task);
					break;
				case "B":
					possibility = Combination(ball_color_amount[0], task) / Combination(all_objects, task);
					break;
				case "C":
					possibility = ( Combination(ball_color_amount[0], task / 2) * Combination(ball_color_amount[1], task / 2) ) / Combination(all_objects, task);
					break;
				default:
					possibility = 0;
					break;
			}

			Console.WriteLine($"Possibility: {possibility}");


			double all_combinations = Combination(all_objects, task);

			Console.WriteLine();

			Console.ReadLine();
		}

		private static double Combination(int n, int k)
		{
			double result = 0;

			result = fac(n) / ( fac(k) * fac((n - k)) );

			return result;
		}

		private static int fac(int integer)
		{
			int fac = 1;
			for (int i = 2; i <= integer; i++)
			{
				fac *= i;
			}

			return fac;
		}
	}
}
