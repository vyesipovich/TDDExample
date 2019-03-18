using System;

namespace TDDExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var artist = new CircusArtist(new HandsService());

            artist.GiveApples(7);
            artist.JuggleApples(5);

            artist.GiveTape();
            artist.JuggleTape();

            Console.ReadLine();
        }
    }
}
