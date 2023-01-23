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
            String mood = moodAnalyzer.AnalyseMood();
            Assert.AreEqual("SAD", mood);

        }

        [TestMethod]
        public void givenMessage_WhenNotSad_ShouldReturn_Happy()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("This is Happy Messgae");
            String mood = moodAnalyzer.AnalyseMood();
            Assert.AreEqual("HAPPY", mood);
        }

        [TestMethod]

        public void givenMessage_WhenNull_ShouldRetrun_Happy()
        {
            try
            {
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer("");
                String mood = moodAnalyzer.AnalyseMood();
                Assert.AreEqual("", mood);
            }
            catch(MoodAnalysisException e)
            {
                Assert.AreEqual(e.Message, "User of Empty mood");
            }
        }

    }
}