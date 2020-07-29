using System;
using System.IO;

namespace Path_stream
{
	class Program
	{
		static string GetText(string path)
		{
			return File.ReadAllText(path);
		}

		static string FindBiggest(string text)
		{
			string[] words = text.Split(' ');
			int max = int.MinValue;
			string biggestStr = words[0];

			for (int i = 0; i < words.Length; i++)
			{
				if (max < words[i].Length)
				{
					biggestStr = words[i];
					max = words[i].Length;
				}
			}

			return biggestStr;
		}
		static void Main(string[] args)
		{
			string filePath = @"D:\temp\myfile2.0.txt";
			///  1  ///
			
			//Console.WriteLine(CountWords(GetText(filePath)));

			Console.WriteLine(FindBiggest(GetText(filePath)));
		}
	}
}
