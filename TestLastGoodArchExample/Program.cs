using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLastGoodArchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var artist = new CircusArtist(new HandsService());

            artist.GiveApples(3);
            artist.JuggleApples(3);

            artist.GiveTape();
            artist.JuggleTape();

            Console.ReadLine();
        }
    }
}
