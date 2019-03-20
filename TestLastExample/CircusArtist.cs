using System;
using Common;

namespace TestLastExample
{
    public class CircusArtist
    {
        private Hands hands;
        public int Apples { get; private set; } = 1;

        public bool HasTape { get; private set; } = true;

        public CircusArtist()
        {
            hands = new Hands();
        }
    }
}
