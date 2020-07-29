using System;
using System.Collections.Generic;
using System.Linq;

namespace List_softuni
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

			bool changed = false;
			string input = "";

			while ((input = Console.ReadLine()) != "end" )
			{
				string[] command = input.Split();

				if (command[0] == "Add")
				{
					nums.Add(int.Parse(command[1]));
					changed = true;
				}
				else if (command[0] == "Remove")
				{
					nums.Remove(int.Parse(command[1]));
					changed = true;
				}
				else if (command[0] == "RemoveAt")
				{
					nums.RemoveAt(int.Parse(command[1]));
					changed = true;
				}
				else if (command[0] == "Insert")
				{
					nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
					changed = true;
				}
				else if (command[0] == "Contains")
				{
					if (nums.Contains(int.Parse(command[1])))
					{
						Console.WriteLine("Yes");
					}
					else
					{
						Console.WriteLine("No such number");
					}
				}
				else if (command[0] == "PrintEven")
				{
					foreach (var i in nums)
					{
						if (i % 2 == 0)
						{
							Console.Write(i + " ");
						}
					}
					Console.WriteLine();

				}
				else if (command[0] == "PrintOdd")
				{
					foreach (var i in nums)
					{
						if (i % 2 == 1)
						{
							Console.Write(i + " ");
						}
					}
					Console.WriteLine();
				}
				else if (command[0] == "GetSum")
				{
					long sum = 0;
					foreach (var i in nums)
					{
						sum += i;
					}
					Console.WriteLine(sum);
				}
				else if (command[0] == "Filter")
				{
					if (command[1] == "<")
					{
						foreach (var i in nums)
						{
							if (i < int.Parse(command[2]))
							{
								Console.Write(i + " ");
							}
						}
						Console.WriteLine();
					}
					else if (command[1] == ">")
					{
						foreach (var i in nums)
						{
							if (i > int.Parse(command[2]))
							{
								Console.Write(i + " ");
							}
						}
						Console.WriteLine();
					}
					else if (command[1] == "<=")
					{
						foreach (var i in nums)
						{
							if (i <= int.Parse(command[2]))
							{
								Console.Write(i + " ");
							}
						}
						Console.WriteLine();
					}
					else if (command[1] == ">=")
					{
						foreach (var i in nums)
						{
							if (i >= int.Parse(command[2]))
							{
								Console.Write(i + " ");
							}
						}
						Console.WriteLine();
					}
				}
			}
			if (changed)
			{
				Console.WriteLine(string.Join(" ", nums)); 
			}

		}
	}
}
