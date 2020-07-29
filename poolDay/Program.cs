using System;

namespace poolDay
{
	class Program
	{
		static void Main(string[] args)
		{
			double GamesCount = int.Parse(Console.ReadLine());
			double hah = GamesCount;
			double HS_Per = 0;
			double FN_Per = 0;
			double OW_Per = 0;
			double other_Per = 0;

			while(hah > 0)
			{
				string GameName = Console.ReadLine();
				if(GameName == "Hearthstone")
				{
					HS_Per += 1;
				}
				else if (GameName == "Fornite")
				{
					FN_Per += 1;
				}
				else if (GameName == "Overwatch")
				{
					OW_Per += 1;
				}
				else
				{
					other_Per += 1;
				}
				hah--;
			}
			double HearthstoneP = (HS_Per / GamesCount) * 100;
			double FortniteP = (FN_Per / GamesCount) * 100;
			double OverwatchP = (OW_Per / GamesCount) * 100;
			double OthersP = (other_Per / GamesCount) * 100;

			Console.WriteLine("Hearthstone - {0:0.00}%", HearthstoneP);
			Console.WriteLine("Fornite - {0:0.00}%", FortniteP);
			Console.WriteLine("Overwatch - {0:0.00}%", OverwatchP);
			Console.WriteLine("Others - {0:0.00}%", OthersP);
			Console.ReadKey();
		}
	}
}
