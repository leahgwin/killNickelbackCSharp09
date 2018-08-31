using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {


            // Define a List, named goodSongs, that will hold tuples consisting of two strings.
            List<(string item, string item2)> goodSongs = new List<(string, string)>();

            // Define a HashSet, named allSongs, that contains 7 tuples.Each tuple should contain two string values:
            // The name of an artist
            // A song by that artist
            HashSet<(string songName, string artistName)> allSongs = new HashSet<(string, string)>()
            {
          ("Photograph", "Nickelback"),
          ("Far Away", "Nickelback"),
          ("Dress", "Taylor Swift"),
          ("Over", "Thirdstory"),
          ("This is America", "Childish Gambino"),
          ("If Today Was Your Last Day", "Nickelback"),
          ("Sure Thing", "Miguel")
            };

            // Once the set is populated with 7 tuples, iterate over the set of songs, and check if the band name is "Nickelback".
            // If the band is not Nickelback, then add it to the goodSongs list.

            foreach ((string songName, string artistName) song in allSongs)
            {
                if (song.artistName != "Nickelback")
                {
                    goodSongs.Add((song));
                }
            };
            // USe another foreach loop to print out all the good songs.
            foreach ((string songName, string artistName) song in goodSongs)
            {
                Console.WriteLine($"I really like the song, {song.songName}, by {song.artistName}!");
            }

        }
    }
}
