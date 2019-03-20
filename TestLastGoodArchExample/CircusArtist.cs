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
    }
}