using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace List_ex
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> strings = Console.ReadLine().Split(' ').ToList();

			string input;

			while ((input = Console.ReadLine()) != "3:1")
			{
				string[] comm = input.Split();
				if (comm[0] == "merge")
				{
					StringBuilder newStr = new StringBuilder();
					int startingIndex = int.Parse(comm[1]);
					int endingIndex = int.Parse(comm[2]);
					if (startingIndex < 0)
					{
						startingIndex = 0;
						
					}
					if (endingIndex > strings.Count-1)
					{
						if (startingIndex >= 0 && startingIndex <= strings.Count - 1)
						{
							endingIndex = strings.Count - 1;

						}
					}

					if (startingIndex >= 0 && startingIndex <= strings.Count - 1 && endingIndex >= 0 && endingIndex <= strings.Count - 1)
					{
						for (int i = startingIndex; i <= endingIndex; i++)
						{
							newStr.Append(strings[i]);

						}
						strings.RemoveRange(startingIndex, endingIndex - startingIndex + 1);
						strings.Insert(startingIndex, newStr.ToString()); 
					}
				}
				else
				{
					int strIndex = int.Parse(comm[1]);
					int count = int.Parse(comm[2]);
					
					string theStr = strings[strIndex];
					int length = theStr.Length / count;

					List<string> divided = new List<string>();

					int startIndex = 0;
					for (int i = 0; i < count; i++)
					{
						if (i == count - 1)
						{
							divided.Add(theStr.Substring(startIndex, theStr.Length - startIndex));
						}
						else
						{
							divided.Add(theStr.Substring(startIndex, length));
							startIndex += length;
						}

						
					}
					strings.RemoveAt(strIndex);
					strings.InsertRange(strIndex, divided);
					
				}
			}
			Console.WriteLine(string.Join(" ", strings));
		}
	}
}
