using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WordCounter.Models
{
    [TestClass]
    public class RepeatCounterTests
    {
        [TestMethod]
        public void ValidInput_True()
        {
            bool output = RepeatCounter.ValidInput("brain");
            Assert.AreEqual
            (true, output);
        }

        [TestMethod]
        public void characterCount_FullWordsOnly_0()
        {
            RepeatCounter newCounter = new RepeatCounter("brain", "brainstorm");
            int output = newCounter.characterCount();
            Assert.AreEqual(0, output);
        }

        [TestMethod]
        public void Count_WordCounterNoSpecialCharacters_3()
        {
            RepeatCounter newCounter = new RepeatCounter("brain", "The brain is like a muscle I like to call super brain and it goes to the brain gym.");
            int output = newCounter.characterCount();
            Assert.AreEqual(3, output);
        }

        [TestMethod]
        public void Count_WordCounterSpecialCharacters_3()
        {
            RepeatCounter newCounter = new RepeatCounter("brain", "The brain is like a muscle, a strong one I like to call super brain, but it needs brain care. | The word 'brain' appears 3 time(s) in your sentence.");
            int output = newCounter.characterCount();
            Assert.AreEqual(3, output);
        }
    }
}