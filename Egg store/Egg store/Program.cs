using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egg_store
{
	class Program
	{
		static void Main(string[] args)
		{
			int eggs = int.Parse(Console.ReadLine());

			string Command = "";
			int ammount = 0;
			int sold = 0;

			while (eggs >= 0 || Command != "Close")
			{ 
				Command = Console.ReadLine();

				if(Command != "Close")
					ammount = int.Parse(Console.ReadLine());

				if (Command == "Buy")
				{
					eggs = eggs - ammount;
					sold += ammount;
				}

				if (Command == "Fill")
				{
					eggs = eggs + ammount;
				}

				if (eggs < 0)
				{
					Console.WriteLine("Not enough eggs in store!");
					Console.WriteLine($"You can buy only {eggs + ammount}.");
					break;
				}
				if (Command == "Close")
				{
					Console.WriteLine("Store is closed!");
					Console.WriteLine($"{sold} eggs sold.");
					break;
				}
			} 
		}
	}
}
