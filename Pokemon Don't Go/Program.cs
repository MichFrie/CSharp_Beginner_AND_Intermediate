using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Don_t_Go
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> lessonsSchedule = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).ToList();
			
			string input;

			while ((input = Console.ReadLine()) != "course start")
			{
				string[] command = input.Split(':',StringSplitOptions.RemoveEmptyEntries);

				if (command[0] == "Add")
				{
					if (!lessonsSchedule.Contains(command[1]))
					{
						lessonsSchedule.Add(command[1]);
					}
				}
				else if (command[0] == "Insert")
				{
					if (!lessonsSchedule.Contains(command[1]))
					{
						lessonsSchedule.Insert(int.Parse(command[2]), command[1]);
					}
				}
				else if (command[0] == "Remove")
				{
					if (lessonsSchedule.Contains(command[1]))
					{
						lessonsSchedule.Remove(command[1]);
					}
				}
				else if (command[0] == "Swap")
				{
					if (lessonsSchedule.Contains(command[1]) && lessonsSchedule.Contains(command[2]))
					{
						string temp = command[1];
						int index1 = lessonsSchedule.IndexOf(command[1]);
						int index2 = lessonsSchedule.IndexOf(command[2]);
						bool isDone = false;

						if ((index1 + 1 < lessonsSchedule.Count && lessonsSchedule[index1+1] == temp+"-Exercise") || (index2 + 1 < lessonsSchedule.Count && lessonsSchedule[index2 + 1] == command[2] + "-Exercise"))
						{
							if (lessonsSchedule[index2 + 1] == command[2] + "-Exercise" && lessonsSchedule[index1 + 1] == temp + "-Exercise")
							{
								lessonsSchedule.Remove(command[1]);
								lessonsSchedule.Remove(command[2]);
								lessonsSchedule.Remove(command[1] + "-Exercise");
								lessonsSchedule.Remove(command[2] + "-Exercise");

								lessonsSchedule.Insert(index1, command[2]);
								lessonsSchedule.Insert(index1 + 1, command[2] + "-Exercise");
								lessonsSchedule.Insert(index2, temp);
								lessonsSchedule.Insert(index2 + 1, temp + "-Exercise");

							}
							else if (lessonsSchedule[index1 + 1] == temp + "-Exercise")
							{

								lessonsSchedule.Remove(command[1]);
								lessonsSchedule.Remove(command[2]);
								lessonsSchedule.Remove(temp + "-Exercise");

								lessonsSchedule.Insert(index1, command[2]);
								lessonsSchedule.Insert(index2, temp);
								lessonsSchedule.Insert(index2 + 1, temp + "-Exercise");
							}
							else if (lessonsSchedule[index2 + 1] == command[2] + "-Exercise")
							{

								lessonsSchedule.Remove(command[1]);
								lessonsSchedule.Remove(command[2]);
								lessonsSchedule.Remove(command[2] + "-Exercise");

								lessonsSchedule.Insert(index1, command[2]);
								lessonsSchedule.Insert(index1 + 1, command[2] + "-Exercise");
								lessonsSchedule.Insert(index2 + 1, temp);
							}
							isDone = true;
						}
						
						if(!isDone)
						{
							lessonsSchedule.Remove(command[1]);
							lessonsSchedule.Remove(command[2]);
							lessonsSchedule.Insert(index1, command[2]);
							lessonsSchedule.Insert(index2, temp);
						}

					}
				}
				else if (command[0] == "Exercise")
				{
					if (!lessonsSchedule.Contains(command[1]))
					{
						lessonsSchedule.Add(command[1]);
					}
					int lessonIndex = lessonsSchedule.IndexOf(command[1]);
					string exerciseName = lessonsSchedule[lessonIndex] + "-Exercise";
					lessonsSchedule.Insert(lessonIndex + 1, exerciseName);
				}

				
			}
			for (int i = 0; i < lessonsSchedule.Count; i++)
			{
				Console.WriteLine($"{i + 1}.{lessonsSchedule[i]}");
			}
		}
	}
}
