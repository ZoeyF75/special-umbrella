using System;

public class Song
{
    private string name;
    public Song NextSong { get; set; }
 
    public Song(string name)
    {
        this.name = name;
    }
    
    public bool IsRepeatingPlaylist()
    {
        var tortoise = this;
        var hare = NextSong;

        while (tortoise is not null && hare is not null)
        {
        if (ReferenceEquals(tortoise, hare))
            return true;

        tortoise = tortoise.NextSong;
        hare = hare.NextSong?.NextSong;
        }

        return false;
        
        
        
        throw new InvalidOperationException("Waiting to be implemented.");
    }
    
    public static void Main(string[] args)
    {
        Song first = new Song("Hello");
        Song second = new Song("Eye of the tiger");
    
        first.NextSong = second;
        second.NextSong = first;
    
        Console.WriteLine(first.IsRepeatingPlaylist());
    }
}