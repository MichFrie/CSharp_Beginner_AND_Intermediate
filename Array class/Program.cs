using System;
using System.Diagnostics;
namespace Array_class
{
	class Program
	{
		static void Main(string[] args)
		{
			Array array1 = new Array(1);

			array1.insert(10);
			array1.insert(20);
			array1.insert(30);
			array1.print();

			var reversed = array1.reverse();
			reversed.print();		
		}
	}
}
