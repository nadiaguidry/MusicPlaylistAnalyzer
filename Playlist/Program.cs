using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace MusicPlaylistAnalyzer
    {
        class Program
        {
            public string Name;
            public string Artist;
            public string Genre;
            public string Album;
            public int Size;
            public int Time;
            public int Year;
            public int Plays;

            public Program (string name, string artist, string genre,
                string album, int size, int time, int year, int plays);
        {

            Name = name;
            Artist = artist;
            Genre = genre;
            Album = album;
            Size = size;
            Time = time;
            Year = year;
            Plays = plays;
            }




    }
}
