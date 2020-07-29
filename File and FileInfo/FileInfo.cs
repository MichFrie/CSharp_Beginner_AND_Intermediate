using System;
using System.IO;

namespace streams
{
	class FileThing
	{
		static void Main(string[] args)
		{
			string currentFilePath = @"c:\temp\myfile.txt", destinationFilePath = @"d:\temp\myfile2.0.txt";

			//File - for small stuff
			File.Copy(currentFilePath, destinationFilePath, true);

			if (File.Exists(destinationFilePath))
			{
				Console.WriteLine("Done!");
			}
			else
			{
				Console.WriteLine("Error!");
			}

			string content = File.ReadAllText(@"C:\Users\sasko\Downloads\icons8-calendar-96.png");
			Console.WriteLine(content);

			// FileInfo - for big shit
			FileInfo fileInfo = new FileInfo(destinationFilePath);
			Console.WriteLine(fileInfo.Length);
			fileInfo.Delete();
		}
	}
}
