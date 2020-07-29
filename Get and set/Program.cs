using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_and_set
{
	class Program
	{
		static void Main(string[] args)
		{
			GetSeconds seconds = new GetSeconds();

			Console.Write("Number of seconds:");

			seconds.Seconds = int.Parse(Console.ReadLine());

			Console.WriteLine(seconds.Hours);
			Console.ReadLine();
		}
	}
}
