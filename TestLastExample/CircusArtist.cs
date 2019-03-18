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

        private void ThrowTapeInAir()
        {
            hands.ThrowTapeInAir();
            HasTape = false;
            Console.WriteLine("I thrown tape in the air!");
        }

        private void CatchTape()
        {
            hands.CatchTape();
            HasTape = true;
            Console.WriteLine("I caught tape!");
        }

        private void ThrowAppleInAir()
        {
            hands.ThrowAppleInAir();
            Apples--;
            Console.WriteLine("I thrown apple in the air!");
        }

        private void CatchApple()
        {
            hands.CatchApple();
            Apples++;
            Console.WriteLine("I caught apple!");
        }

        public bool JuggleApple()
        {
            CatchApple();
            ThrowAppleInAir();

            Console.WriteLine("Tadaaam!");
            return true;
        }

        public bool JuggleTape()
        {
            ThrowAppleInAir();
            CatchTape();

            Console.WriteLine("Tadaaam!");
            return true;
        }
    }
}
