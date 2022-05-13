using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {

        static void Main(String[] args) {

            var song1 = new Song("a", "a", 204);
            var song2 = new Song("b", "b", 340);
            var song3 = new Song("c", "c", 180);

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
            
            PrintSongs(songs);
        }
        private static void PrintSongs(List<Song> songs)//List < IEnumerable
        {
            foreach (var song in songs)
            {
                Console.WriteLine("{0},{1},{2:m\\:ss}",//分と秒のみ表示
                    song.Title,song.ArtistName,TimeSpan.FromSeconds(song.Length));

                //Console.WriteLine("{0},{1},{2}",時間まで表示（普段）
                //    song.Title, song.ArtistName, TimeSpan.FromSeconds(song.Length));

            }
        }
    }
}
