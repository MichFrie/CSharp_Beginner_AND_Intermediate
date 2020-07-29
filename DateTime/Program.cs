using System;

namespace Datetime
{
	class Program
	{
		static void Main(string[] args)
		{
			var date = new DateTime(2002, 12, 4);

			Console.WriteLine(DateTime.Now.ToLongTimeString());
			Console.WriteLine(DateTime.Now.ToShortTimeString());
			Console.WriteLine(DateTime.Now.ToString("dd.mm.yyyy hh:mm"));
		}
	}
}
