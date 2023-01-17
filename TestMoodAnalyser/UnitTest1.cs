using MoodAnalyser;

namespace TestMoodAnalyser
{
    [TestClass]
    public class TestMoodAnalyser
    {
        [TestMethod]
        public void givenMessgae_WhenSad_ShouldReturn_Sad()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("This is a Sad Message");
            String mood = moodAnalyzer.analyseMood();
            Assert.AreEqual("SAD", mood);

        }

        [TestMethod]
        public void givenMessage_WhenNotSad_ShouldReturn_Happy()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("This is Happy Messgae");
            String mood = moodAnalyzer.analyseMood();
            Assert.AreEqual("HAPPY", mood);
        }

    }
}