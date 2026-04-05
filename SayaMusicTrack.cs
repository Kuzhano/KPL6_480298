using System;
using System.Diagnostics;

class SayaMusicTrack
{
    private int id;
    private int playCount;
    private string title;

    public SayaMusicTrack(string title)
    {
        Debug.Assert(title != null, "Judul tidak boleh null.");
        Debug.Assert(title.Length <= 100, "Judul maksimal 100 karakter.");

        Random random = new Random();
        this.id = random.Next(1000, 10000);
        this.playCount = 0;
        this.title = title;
    }

    public void IncreasePlayCount(int count)
    {
  
        Debug.Assert(count <= 10000000, "Penambahan play count maksimal 10.000.000.");
        Debug.Assert(count >= 0, "Penambahan tidak boleh negatif.");

        try
        {
            checked
            {
                this.playCount += count;
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"[ERROR] Terjadi Overflow: {ex.Message}");
            throw;
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