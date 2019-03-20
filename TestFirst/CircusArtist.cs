using System;

namespace TestFirstExample
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        private void ThrowTapeInAir()
        {
            throw new NotImplementedException();
        }

        private void CatchTape()
        {
            throw new NotImplementedException();
        }

        public bool JuggleApple()
        {
            throw new NotImplementedException();
        }

        public bool JuggleApples(int applesToJuggle)
        {
            throw new NotImplementedException();
        }


        public bool JuggleTape()
        {
            throw new NotImplementedException();
        }
    }
}