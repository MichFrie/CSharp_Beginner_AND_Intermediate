using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscars1
{
	class Program
	{
		static void Main(string[] args)
		{
			string FName = Console.ReadLine();
			string Type = Console.ReadLine();
			int Count = int.Parse(Console.ReadLine());
			double cost = 0;


			///A Star Is Born///
			if(FName == "A Star Is Born")
			{
				if (Type == "normal")
				{
					cost = 7.50 * Count;
				}
				else if (Type == "luxury")
				{
					cost = 10.50 * Count;
				}
				else if (Type == "ultra luxury")
				{
					cost = 13.50 * Count;
				}
			}


			///Bohemian Rhapsody///
			if (FName == "Bohemian Rhapsody")
			{
				if (Type == "normal")
				{
					cost = 7.35 * Count;
				}
				if (Type == "luxury")
				{
					cost = 9.45 * Count;
				}
				if (Type == "ultra luxury")
				{
					cost = 12.75 * Count;
				}
			}


			///Green Book///
			if (FName == "Green Book")
			{
				if (Type == "normal")
				{
					cost = 8.15 * Count;
				}
				if (Type == "luxury")
				{
					cost = 10.25 * Count;
				}
				if (Type == "ultra luxury")
				{
					cost = 13.25 * Count;
				}
			}


			///The Favourite///
			if (FName == "The Favourite")
			{
				if (Type == "normal")
				{
					cost = 8.75 * Count;
				}
				if (Type == "luxury")
				{
					cost = 11.55 * Count;
				}
				if (Type == "ultra luxury")
				{
					cost = 13.95 * Count;
				}
			}
			Console.WriteLine("{0} -> {1:0.00} lv.", FName, cost);
		}
	}
}
