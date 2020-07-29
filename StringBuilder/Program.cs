using System;
using System.Text;

namespace StringBuilder1
{
	class Program
	{
		static void Main(string[] args)
		{
			///// 1 /////
			//string str = Console.ReadLine();

			//int[] nums = Array.ConvertAll<string,int>(str.Split('-'), x => int.Parse(x));

			//bool IS = true;

			//for (int i = 0; i < nums.Length; i++)
			//{
			//	if (i > 0)
			//	{
			//		if (nums[i] - 1 == nums[i - 1] || nums[i] + 1 == nums[i - 1])
			//		{
			//			continue;
			//		}
			//		else
			//		{
			//			IS = false;
			//			break;
			//		} 
			//	}
			//}

			//if (IS)
			//	Console.WriteLine("Consecutive");
			//else
			//	Console.WriteLine("Not consecutive");
			//{

			//}

			////// 2 //////

			//string str = Console.ReadLine();

			//if (!string.IsNullOrEmpty(str))
			//{
			//	string chars = "";

			//	for (int i = 0; i < str.Length; i+=2)
			//	{
			//		if (chars.Contains(str[i]))
			//		{
			//			Console.WriteLine("Dublicate");
			//			break;
			//		}
			//		else
			//		{
			//			chars += str[i];
			//		}
			//	}

			//}


			////// 3 //////

			//string time = Console.ReadLine();
			//int[] nums = Array.ConvertAll<string, int>(time.Split(':'), x => int.Parse(x));
			//bool isValid = false;

			//if (string.IsNullOrWhiteSpace(time))
			//{
			//	isValid = false;
			//}
			//else
			//{
			//	if (nums[0] >= 0 && nums[0] < 24 && nums[1] >= 0 && nums[1] < 60 && time[2] == ':')
			//	{
			//		isValid = true;
			//	}

			//}
			//if (isValid)
			//{
			//	Console.WriteLine("valid");

			//}
			//else
			//{
			//	Console.WriteLine("Invalid");
			//}

			/////// 4 ///////

			//string str = Console.ReadLine();

			//string[] words = str.ToLower().Split();
			//var newStr = new StringBuilder();

			//foreach (var word in words)
			//{
			//	newStr.Append( word.Substring(0, 1).ToUpper() + word.Substring(1, word.Length - 1) );
			//}

			//Console.WriteLine(newStr);

			///// 5 /////

			string str = Console.ReadLine();

			int vowels = 0;

			foreach (var letter in str)
			{
				if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
				{
					vowels++;
				}
			}
			Console.WriteLine(vowels);

		}
	}
}
