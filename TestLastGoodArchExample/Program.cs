using System;

namespace TestLastGoodArchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var artist = new CircusArtist(new HandsService());

            Console.ReadLine();
        }
    }
}
