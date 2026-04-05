class SayaMusicTrack
{
    private int id;
    private int playCount;
    private string title;

    public SayaMusicTrack(string title)
    {
        Random random = new Random();
        this.id = random.Next(1000, 10000);
        this.playCount = 0;
        this.title = title;
    }

    public void IncreasePlayCount(int count)
    {
        if(count >= 0) { 
            playCount += count;
        }
        else
        {
            Console.WriteLine("Play count cannot be negative or zero.");
        }
    }

    public void PrintTrackDetails()
    {
        Console.WriteLine("========== Track Details ==========");
        Console.WriteLine($"ID          : {this.id}");
        Console.WriteLine($"Title       : {this.title}");
        Console.WriteLine($"Play Count  : {this.playCount}");
        Console.WriteLine("===================================\n");
    }
}