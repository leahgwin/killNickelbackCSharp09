using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make sure that some of the songs are from the band Nickelback.You can see a list of their greatest hits on Amazon.
            // Once the set is populated with 7 tuples, iterate over the set of songs, and check if the band name is "Nickelback".
            // If the band is not Nickelback, then add it to the goodSongs list.
            // USe another foreach loop to print out all the good songs.

            // Define a List, named goodSongs, that will hold tuples consisting of two strings.
            List<(string item, string item2)> goodSongs = new List<(string, string)>();

            // Define a HashSet, named allSongs, that contains 7 tuples.Each tuple should contain two string values:
            // The name of an artist
            // A song by that artist
            HashSet<(string, string)> allSongs = new HashSet<(string, string)>()
            {
          ("Photograph", "Nickelback"),
          ("Far Away", "Nickelback"),
          ("Should've Said No", "Taylor Swift"),
          ("Over", "Thirdstory"),
          ("This is America", "Childish Gambino"),
          ("If Today Was Your Last Day", "Nickelback"),
          ("Sure Thing", "Miguel")

            };





        }
    }
}
