using System;
using System.IO;

namespace Directory_and_DirectoryInfo
{
	class Program
	{
		static void Main(string[] args)
		{
			// Directory - for small things
			var path = @"d:\C# console";
			
			var files = Directory.GetFiles(path, "*.cs", SearchOption.AllDirectories);
			Console.WriteLine(files.Length);

			var directories = Directory.GetDirectories(@"d:\");

			foreach (var dir in directories)
			{
				Console.WriteLine(dir);
			}

			// DirectoryInfo - for big things

			DirectoryInfo dirInfo = new DirectoryInfo(path);

			foreach (var item in dirInfo.GetFiles())
			{
				Console.WriteLine(item);
			}

			Console.WriteLine();

			foreach (var item in dirInfo.GetDirectories())
			{
				Console.WriteLine(item);
			}
		}
	}
}
