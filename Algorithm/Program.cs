using System;
using System.Collections.Generic;

namespace Algorithm
{
	class Program
	{
		static int FindIndex(int[] list, int num)
		{
			int start = 0;
			int end = list.Length - 1;

			int midIndex = 0;

			while (start <= end)
			{
				midIndex = (end + start) / 2;

				if (num == list[midIndex])
				{
					return midIndex;
				}
				else if (num > list[midIndex])
				{
					start = midIndex + 1;
				}
				else if (num < list[midIndex])
				{
					end = midIndex - 1;
				}
			}
			return -1;
		}

		static void Main(string[] args)
		{
			Console.Write("Size: ");
			int[] a = new int[int.Parse(Console.ReadLine())];

			string input = "";

			for (int i = 0; i < a.Length; i++)
			{
				input = Console.ReadLine();
				if (int.TryParse(input, out int number))
				{
					a[i] = number;
				}
				else
				{
					Console.WriteLine("Put an integer!");
					i--;
				}
			}

			Array.Sort(a);
			Console.WriteLine();

			string searchedNum = "";
			bool isIn = false;

			while (true)
			{
				Console.Write("Number, pls: ");
				searchedNum = Console.ReadLine();


				if(int.TryParse(searchedNum, out int number))
				{
					//// is the in the list check
					for (int i = 0; i < a.Length; i++)
					{
						if (a[i] == number)
						{
							isIn = true;
						}
					}

					if (isIn)
					{
						Console.WriteLine($"The index is : {FindIndex(a, number)}");
						Console.WriteLine($"Binary search: {Array.BinarySearch(a, number)}");
						break;
					}
					else
					{
						Console.WriteLine("The number isn't in the list!!!");
					}
				}
				else
				{
					Console.WriteLine("Enter a number, not words!!!");
				}
			}

		}
	}
}
