using System;

namespace Program
{
    class Song
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("MusicPlaylistAnalyzer <music_playlist_file_path> <report_file_path>");
                Environment.Exit(1);
            }

            if (File.Exists($"SampleMusicPlaylist.txt") == false)

            {

                Console.WriteLine("SampleMusicPlaylist text file cannot be opened ");

            }

            else

            {
                StreamReader sr = new StreamReader($"SampleMusicPlaylist.txt");
            }

            override public string ToString()
        {
            return String.Format("Name: {0}, Artist: {1}, Album: {2}, Genre: {3}, Size: " +
                "{4}, Time: {5}, Year: {6}, Plays: {7}", Name, Artist, Album, Genre, Size, Time, Year, Plays);
        }

        Console.Writeline("How many songs received 200 or more plays?");
            var SongPlays = from song in songs where song.Plays >= 200 select song;
            foreach (var Song in SongPlays)
            {
               report += ("Songs That Received 200 Or More Plays: "); 
            }

    Console.Writeline("How many songs are in the playlist with the Genre of “Alternative?");
           
        var SongsGenreAlternative = from song in songs where song.Genre == "Alternative" select song;
            foreach (var Song in SongsGenreAlternative)
            {
            report += ("Number Of Songs That Are In The Playlist With The Genre Of “Alternative: {i}\n");
            }   

            Console.Writeline("How many songs are in the playlist with the Genre of “Hip-Hop/Rap?");
            var SongsGenreHipHopRap = from song in songs where song.Genre == "Hip-Hop/Rap" select song;
            foreach (var Song in SongsGenreHipHopRap)
            {
            report += ("Number Of Songs That Are In The PlayList With The Genre Of Hip-Hop/Rap: {i}\n)";
            }

            Console.Writeline("What songs are in the playlist from the album “Welcome to the Fishbowl?");
            var SongsAlbumFishbowl = from song in songs where song.Album == ("Welcome to the Fishbowl");
            foreach (var Song in SongsAlbumFishbowl)
            {
            report += ("Songs That Are In The Playlist From The Album Welcome To The Fishbowl: {i}\n");
            }

            Console.Writeline("What are the songs in the playlist from before 1970?");
            var Songs1970 = from song in songs where song.Year < 1970 select song;
            foreach (var Song in Songs1970)
            {
            report += ("Songs That Are In The Playlist From Before 1970:\n");
            }

            Console.Writeline("What are the song names that are more than 85 characters long?");
            var Names85Characters = from song in songs where song.Name.Length > 85 select song.Name;
            foreach (var Song in Names85Characters)
            {
            report += "Songs That Are More Than 85 Characters Long:\n";
            }

            Console.Writeline("What is the longest song?");
            var LongestSong = from song in songs orderby song.Time descending select song;
            foreach (var Song in LongestSong)
            {
            report += ("Longest Song (In Time):\n");
            }



         