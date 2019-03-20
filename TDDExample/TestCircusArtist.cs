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
            var handsService = new Mock<IHandsService>();

            var artist = new CircusArtist(handsService.Object);
            artist.GiveApple();

            Assert.AreEqual(artist.Apples, 1);
        }

        [Test]
        public void CircusArtistHasTape()
        {
            var handsService = new Mock<IHandsService>();

            var artist = new CircusArtist(handsService.Object);
            artist.GiveTape();

            Assert.IsTrue(artist.HasTape);
        }

        [Test]
        public void When_CircusArtist_JuggleTape_He_Throws_And_Catch_Only_Tape()
        {
            var handsService = new Mock<IHandsService>(MockBehavior.Strict);
            var sequence = new MockSequence();
            handsService.InSequence(sequence).Setup(x => x.ThrowTapeInAir()).Returns(true);
            handsService.InSequence(sequence).Setup(x => x.CatchTape()).Returns(true);
            var artist = new CircusArtist(handsService.Object);
            artist.GiveTape();

            var result = artist.JuggleTape();

            handsService.Verify(x => x.ThrowTapeInAir(), Times.Once);
            handsService.Verify(x => x.CatchTape(), Times.Once);
            handsService.Verify(x => x.ThrowAppleInAir(), Times.Never);
            handsService.Verify(x => x.CatchApple(), Times.Never);
            Assert.AreEqual(result, true);
            Assert.IsTrue(artist.HasTape);
        }

        [Test]
        public void When_CircusArtist_JuggleApple_He_Throws_And_Catch_Only_Apple()
        {
            var handsService = new Mock<IHandsService>(MockBehavior.Strict);
            var sequence = new MockSequence();
            handsService.InSequence(sequence).Setup(x => x.ThrowAppleInAir()).Returns(true);
            handsService.InSequence(sequence).Setup(x => x.CatchApple()).Returns(true);

            var artist = new CircusArtist(handsService.Object);
            artist.GiveApple();

            var result = artist.JuggleApple();

            handsService.Verify(x => x.ThrowAppleInAir(), Times.Once);
            handsService.Verify(x => x.CatchApple(), Times.Once);
            handsService.Verify(x => x.ThrowTapeInAir(), Times.Never);
            handsService.Verify(x => x.CatchTape(), Times.Never);
            Assert.AreEqual(result, true);
            Assert.AreEqual(artist.Apples, 1);
        }
    }
}