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

        [TestMethod]

        public void givenMessage_WhenNull_ShouldRetrun_Happy()
        {
            try
            {
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer("");
                String mood = moodAnalyzer.analyseMood();
                Assert.AreEqual("", mood);
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual(e.Message, "User of Empty mood");
            }
        }

        [TestMethod]
        public void GivenMoodAnalyserClassName_ShouldReturnMoodAnalyserObject()
        {
            // Arrange
            MoodAnalyzer expectedMoodAnalyser = new MoodAnalyzer();

            // Act
            MoodAnalyzer actualMoodAnalyser = MoodAnalyserFactory.createMoodAnalyser();

            // Assert
            Assert.IsTrue(expectedMoodAnalyser.Equals(actualMoodAnalyser));
        }

        [TestMethod]
        [ExpectedException(typeof(MoodAnalysisException), "No Such Class Error")]
        public void GivenWrongClassName_ShouldThrowMoodAnalysisException()
        {
            // Arrange
            string wrongClassName = "WrongClassName";

            // Act
            MoodAnalyzer actualMoodAnalyser = MoodAnalyserFactory.createMoodAnalyser(wrongClassName);
        }

        [TestMethod]
        [ExpectedException(typeof(MoodAnalysisException), "User of Empty mood")]
        public void GivenWrongConstructor_ShouldThrowMoodAnalysisException()
        {
            // Act
            MoodAnalyzer actualMoodAnalyser = new MoodAnalyzer(null);
        }

        [TestMethod]
        public void GivenMessage_WhenProper_ShouldReturnObject()
        {
            // Arrange
            string message = "I am in a happy mood";
            string className = "MoodAnalyser.MoodAnalyzer";

            // Act
            MoodAnalyzer actualMoodAnalyser = MoodAnalyserFactory.createMoodAnalyser(className, message);
            MoodAnalyzer expectedMoodAnalyser = new MoodAnalyzer(message);

            // Assert
            Assert.AreEqual(actualMoodAnalyser, expectedMoodAnalyser);

        }

        [TestMethod]
        [ExpectedException(typeof(MoodAnalysisException), "No Such Class Error")]
        public void GivenWrongClassName_ShouldThrowMoodAnalysisException2()
        {
            // Arrange
            string message = "I am in a happy mood";
            string className = "MoodAnalyser.WrongClassName";

            // Act
            try
            {
                MoodAnalyzer actualMoodAnalyser = MoodAnalyserFactory.createMoodAnalyser(className, message);
            }
            catch (TypeLoadException e)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExpType.NO_SUCH_CLASS, "No Such Class Error", e);
            }
        }

        [TestMethod]
        public void GivenMessage_WhenProper_ShouldReturnAnalyseMood()
        {
            // Arrange
            string message = "I am in a happy mood";
            string className = "MoodAnalyser.MoodAnalyzer";
            // Act
            string actualMood = MoodAnalyserFactory.invokeAnalyseMood(className, message);
            // Assert
            Assert.AreEqual("HAPPY", actualMood);
        }

        [TestMethod]
        [ExpectedException(typeof(MoodAnalysisException), "No Such Method Error")]
        public void GivenWrongMethodName_ShouldThrowMoodAnalysisException()
        {
            // Arrange
            string message = "I am in a happy mood";
            string className = "MoodAnalyser.MoodAnalyzer";
            string wrongMethodName = "WrongMethodName";
            // Act
            try
            {
                string actualMood = MoodAnalyserFactory.invokeAnalyseMood(className, message, wrongMethodName);
            }
            catch (MissingMethodException e)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExpType.NO_SUCH_METHOD, "No Such Method Error", e);
            }
        }



    }

}