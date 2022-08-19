using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace MoodAnalyserMSTest
{
    [TestClass]
    public class MoodAnalyserTest
    {
        [TestMethod]
        public void GivenSadMoodShouldReturnSad()
        {
            string excepted = "SAD";
            string message = "I am in SAD Mood";
            MoodAnalyserClass moodAnalyser = new MoodAnalyserClass(message);

            string mood = moodAnalyser.AnalyseMood();

            Assert.AreEqual(excepted, mood);

        }


        [TestMethod]
        public void GivenAnyMoodShouldReturnHappy()
        {
            string excepted = "HAPPY";
            string message = "I am in Any Mood";
            MoodAnalyserClass moodAnalyser = new MoodAnalyserClass(message);

            string mood = moodAnalyser.AnalyseMood();

            Assert.AreEqual(excepted, mood);

        }
    }
}