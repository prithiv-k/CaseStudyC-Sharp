using System;
using System.Collections.Generic;
using System.Linq;

public class MyPlayList : IPlaylist
{
    public static List<Song> myPlayList = new List<Song>();
    private const int maxCapacity = 20;

    public MyPlayList()
    {
    }

    public void Add(Song song)
    {
        if (myPlayList.Count >= maxCapacity)
        {
            Console.WriteLine("Cannot add more than 20 songs to the playlist.");
            return;
        }

        if (!IsValidGenre(song.SongGenre))
        {
            Console.WriteLine("Invalid genre. Allowed genres: Pop, HipHop, Soul Music, Jazz, Rock, Disco, Melody, Classic");
            return;
        }

        myPlayList.Add(song);
        Console.WriteLine("Song added successfully.");
    }

    public void Remove(int songId)
    {
        var song = GetSongById(songId);
        if (song != null)
        {
            myPlayList.Remove(song);
            Console.WriteLine("Song removed successfully.");
        }
        else
        {
            Console.WriteLine("Song ID not found.");
        }
    }

    public Song GetSongById(int songId)
    {
        return myPlayList.FirstOrDefault(s => s.SongId == songId);
    }

    public Song GetSongByName(string songName)
    {
        return myPlayList.FirstOrDefault(s => s.SongName.Equals(songName, StringComparison.OrdinalIgnoreCase));
    }

    public List<Song> GetAllSongs()
    {
        return myPlayList;
    }

    private bool IsValidGenre(string genre)
    {
        string[] validGenres = { "Pop", "HipHop", "Soul Music", "Jazz", "Rock", "Disco", "Melody", "Classic" };
        return validGenres.Contains(genre, StringComparer.OrdinalIgnoreCase);
    }
}
