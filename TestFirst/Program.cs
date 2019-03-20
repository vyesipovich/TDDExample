using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFirstExample
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
