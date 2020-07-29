using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Vehicle_Catalogue
{
	class Vehicle
	{ 
		public string Brand { get; set; }
		public string Model { get; set; }
	}
	class Truck : Vehicle
	{ 
		public int Weight { get; set; }
		public Truck(string b, string m, int w)
		{
			Brand = b;
			Model = m;
			Weight = w;
		}
	}
	class Car : Vehicle
	{ 
		public int HorsePower { get; set; }
		public Car(string b, string m, int hp)
		{
			Brand = b;
			Model = m;
			HorsePower = hp;
		}
	}
	class Catalogue
	{
		public List<Truck> trucks = new List<Truck>();
		public List<Car> cars = new List<Car>();
	}
	class Program
	{
		static void putInCatalogue(Catalogue c)
		{
			string input;

			while ((input = Console.ReadLine()) != "end")
			{
				string[] info = input.Split('/');
				if (info[0] == "Car")
				{
					Car newCar = new Car(info[1], info[2], int.Parse(info[3]));
					c.cars.Add(newCar);
				}
				else
				{
					Truck newTruck = new Truck(info[1], info[2], int.Parse(info[3]));
					c.trucks.Add(newTruck);

				}
			}
		}

		static void orderTheCatalogue(Catalogue c)
		{
			c.cars = c.cars.OrderBy(o => o.Brand).ToList();
			c.trucks = c.trucks.OrderBy(o => o.Brand).ToList();
		}

		static void printCatalogue(Catalogue c)
		{
			Console.WriteLine("Cars:");
			foreach (var car in c.cars)
			{
				Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
			}

			Console.WriteLine("Trucks:");
			foreach (var truck in c.trucks)
			{
				Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
			}
		}

		static void Main(string[] args)
		{
			Catalogue vehicleCatalogue = new Catalogue();

			putInCatalogue(vehicleCatalogue);
			orderTheCatalogue(vehicleCatalogue);
			printCatalogue(vehicleCatalogue);
			
		}
	}
}
