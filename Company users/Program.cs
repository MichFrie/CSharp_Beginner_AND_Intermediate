using System;
using System.Collections.Generic;
using System.Linq;

namespace Company_users
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
			string input;

			while ((input = Console.ReadLine()) != "End")
			{
				string[] comm = input.Split(" -> ");

				if (companies.ContainsKey(comm[0]))
				{
					if ( !companies[comm[0]].Contains(comm[1]) )
					{
						companies[comm[0]].Add(comm[1]); 
					}
				}
				else
				{
					companies.Add( comm[0], new List<string> { comm[1] } );
				}
			}

			companies = companies.OrderBy(com => com.Key)
				.ToDictionary(c => c.Key, c => c.Value);

			foreach (var company in companies)
			{
				Console.WriteLine(company.Key);
				foreach (var user in company.Value)
				{
					Console.WriteLine($"-- {user}");
				}
			}
		}
	}
}
