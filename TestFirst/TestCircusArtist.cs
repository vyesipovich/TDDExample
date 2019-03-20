using System;
using Moq;
using Moq.Sequences;
using NUnit.Framework;

namespace TestFirstExample
{
    [TestFixture]
    public class TestCircusArtist
    {
        [Test]
        public void CircusArtistHasApples()
        {
            var handsService = new Mock<IHandsService>();

            var artist = new CircusArtist(handsService.Object);
            artist.GiveApples(2);

            Assert.AreEqual(artist.Apples, 2);
        }

        [Test]
        public void CircusArtistHasTape()
        {
            var handsService = new Mock<IHandsService>();

            var artist = new CircusArtist(handsService.Object);
            artist.GiveTape();

            Assert.IsTrue(artist.HasTape);
        }
    }
}