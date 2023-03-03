
using MoodAnalyzer;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {

        //-------------Test Case 1.1---------------//
        [TestMethod]
        public void GivenSadMoodShouldReturnSAD()
        {
            //Arrange
            string message = "Sad";
            string expected = "SAD";
            MoodAnalyser moodAnalyzer = new MoodAnalyser(message);

            //Act
            string actual = moodAnalyzer.AnalyzeMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //-------------Test Case 1.2---------------//

        [TestMethod]
        public void GivenAnyMoodHAPPY()
        {
            //Arrange
            string expected = "HAPPY";
            MoodAnalyser moodAnalyzer = new MoodAnalyser(expected);

            //Act
            string actual = moodAnalyzer.AnalyzeMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }


        //-------------Test Case 2.1---------------//
        [TestMethod]
        public void TestAnalyseMood_ShouldReturnHAPPY1()
        {
            //Arrange
            string message = null;
            string expected = "HAPPY";
            MoodAnalyser mood = new MoodAnalyser(message);

            //Act
            string actual = mood.AnalyzeMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }


        //--------------Test Case 3.1-----------------//
        [TestMethod]
        public void GivenNullMoodShouldThrowMoodAnalysisException()
        {
            try
            {
                string message = null;
                MoodAnalyser moodAnalyzer = new MoodAnalyser(message);
                string actual = moodAnalyzer.AnalyzeMood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Mood should not be null", ex.Message);
            }
        }
        //---------Test Case 3.2---------------//
        [TestMethod]
        public void GivenEmptyMoodShouldThrowMoodAnalysisException()
        {
            try
            {
                string message = "";
                MoodAnalyser moodAnalyzer = new MoodAnalyser(message);
                string actual = moodAnalyzer.AnalyzeMood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Mood should not be empty", ex.Message);
            }


        }
        }
    }

