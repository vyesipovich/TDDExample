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
            artist.GiveApples(1);

            var result = artist.JuggleApple();

            handsService.Verify(x => x.ThrowAppleInAir(), Times.Once);
            handsService.Verify(x => x.CatchApple(), Times.Once);
            handsService.Verify(x => x.ThrowTapeInAir(), Times.Never);
            handsService.Verify(x => x.CatchTape(), Times.Never);
            Assert.AreEqual(result, true);
            Assert.AreEqual(artist.Apples, 1);
        }

        [TestCase(1)]
        [TestCase(3)]
        [TestCase(5)]
        public void When_CircusArtist_JuggleApples_He_Throws_And_Catch_Only_Apples(int applesToJuggle)
        {
            var handsService = new Mock<IHandsService>();

            using (Sequence.Create())
            {
                handsService.Setup(x => x.ThrowAppleInAir()).InSequence(Times.Exactly(applesToJuggle)).Returns(true);
                handsService.Setup(x => x.CatchApple()).InSequence(Times.Exactly(applesToJuggle)).Returns(true);

                var artist = new CircusArtist(handsService.Object);
                artist.GiveApples(applesToJuggle);

                var result = artist.JuggleApples(applesToJuggle);

                handsService.Verify(x => x.ThrowAppleInAir(), Times.Exactly(applesToJuggle));
                handsService.Verify(x => x.CatchApple(), Times.Exactly(applesToJuggle));
                handsService.Verify(x => x.ThrowTapeInAir(), Times.Never);
                handsService.Verify(x => x.CatchTape(), Times.Never);
                Assert.AreEqual(result, true);
                Assert.AreEqual(artist.Apples, applesToJuggle);
            }
        }

        [Test]
        public void When_CircusArtist_Try_Juggle_More_Apples_That_he_Has_Throws_InvalidOperationException()
        {
            var handsService = new Mock<IHandsService>();

            handsService.Setup(x => x.ThrowAppleInAir()).Returns(true);
            handsService.Setup(x => x.CatchApple()).Returns(true);

            var artist = new CircusArtist(handsService.Object);
            artist.GiveApples(1);

            Assert.Throws<InvalidOperationException>(() => artist.JuggleApples(3));
        }
    }
}