using System;
using System.Globalization;
using System.Linq;

namespace arrays_ex
{
	class Program
	{
		static void Main(string[] args)
		{
			int fieldSize = int.Parse(Console.ReadLine());
			int[] field = new int[fieldSize];

			int[] lbugsPositions = Console.ReadLine().Split().Select(int.Parse).ToArray();

			for (int i = 0; i < lbugsPositions.Length; i++)
			{
				if (lbugsPositions[i] < fieldSize && lbugsPositions[i] >= 0)
				{
					field[lbugsPositions[i]] = 1;
				}
			}
			string input = Console.ReadLine();
			while ( input != "end" )
			{
				string[] command = input.Split();
				int lbugIndexStart = int.Parse(command[0]);
				string direction = command[1];
				int flyDistance = int.Parse(command[2]);

				if (lbugIndexStart < fieldSize && lbugIndexStart >= 0)
				{
					if (field[lbugIndexStart] == 1)
					{
						if (direction == "right")
						{
							if (flyDistance < 0)
							{
								field[lbugIndexStart] = 0;
								flyDistance = Math.Abs(flyDistance);


								if (lbugIndexStart - flyDistance >= 0)
								{
									if (field[lbugIndexStart - flyDistance] == 1)
									{
										if (lbugIndexStart - flyDistance - flyDistance >= 0)
										{
											field[lbugIndexStart - flyDistance - flyDistance] = 1;
										}
									}
									else
									{
										field[lbugIndexStart - flyDistance] = 1;
									}
								}
							}
							else
							{
								field[lbugIndexStart] = 0;

								if (lbugIndexStart + flyDistance < fieldSize)
								{
									if (field[lbugIndexStart + flyDistance] == 1)
									{
										if (lbugIndexStart + flyDistance + flyDistance < fieldSize)
										{
											field[lbugIndexStart + flyDistance + flyDistance] = 1;
										}
									}
									else
									{
										field[lbugIndexStart + flyDistance] = 1;
									}
								}
							}
						}
						else
						{
							if (flyDistance < 0)
							{
								field[lbugIndexStart] = 0;
								flyDistance = Math.Abs(flyDistance);

								if (lbugIndexStart + flyDistance < fieldSize)
								{
									if (field[lbugIndexStart + flyDistance] == 1)
									{
										if (lbugIndexStart + flyDistance + flyDistance < fieldSize)
										{
											field[lbugIndexStart + flyDistance + flyDistance] = 1;
										}
									}
									else
									{
										field[lbugIndexStart + flyDistance] = 1;
									}
								}
							}
							else
							{
								field[lbugIndexStart] = 0;

								if (lbugIndexStart - flyDistance >= 0)
								{
									if (field[lbugIndexStart - flyDistance] == 1)
									{
										if (lbugIndexStart - flyDistance - flyDistance >= 0)
										{
											field[lbugIndexStart - flyDistance - flyDistance] = 1;
										}
									}
									else
									{
										field[lbugIndexStart - flyDistance] = 1;
									}
								}
							}
						}
					} 
				}

				input = Console.ReadLine();
			}

			Console.WriteLine(string.Join(" ", field));
		}
	}
}
