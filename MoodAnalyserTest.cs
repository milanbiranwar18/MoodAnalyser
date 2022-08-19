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

        [TestMethod]
        public void GivenHappyMoodShouldReturnHappy()
        {
            string excepted = "HAPPY";
            string message = "I am in HAPPY Mood";
            MoodAnalyserClass moodAnalyser = new MoodAnalyserClass(message);

            string mood = moodAnalyser.AnalyseMood();

            Assert.AreEqual(excepted, mood);

        }


            [TestMethod]
            [DataRow(null)]
            public void GivenHappyMood_ShouldReturnHappy(string message)
            {
                string excepted = "HAPPY";
               
                MoodAnalyserClass moodAnalyser = new MoodAnalyserClass(message);

                string mood = moodAnalyser.AnalyseMood();

                Assert.AreEqual(excepted, mood);

            }


        [TestMethod]
        public void Given_Null_Mood_Should_Throw_MoodAnalysisException()
        {
            try
            {
                string message = null;
                MoodAnalyser1 moodAnalyser = new MoodAnalyser1(message);
                string mood = moodAnalyser.analyseMood();

            }

            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be empty", e.Message);
            }
        }



        [TestMethod]
        public void Given_Empty_Mood_Throw_MoodAnalysisException_Indicating_EmptyMood()
        {
            try
            {
                string message = "";
                MoodAnalyser1 moodAnalyser = new MoodAnalyser1(message);
                string mood = moodAnalyser.analyseMood();

            }

            catch(MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be empty", e.Message);
            }
        }


       


    }
}