class Program
{
    static void Main(string[] args)
    {
        SayaMusicTrack laguFavorit = new SayaMusicTrack("Machine Love");

        Console.WriteLine("=== Testing Normal Input ==="); //1
        laguFavorit.IncreasePlayCount(163);
        laguFavorit.PrintTrackDetails();

        Console.WriteLine("\n=== Testing Negative Input ==="); //2
        try
        {
            for (int i = 0; i < 300; i++)
            {

                laguFavorit.IncreasePlayCount(10000000);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("\n=== Testing Precondition ==="); //3
        string longTitle = new string('A', 105);
        SayaMusicTrack lagu2 = new SayaMusicTrack(longTitle);

        Console.WriteLine("\nProgram tetap berjalan berkat try-catch.");
        Console.ReadLine();
    }
}