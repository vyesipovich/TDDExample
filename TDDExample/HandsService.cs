using Common;

namespace TDDExample
{
    public class HandsService : IHandsService
    {
        private readonly Hands hands;

        public HandsService()
        {
            hands = new Hands();
        }

        public bool CatchApple()
        {
            return hands.CatchApple();
        }

        public bool CatchTape()
        {
            return hands.CatchTape();
        }

        public bool ThrowAppleInAir()
        {
            return hands.ThrowAppleInAir();
        }

        public bool ThrowTapeInAir()
        {
            return hands.ThrowTapeInAir();
        }
    }
}
