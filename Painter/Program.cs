using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painter
{
	class Program
	{
		static void Main(string[] args)
		{
			string BestWord = "";
			int bestWordPower = 0;

			string input = "";
			while ("End of words" != (input = Console.ReadLine()))
			{
				double Currentpower = 0;
				for (int i = 0; i < input.Length; i++)
				{
					Currentpower += input[i];
				}
				
				switch (input[0].ToString())
				{
					case "A":
						Currentpower *= input.Length;
						break;
					case "a":
						Currentpower *= input.Length;
						break;
					case "E":
						Currentpower *= input.Length;
						break;
					case "e":
						Currentpower *= input.Length;
						break;
					case "I":
						Currentpower *= input.Length;
						break;
					case "i":
						Currentpower *= input.Length;
						break;
					case "U":
						Currentpower *= input.Length;
						break;
					case "u":
						Currentpower *= input.Length;
						break;
					case "O":
						Currentpower *= input.Length;
						break;
					case "o":
						Currentpower *= input.Length;
						break;
					case "Y":
						Currentpower *= input.Length;
						break;
					case "y":
						Currentpower *= input.Length;
						break;
					default: Currentpower = Math.Floor(Currentpower / input.Length);
						break;
					
				}

				if (bestWordPower < Currentpower)
				{
					bestWordPower = (int)Currentpower;
					BestWord = input;
				}
				else
				{
					continue;
				}
			}

			Console.WriteLine(" The most powerful word is {0} - {1}", BestWord,bestWordPower);

			Console.ReadKey();
		}
	}
}
