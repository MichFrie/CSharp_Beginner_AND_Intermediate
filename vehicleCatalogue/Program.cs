using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace vehicleCatalogue
{
	class Car
	{
		public string Type { get; set; }
		public string Model { get; set; }
		public string Color { get; set; }
		public string HP { get; set; }

		public Car(string m, string c, string hp)
		{
			Type = "Car";
			Model = m;
			Color = c;
			HP = hp;
		}
	}
	class Truck
	{
		public string Type { get; set; }
		public string Model { get; set; }
		public string Color { get; set; }
		public string HP { get; set; }

		public Truck(string m, string c, string hp)
		{
			Type = "Truck";
			Model = m;
			Color = c;
			HP = hp;
		}
	}
	class Vehicles
	{
		public string Type { get; set; }
		public string Model { get; set; }
		public string Color { get; set; }
		public string HP { get; set; }

		public Vehicles(string t,string m, string c, string hp)
		{
			if (t == "car")
			{
				Type = "Car";
			}
			else
			{
				Type = "Truck";
			}
			Model = m;
			Color = c;
			HP = hp;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			List<Vehicles> ve = new List<Vehicles>(); 

			int sumCars = 0, sumTrucks = 0;
			int countCars = 0, countTrucks = 0;

			string input;

			while ((input = Console.ReadLine()) != "End")
			{
				string[] i = input.Split();
				Vehicles v = new Vehicles(i[0], i[1], i[2], i[3]);

				ve.Add(v);
				if (v.Type == "Car")
				{
					sumCars += int.Parse(v.HP);
					countCars++;

				}
				else
				{
					sumTrucks += int.Parse(v.HP);
					countTrucks++;
				}
			}

			string input2;
			List<string> p = new List<string>();
			while ((input2 = Console.ReadLine()) != "Close the Catalogue")
			{
				p.Add(input2);
			}

			for (int inp = 0; inp < p.Count; inp++)
			{
				for (int j = 0; j < ve.Count; j++)
				{
					
					if (ve[j].Model == p[inp])
					{
						Console.WriteLine($"Type: {ve[j].Type}");
						Console.WriteLine($"Model: {ve[j].Model}");
						Console.WriteLine($"Color: {ve[j].Color}");
						Console.WriteLine($"Horsepower: {ve[j].HP}");
					}
				}
				
			}
			double averageCarsHP = Math.Round((double)sumCars / countCars, 2);
			double averageTrucksHP = Math.Round((double)sumTrucks / countTrucks, 2);

			if (countCars > 0)
			{
				Console.WriteLine($"Cars have average horsepower of: {averageCarsHP:f2}."); 
			}
			else
			{
				Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
			}
			if (countTrucks > 0)
			{
				Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHP:f2}."); 
			}
			else
			{
				Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
			}
		}
	}
}
