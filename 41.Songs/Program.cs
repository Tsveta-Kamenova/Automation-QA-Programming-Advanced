﻿namespace _41.Songs
{
    internal class Program
    {
        public class Song
        {
            public string TypeList { get; set; }

            public string Name { get; set; }

            public string Time { get; set; }
        }


        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();


            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] songComponents = Console.ReadLine().Split("_");

                string songTypeList = songComponents[0];
                string songName = songComponents[1];
                string songTime = songComponents[2];

                Song currentSong = new Song
                { 
                    Time = songTime, 
                    TypeList = songTypeList, 
                    Name = songName, 
                };

                songs.Add(currentSong);
            }

            string typeCommand = Console.ReadLine();

           if (typeCommand == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                List<Song> filteredSongs = songs
                                        .Where(x => x.TypeList == typeCommand)
                                        .ToList();

                foreach (Song song in filteredSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }

        }
    }
}