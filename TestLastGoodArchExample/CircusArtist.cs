using System;

namespace TestLastGoodArchExample
{
    internal class CircusArtist
    {
        private readonly IHandsService handsService;

        public int Apples { get; private set; }

        public bool HasTape { get; private set; }

        public CircusArtist(IHandsService handsService)
        {
            this.handsService = handsService;
        }

        private void ThrowAppleInAir()
        {
            if (Apples <= 0) throw new InvalidOperationException("Give me apples first!");

            handsService.ThrowAppleInAir();
            Apples--;
            Console.WriteLine("I thrown apple in the air!");
        }

        public void GiveApples(int apples)
        {
            this.Apples = apples;
        }

        public void GiveTape()
        {
            this.HasTape = true;
        }

        private void CatchApple()
        {
            handsService.CatchApple();
            Apples++;
            Console.WriteLine("I caught apple!");
        }

        private void ThrowTapeInAir()
        {
            handsService.ThrowTapeInAir();
            HasTape = false;
            Console.WriteLine("I thrown tape in the air!");
        }

        private void CatchTape()
        {
            handsService.CatchTape();
            HasTape = true;
            Console.WriteLine("I caught tape!");
        }

        /// <summary>
        /// Will be removed after we added method for juggling many apples.
        /// </summary>
        /// <returns></returns>
        public bool JuggleApple()
        {
            ThrowAppleInAir();
            CatchApple();

            Console.WriteLine("Tadaaam!");
            return true;
        }

        public bool JuggleApples(int applesToJuggle)
        {
            if (Apples < applesToJuggle) throw new InvalidOperationException("I haven't enough apples to juggle");

            for (var i = 0; i < applesToJuggle; i++)
            {
                ThrowAppleInAir();
            }

            for (var i = 0; i < applesToJuggle; i++)
            {
                CatchApple();
            }

            Console.WriteLine("Tadaaam!");
            return true;
        }


        public bool JuggleTape()
        {
            ThrowTapeInAir();
            CatchTape();

            Console.WriteLine("Tadaaam!");
            return true;
        }
    }
}