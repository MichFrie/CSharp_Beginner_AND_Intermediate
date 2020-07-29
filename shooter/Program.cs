using System;
using System.Collections.Generic;
using System.Linq;

namespace shooter
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
			int shoted = 0;
			string ip;

			while ((ip = Console.ReadLine()) != "End")
			{
				int index = int.Parse(ip);
				
				if (index < targets.Count)
				{
					int targetPoints = targets[index];
					targets[index] = -1;
					shoted++;

					for (int i = 0; i < targets.Count; i++)
					{
						if (targets[i] != -1)
						{
							if (targets[i] > targetPoints)
							{
								targets[i] -= targetPoints;
							}
							else
							{
								targets[i] += targetPoints;
							}
						}
					}
				} 
			}

			Console.WriteLine($"Shot targets: {shoted} -> {string.Join(" ", targets)}");
		}
	}
}