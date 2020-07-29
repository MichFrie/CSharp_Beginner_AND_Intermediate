using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace methods_ex
{
	class Program
	{
		static void exchange(int[] arr, int index)
		{
			if (index >= arr.Length || index < 0)
			{
				Console.WriteLine("Invalid index");
			}
			else
			{
				//fill sub-arrays
				int[] subArr1 = new int[index + 1];
				for (int i = 0; i < subArr1.Length; i++)
				{
					subArr1[i] = arr[i];
				}

				int[] subArr2 = new int[arr.Length - subArr1.Length];

				for (int i = index + 1; i < arr.Length; i++)
				{
					subArr2[i - index - 1] = arr[i];
				}


				for (int i = 0; i < subArr2.Length; i++)
				{
					arr[i] = subArr2[i];
				}

				for (int i = 0; i < subArr1.Length; i++)
				{
					arr[subArr2.Length + i] = subArr1[i];
				}
			}
		}

		static int getMaxEvenIndex(int[] arr)
		{
			int index = -1;
			int biggest = int.MinValue;

			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] % 2 == 0 && arr[i] >= biggest)
				{
					biggest = arr[i];
					index = i;
				}
			}
			return index;
		}
		static int getMaxOddIndex(int[] arr)
		{
			int index = -1;
			int biggest = int.MinValue;

			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] % 2 != 0 && arr[i] >= biggest)
				{
					biggest = arr[i];
					index = i;
				}
			}
			return index;
		}

		static int getMinEvenIndex(int[] arr)
		{
			int index = -1;
			int smallest = int.MaxValue;

			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] % 2 == 0 && arr[i] <= smallest)
				{
					smallest = arr[i];
					index = i;
				}
			}
			return index;
		}
		static int getMinOddIndex(int[] arr)
		{
			int index = -1;
			int smallest = int.MaxValue;

			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] % 2 != 0 && arr[i] <= smallest)
				{
					smallest = arr[i];
					index = i;
				}
			}
			return index;
		}

		static void getFirstEvenNums(int[] arr, int count)
		{
			int currentCount = 0;
			StringBuilder newArr = new StringBuilder();

			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] % 2 == 0)
				{
					newArr.Append(arr[i] + " ");
					currentCount++;
				}
				if (count == currentCount)
				{
					break;
				}
			}

			var result = newArr.ToString().Split(' ', StringSplitOptions.RemoveEmptyEntries);

			if (count == 0)
			{
				Console.WriteLine("[]");
			}
			else
			{
				Console.WriteLine('[' + string.Join(", ", result) + ']');
			}
		}
		static void getFirstOddNums(int[] arr, int count)
		{
			int currentCount = 0;
			StringBuilder newArr = new StringBuilder();

			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] % 2 != 0)
				{
					newArr.Append(arr[i] + " ");
					currentCount++;
				}
				if (count == currentCount)
				{
					break;
				}
			}

			var result = newArr.ToString().Split(' ', StringSplitOptions.RemoveEmptyEntries);

			if (count == 0)
			{
				Console.WriteLine("[]");
			}
			else
			{
				Console.WriteLine('[' + string.Join(", ", result) + ']');
			}
		}

		
		static void getLastEvenNums(int[] arr, int count)
		{
			int currentCount = 0;
			StringBuilder newArr = new StringBuilder();

			for (int i = arr.Length - 1; i >= 0; i--)
			{
				if (arr[i] % 2 == 0)
				{
					newArr.Append(arr[i] + " ");
					currentCount++;
				}
				if (count == currentCount)
				{
					break;
				}
			}
			var result = newArr.ToString().Split(' ', StringSplitOptions.RemoveEmptyEntries);
			Array.Reverse(result);
			if (count == 0)
			{
				Console.WriteLine("[]");
			}
			else
			{
				Console.WriteLine('[' + string.Join(", ", result) + ']');
			}
		}
		static void getLastOddNums(int[] arr, int count)
		{
			int currentCount = 0;
			StringBuilder newArr = new StringBuilder();

			for (int i = arr.Length - 1; i >= 0; i--)
			{
				if (arr[i] % 2 != 0)
				{
					newArr.Append(arr[i] + " ");
					currentCount++;
				}
				if (count == currentCount)
				{
					break;
				}
			}
			var result = newArr.ToString().Split(' ', StringSplitOptions.RemoveEmptyEntries);
			Array.Reverse(result);
			if (count == 0)
			{
				Console.WriteLine("[]");
			}
			else
			{
				Console.WriteLine('[' + string.Join(", ", result) + ']');
			}
		}


		
		static void Main(string[] args)
		{
			int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

			string input = "";

			while ((input = Console.ReadLine()) != "end")
			{
				string[] command = input.Split();

				if (command[0] == "exchange")
				{
					exchange(array, int.Parse(command[1]));
				}
				else if (command[0] == "max")
				{
					if (command[1] == "even")
					{
						if (getMaxEvenIndex(array) == -1)
						{
							Console.WriteLine("No matches");
							continue;
						}
						Console.WriteLine(getMaxEvenIndex(array));
					}
					else
					{
						if (getMaxOddIndex(array) == -1)
						{
							Console.WriteLine("No matches");
							continue;
						}
						Console.WriteLine(getMaxOddIndex(array));
					}

				}
				else if (command[0] == "min")
				{
					if (command[1] == "even")
					{
						if (getMinEvenIndex(array) == -1)
						{
							Console.WriteLine("No matches");
							continue;
						}
						Console.WriteLine(getMinEvenIndex(array));
					}
					else
					{
						if (getMinOddIndex(array) == -1)
						{
							Console.WriteLine("No matches");
							continue;
						}
						Console.WriteLine(getMinOddIndex(array));
					}
				}
				else if (command[0] == "first")
				{
					if (int.Parse(command[1]) > array.Length && int.Parse(command[1]) < 0)
					{
						Console.WriteLine("Invalid count");
						continue;
					}
					if(command[2] == "even")
					{
						getFirstEvenNums(array, int.Parse(command[1]));

					}
					else
					{
						getFirstOddNums(array, int.Parse(command[1]));

					}
				}
				else if (command[0] == "last")
				{
					if (int.Parse(command[1]) > array.Length && int.Parse(command[1]) < 0)
					{

						Console.WriteLine("Invalid count");
						continue;
					}
					if(command[2] == "even")
					{
						getLastEvenNums(array, int.Parse(command[1]));
					}
					else
					{
						getLastOddNums(array, int.Parse(command[1]));

					}
				}
			}

			Console.WriteLine('[' + string.Join(", ", array) + ']');
		}
	}
}
