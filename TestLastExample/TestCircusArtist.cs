using NUnit.Framework;

namespace TestLastExample
{
    [TestFixture]
    public class TestCircusArtist
    {
        [Test]
        public void When_CircusArtist_JuggleApple_He_Has_Apple()
        {
            var artist = new CircusArtist();
            artist.JuggleApple();

            Assert.AreEqual(artist.Apples, 1);
        }

        [Test]
        public void When_CircusArtist_JuggleTape_He_Has_Tape()
        {
            var artist = new CircusArtist();
            artist.JuggleTape();

            Assert.IsTrue(artist.HasTape);
        }
    }
}
