using System;

namespace TDDExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var artist = new CircusArtist(new HandsService());

            artist.GiveApple();
            artist.JuggleApple();

            artist.GiveTape();
            artist.JuggleTape();

            Console.ReadLine();
        }
    }
}
