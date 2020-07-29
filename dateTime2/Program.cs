using System;

namespace dateTime2
{
	class Program
	{
		static void Main(string[] args)
		{
			var timeSpan = new TimeSpan(1,30,0);

			Console.WriteLine(timeSpan.TotalMinutes);
			Console.WriteLine(timeSpan.Minutes);

			Console.WriteLine(timeSpan.TotalHours);

			Console.WriteLine(timeSpan);
			Console.WriteLine(timeSpan.Add(TimeSpan.FromHours(2)));
			Console.WriteLine(timeSpan.Subtract( TimeSpan.FromHours(1) ));

			string sa = "1:02:32";
			Console.WriteLine(TimeSpan.Parse(sa));
		}
	}
}
