using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoodAnalyserMSTest
{
    [TestClass]
    public class MoodAnalyserTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            public void GivenSadMoodShouldReturnSad()
            {
                string excepted = "SAD";
                string message = "I am in SAD Mood";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);

                string mood = moodAnalyser.AnalyseMood();

                Assert.AreEqual(excepted, mood);


            }
        }
    }
}