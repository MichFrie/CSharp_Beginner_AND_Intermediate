using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Security.Authentication;

namespace classes_and_objects
{
	class Song
	{
		public string typeList { get; set; }
		public string name { get; set; }
		public string time { get; set; }

		public Song(string type, string n, string t)
		{
			typeList = type;
			name = n;
			time = t;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			int songsCount = int.Parse(Console.ReadLine());

			List<Song> songs = new List<Song>();

			for (int i = 0; i < songsCount; i++)
			{
				string[] input = Console.ReadLine().Split("_");
				Song newSong = new Song(input[0], input[1],input[2]);
				songs.Add(newSong);
			}

			string whichAlbum = Console.ReadLine();

			List<Song> filteredSong = songs.Where(song => song.typeList == whichAlbum).ToList(); 

			if (whichAlbum == "all")
			{
				foreach (var song in songs)
				{
					Console.WriteLine(song.name); 
				}
			}
			else 
			{
				foreach (var song in filteredSong)
				{
					Console.WriteLine(song.name);
				}
			}
		}
	}
}
