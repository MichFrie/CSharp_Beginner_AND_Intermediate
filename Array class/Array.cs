using System;
using System.Collections.Generic;
using System.Text;

namespace Array_class
{
	class Array
	{
		private int count = 0;
		private int[] arr;
		public Array(int len = 0)
		{
			arr = new int[len];
		}

		public int indexOf(int num)
		{
			int index = -1;

			for (int i = 0; i < count; i++)
			{
				if (arr[i] == num)
				{
					index = i;
				}
			}
			return index;
		}

		public void insert(int input)
		{
			ResizeIfRequired();

			arr[count++] = input;
		}

		public void insertAt(int num, int index)
		{
			if (index < 0 || index > count)
			{
				Console.WriteLine("Cannot insert at that index!");
			}
			else
			{
				ResizeIfRequired();

				for (int i = count - 1; i >= index; i--)
				{
					arr[i + 1] = arr[i]; 
				}
				arr[index] = num;
				count++;

			}
		}

		public void removeAt(int index)
		{
			if (index < 0 || index >= count)
			{
				Console.WriteLine("Incorrect index!");
			}
			else
			{
				for (int i = index; i < count - 1; i++)
				{
					arr[i] = arr[i + 1];
				}
				arr[count - 1] = 0;
				count--;
			}
		}

		public Array reverse()
		{
			Array reversed = new Array(count);

			for (int i = count - 1; i >= 0; i--)
			{
				reversed.insert(arr[i]); 
			}

			return reversed;
		}

		public int max()
		{
			int maxNum = int.MinValue;
			for (int i = 0; i < count; i++)
			{
				if (maxNum < arr[i])
				{
					maxNum = arr[i];
				}
			}
			return maxNum;
		}

		public Array intersect(Array anotherArr)
		{
			Array intersection = new Array(count);

			foreach (var item in arr)
			{
				if (anotherArr.indexOf(item) > -1)
				{
					intersection.insert(item);
				}
			}

			return intersection;
		}

		private void ResizeIfRequired()
		{
			if (count == arr.Length)
			{
				int[] temp = arr;
				arr = new int[count * 2];

				for (int i = 0; i < temp.Length; i++)
				{
					arr[i] = temp[i]; 
				}
			}
		}

		public void print()
		{
			for(int i = 0; i < count; i++)
			{
				Console.WriteLine(arr[i]);
			}
		}
	}
}
