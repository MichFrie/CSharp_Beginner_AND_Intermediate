using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;

namespace StackOverpflow_Post
{
	class Page
	{
		public Dictionary<string, Post> WebPage { get; private set; } = new Dictionary<string, Post>();

		public void ListAllPosts()
		{
			if (WebPage.Count > 0)
			{
				foreach (var post in WebPage)
				{
					Console.WriteLine($"\nTitle: {post.Key}:\n   Posted on: {post.Value.DateTime}\n");
					Console.WriteLine($"\tDescription: {post.Value.Description}");
					Console.WriteLine($"\n\tVote: UP-{post.Value.UpVote}\tDOWN-{post.Value.DownVote}");
					Console.WriteLine("\n");
				} 
			}
			else
			{
				Console.WriteLine("No posts yet!\n");
			}
		}
	}
	class Post
	{
		public string Title { get; private set; }
		public string Description { get; private set; }
		public DateTime DateTime { get; private set; }

		public int UpVote { get; set; }
		public int DownVote { get; set; }


		public Post(string title, string description, DateTime dateTime)
		{
			Title = title;
			Description = description;
			DateTime = dateTime;
			UpVote = 0;
			DownVote = 0;
		}

		public void PostIt(Page page)
		{
			page.WebPage.Add(this.Title, this);
		}
	}
	class Program
	{
		private static Post CreatePost(string title, string description, DateTime dateTime)
		{ 

			return new Post(title,description,dateTime);
			
		}
		private static void Command(string[] comm, Page page)
		{
			switch (comm[0])
			{
				case "Create post":
					Console.Write("Title: ");
					string title = Console.ReadLine();

					Console.Write("Description: ");
					string description = Console.ReadLine();

					page.WebPage.Add(title, CreatePost(title, description, DateTime.Now));
					break;

				case "List posts":
					page.ListAllPosts();
					break;

				case "Up vote":
					page.WebPage[comm[1]].UpVote++;
					break;
				case "Down vote":
					page.WebPage[comm[1]].DownVote++;
					break;
				default:
					break;
			}
		}
		static void Main(string[] args)
		{
			Page javaScript = new Page();

			Console.WriteLine("Posts:\n");
			javaScript.ListAllPosts();
			
			string input;

			Console.Write("Command: ");
			while ((input = Console.ReadLine()) != "Exit")
			{
				string[] commandInput = input.Split(" -> ");
				Command(commandInput, javaScript);

				Console.Write("\nCommand: ");
			}

			
		}
	}
}
