using System;
using System.Linq;

namespace Bitwise_Operations_Softuni
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());
			int p = int.Parse(Console.ReadLine());
			Console.WriteLine((7 << p) ^ num);
			
		}
	}
}
