using System.Security.Principal;
using Utils;

namespace UnitTests
{
    public class StringAnalyticsTest
    {
        private StringAnalytics? strAnalytics = null;

        [SetUp]
        public void Setup()
        {
            const string sentence = "  One (1) quick brown,  fox jumped over two (2) lazy dogs!  ";
            strAnalytics = new StringAnalytics(sentence);
        }

        [Test]
        public void Count_Vowels()
        {
            Assert.That(strAnalytics!.Vowels, Is.EqualTo(13));
        }

        [Test]
        public void Count_Consonants()
        {
            Assert.That(strAnalytics!.Consonants, Is.EqualTo(24));
        }

        [Test]
        public void Count_Whitespace()
        {
            Assert.That(strAnalytics!.Whitespace, Is.EqualTo(15));
        }

        [Test]
        public void Count_Special_Chars()
        {
            Assert.That(strAnalytics!.Special, Is.EqualTo(6));
        }

        [Test]
        public void Count_Digits()
        {
            Assert.That(strAnalytics!.Digits, Is.EqualTo(2));
        }

        [Test]
        public void Count_Words()
        {
            Assert.That(strAnalytics!.Words, Is.EqualTo(11));
        }
    }
}

