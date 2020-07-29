using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fast_meal
{
	class Program
	{
		static void Main(string[] args)
		{
			/// Welcome text ///
			
			Console.WriteLine("\t\t\t\t\t\t" +
				"Welcome to Healthy Way.\n\t\t\t\t" +
	"The place for a healthy, affortable and FAST meal.\n");

			for (int i = 0; i < 120; i++)
			{
				Console.Write(".");
			}
			Console.WriteLine();
			/// End welcome text ///

			Salad Bulgarian_salad = new Salad("Bulgarian salad",  "Tomatoes, cucumbers, white cheese, oil", 7.99);
			Salad Chicken_salad = new Salad("Chicken salad", "Chicken, tomatoes, iceberd, lettuce, corn, cucumber and dressing", 8.99);


			List <Tuple<string, string, double>> salads = new List<Tuple<string, string, double>>();

			salads.Add(new Tuple<string, string, double> (
				Bulgarian_salad._product_name,Bulgarian_salad._ingredients,Bulgarian_salad._price));
			salads.Add(new Tuple<string, string, double> (
				Chicken_salad._product_name, Chicken_salad._ingredients, Chicken_salad._price));
			

			Console.WriteLine("MENU:");
			for (int item = 0; item < salads.Count; item++)
			{
				for (int i = 0; i < 5; i++)
				{
					Console.Write("|");
					switch (i)
					{
						case 0:
							Console.WriteLine(salads[item].Item1);
							break;
						case 2:
							Console.WriteLine(salads[item].Item2);
							break;
						case 4:
							Console.WriteLine("Price: $" + salads[item].Item3);
							break;
						default:
							Console.WriteLine();
							break;
					}
				}
				Console.WriteLine("\n");
			}



			Console.ReadLine();
		}
	}
}

