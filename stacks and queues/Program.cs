using System;
using System.Collections;
using System.Collections.Generic;

namespace stacks_and_queues
{
	class Program
	{
		static void Main(string[] args)
		{
			var queue = new Stack<int>();

			for (int i = 0; i < 3; i++)
			{
				queue.Push( int.Parse(Console.ReadLine()) );
			}

			foreach (var item in queue)
			{
				Console.WriteLine(item); 
			}
		}
	}
}
