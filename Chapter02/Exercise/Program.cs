using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {

        static void Main(String[] args) {

            var song1 = new Song("a", "a", 9);
            var song2 = new Song("a", "a", 9);
            var song3 = new Song("a", "a", 9);

            var songs = new List<Song>();
            songs.Add(song1);
            songs.Add(song2);
            songs.Add(song3);

            //var songs = new Song[] {
            //    new Song("a", "a", 9),
            //    new Song("a", "a", 9),
            //    new Song("a", "a", 9),
            //    new Song("a", "a", 9),
            //    new Song("a", "a", 9),
            //};

           // PrintSongs(songs);
        }
        //private static void PrintSongs(List<Song> songs)
        //{
        //    foreach (var song in songs)
        //    {

        //        Console.WriteLine("[{0}]", (",", songs));
        //    }
        //}
    }
}
