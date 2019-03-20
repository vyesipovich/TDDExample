using System;
using Moq;
using Moq.Sequences;
using NUnit.Framework;

namespace TDDExample
{
    [TestFixture]
    public class TestCircusArtist
    {
        [Test]
        public void CircusArtistHasApples()
        {
            var artist = new CircusArtist();
            artist.GiveApple();
        }
    }
}