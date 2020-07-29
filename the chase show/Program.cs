using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace the_chase_show
{
	class Program
	{
		static int seconds = 60;
		static void Main(string[] args)
		{
			string ContestantName = Console.ReadLine();

			Timer timer = new Timer();
			timer.Elapsed += new ElapsedEventHandler(OnTimeEvent);
			timer.Interval = 1000;
			timer.Enabled = true;

			timer.Start();
			for (int i = 0; i < seconds; i++)
			{
				Console.WriteLine(seconds);
			}
			
			Console.ReadKey();
		}

		static void OnTimeEvent(object source, ElapsedEventArgs e)
		{
			seconds--;
		}
	}
}
