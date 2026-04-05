class Program
{
    static void Main(string[] args)
    {
        SayaMusicTrack laguFavorit = new SayaMusicTrack("Machine Love");

        laguFavorit.PrintTrackDetails();
        laguFavorit.IncreasePlayCount(163);
        laguFavorit.PrintTrackDetails();

    }
}