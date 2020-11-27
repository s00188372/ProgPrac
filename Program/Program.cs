using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Song s1 = new Song("Beautiful People", "Ed Sheeran", 3.15, Genre.Pop);
            Song s2 = new Song("Ride It", "Regard", 3.37, Genre.Dance);
            Song s3 = new Song("Dance Monkey", "Tones & I", 4.20, Genre.Dance);
            Song s4 = new Song("Circles", "Post Malone", 3.25, Genre.Pop);
            Song s5 = new Song("South Of The Border", "Ed Sheeran", 4.26, Genre.Other);

            List<Song> playlist = new List<Song>();

            playlist.Add(s1);
            playlist.Add(s2);
            playlist.Add(s3);
            playlist.Add(s4);
            playlist.Add(s5);

            Display(playlist);



        }
        private static void Display(List<Song> playlist)
        {
            WriteLine("{0,-20}{1,-25}{2,-10}{3,-10}", "Artist","Song","Duration", "Genre");

            foreach (Song song in playlist)
            {
                WriteLine($"{song.Artist,-20}{song.Title,-25}{song.Duration,-10}{song.MusicGenre,-10}");
            }

        }
    }
}
