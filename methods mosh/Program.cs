using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace methods_mosh
{
	class StopWatch1
	{

		private DateTime _timeStart = new DateTime();
		private DateTime _timeStopped = new DateTime();
		private TimeSpan _timeSpan = new TimeSpan();
		private bool _isStarted;

		public void Start()
		{
			if (_isStarted)
				throw new InvalidOperationException("Is already started");
			_timeStart = DateTime.Now;
			_isStarted = true;
		}

		public void Stop()
		{
			if (_isStarted)
			{
				_timeStopped = DateTime.Now;
				_isStarted = false;
				_timeSpan = _timeStopped - _timeStart;
			}
			else
				Console.WriteLine("The stopwatch isn't already started!");
		}

		public void PrintElapsedTime()
		{
			Console.WriteLine($"Elapsed: {_timeSpan.Seconds}");
		}
	}
	class Program
	{
		static void Commands(StopWatch1 stopwatch)
		{
			string input;
			while ((input = Console.ReadLine()) != "Exit")
			{
				switch (input)
				{
					case "Start":
						stopwatch.Start();
						break;
					case "Stop":
						stopwatch.Stop();
						stopwatch.PrintElapsedTime();
						break;
					default:
						break;
				}
			}
		}

		static void Main(string[] args)
		{
			StopWatch1 sw = new StopWatch1();

			Commands(sw);
		}
	}
}
