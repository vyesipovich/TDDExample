using System;

namespace TestLastGoodArchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var artist = new CircusArtist(new HandsService());

            artist.GiveApples(3);
            artist.JuggleApples(3);
            Console.ReadLine();
        }
    }
}
