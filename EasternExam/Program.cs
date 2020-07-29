using System;

namespace EasternExam
{
	class Program
	{
		static void Main(string[] args)
		{
			int eggs = int.Parse(Console.ReadLine());
			string eggColor = Console.ReadLine();
			int redCounter = 0;
			int orangeCounter = 0;
			int blueCounter = 0;
			int greenCounter = 0;
			for (int i = 0; i < eggs; i++)
			{
				string command = Console.ReadLine();
				if(command == "red")
				{
					redCounter++;
				}
				if (command == "orange")
				{
					orangeCounter++;
				}
				if (command == "blue")
				{
					blueCounter++;
				}
				if (command == "green")
				{
					greenCounter++;
				}

			}
			int max = 0;
			max = greenCounter;
			if (redCounter>max)
			{
				max = redCounter;
			}
			if (blueCounter > max)
			{
				max = blueCounter;
			}
			if (orangeCounter > max)
			{
				max = orangeCounter;
			}
			Console.WriteLine($"Red eggs: { redCounter}");
			Console.WriteLine($"Orange eggs: {orangeCounter}");
		}
	}
}
