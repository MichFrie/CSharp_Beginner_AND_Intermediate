using System;

namespace ExamExercise
{
	class Program
	{
		static void Main(string[] args)
		{
			string movie = "";
			int studentCount = 0, kidCount = 0, standardCount = 0;

			int totalTickets = 0;

			while ((movie = Console.ReadLine()) != "Finish")
			{
				string ticketType = "";
				int ticketsCount = int.Parse(Console.ReadLine());
				int studentCountPerFilm = 0, kidCountPerFilm = 0, standardCountPerFilm = 0;
				for (int i = 0; i < ticketsCount; i++)
				{
					ticketType = Console.ReadLine();
					if (ticketType == "Finish")
					{
						break;
					}
					else if (ticketType != "End")
					{
						switch (ticketType)
						{
							case "student":
								studentCount++;
								studentCountPerFilm++;
								break;
							case "kid":
								kidCount++;
								kidCountPerFilm++;
								break;
							case "standard":
								standardCount++;
								standardCountPerFilm++;
								break;
							default:
								break;
						}
						totalTickets++;
					}
					else
					{
						break;
					}
				}
				Console.WriteLine("{0} - {1:0.00}% full.", movie, (double)(studentCountPerFilm + standardCountPerFilm + kidCountPerFilm) / ticketsCount * 100);
				if (ticketType == "Finish")
				{
					break;
				}
			}
			Console.WriteLine($"Total tickets: {totalTickets}");
			Console.WriteLine("{0:0.00}% student tickets.", (double)studentCount / totalTickets * 100);
			Console.WriteLine("{0:0.00}% standard tickets.", (double)standardCount / totalTickets * 100);
			Console.WriteLine("{0:0.00}% kids tickets.", (double)kidCount / totalTickets * 100);
		}
	}
}
