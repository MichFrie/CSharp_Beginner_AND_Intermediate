using System;
using System.Collections.Generic;
using System.Linq;

namespace associative_arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, double> class1 = new Dictionary<string, double>();

			class1.Add("Gosho", 4.50);
			class1.Add("Alex", 6.00);
			class1.Add("Alex123", 6.00);

			class1 = class1.OrderByDescending(student => student.Value)
							.ThenBy(student => student.Key)
							.ToDictionary(student => student.Key, student => student.Value);

			
		}
	}
}
