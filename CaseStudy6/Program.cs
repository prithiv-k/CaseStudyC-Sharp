using System;

class Program
{
    static void Main()
    {
        MyPlayList playlist = new MyPlayList();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nEnter your choice:");
            Console.WriteLine("1. Add Song");
            Console.WriteLine("2. Remove Song by ID");
            Console.WriteLine("3. Get Song by ID");
            Console.WriteLine("4. Get Song by Name");
            Console.WriteLine("5. Get All Songs");
            Console.WriteLine("6. Exit");
            Console.Write("Choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Song song = new Song();
                    Console.Write("Enter Song ID: ");
                    song.SongId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Song Name: ");
                    song.SongName = Console.ReadLine();
                    Console.Write("Enter Song Genre: ");
                    song.SongGenre = Console.ReadLine();
                    playlist.Add(song);
                    break;

                case 2:
                    Console.Write("Enter Song ID to remove: ");
                    int removeId = Convert.ToInt32(Console.ReadLine());
                    playlist.Remove(removeId);
                    break;

                case 3:
                    Console.Write("Enter Song ID to search: ");
                    int searchId = Convert.ToInt32(Console.ReadLine());
                    var resultById = playlist.GetSongById(searchId);
                    Console.WriteLine(resultById != null ? resultById.ToString() : "Song not found.");
                    break;

                case 4:
                    Console.Write("Enter Song Name to search: ");
                    string name = Console.ReadLine();
                    var resultByName = playlist.GetSongByName(name);
                    Console.WriteLine(resultByName != null ? resultByName.ToString() : "Song not found.");
                    break;

                case 5:
                    var allSongs = playlist.GetAllSongs();
                    Console.WriteLine("Songs in Playlist:");
                    foreach (var s in allSongs)
                        Console.WriteLine(s);
                    break;

                case 6:
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}
