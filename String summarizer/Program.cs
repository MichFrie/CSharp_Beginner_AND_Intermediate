using String;
using System;
using System.Collections.Generic;

namespace String1
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = "Have you ever tried to reach your goals, but you don't succeed.";

			Console.WriteLine(StringSummarizer.SummarizeText(text, 40));
		}
	}
}
