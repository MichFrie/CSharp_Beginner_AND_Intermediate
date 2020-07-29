using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.PortableExecutable;
using System.Text;

namespace objectsAndClasses
{
	class Team
	{
		public string Creator { get; set; }
		public string Name { get; set; }
		public List<string> members { get; set; }
		public Team(string c, string n)
		{
			Creator = c;
			Name = n;
			members = new List<string>();
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());
			List<string> teamNames = new List<string>();
			List<string> teamMembers = new List<string>();

			List<Team> teams = new List<Team>();

			// Creating Teams
			for (int i = 0; i < count; i++)
			{
				string[] input = Console.ReadLine().Split('-');
				Team t = new Team(input[0],input[1]);
				if (!teamNames.Contains(t.Name) && !teamMembers.Contains(input[0]))
				{
					teamMembers.Add(input[0]);
					teamNames.Add(t.Name);

					teams.Add(t);
					Console.WriteLine($"Team { t.Name} has been created by { input[0]}!"); 
				}
				else if (teamNames.Contains(t.Name))
				{
					Console.WriteLine($"Team {t.Name} was already created!");
				}
				else if (teamMembers.Contains(input[0]))
				{
					Console.WriteLine($"{input[0]} cannot create another team!");
				}
			}

			string it;
			while ((it = Console.ReadLine()) != "end of assignment")
			{
				string memberName = it.Split("->")[0];
				string teamName = it.Split("->")[1];
				Team teamForAss = null;

				foreach (var a in teams)
				{
					if (a.Name == teamName)
					{
						teamForAss = a;
					}
				}

				if (!teamNames.Contains(teamName))
				{
					Console.WriteLine($"Team {teamName} does not exist!");
				}
				else if (teamMembers.Contains(memberName))
				{
					Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
				}
				else if(teamNames.Contains(teamName) && !teamMembers.Contains(memberName))
				{
					
					
					teamForAss.members.Add(memberName);
					teamMembers.Add(memberName);
				}
			}

			List<Team> teamsToDisband = new List<Team>();
			for (int i = 0; i < teams.Count; i++)
			{
				if (teams[i].members.Count == 0)
				{
					teamsToDisband.Add(teams[i]);
					teams.Remove(teams[i]);
					i = -1;
				}
			}
			teams = teams.OrderByDescending(team => team.members.Count).ThenBy(team => team.Name).ToList();
			teamsToDisband = teamsToDisband.OrderBy(team => team.Name).ToList();

			foreach (var t in teams)
			{
				t.members = t.members.OrderBy(n => n).ToList();
			}
			foreach (var team in teams)
			{
				Console.WriteLine(team.Name);
				Console.WriteLine($"- {team.Creator}");
				foreach (var m in team.members)
				{
					Console.WriteLine($"-- {m}");
				}
			}

			Console.WriteLine("Teams to disband:");
			foreach (var team in teamsToDisband)
			{
				Console.WriteLine(team.Name);
			}
		}
	}
}
