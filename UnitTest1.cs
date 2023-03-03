
using MoodAnalyzer;

namespace MoodAnalyzerTest
{

    [TestClass]
    public class UnitTest1
    {
        MoodAnalyser moodAnalyzer = new MoodAnalyser("Sad");

        //-------------Test Case 1.1---------------//
        [TestMethod]
        public void GivenSadMoodShouldReturnSAD()
        {
            //Arrange
            string expected = "SAD";

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
        }
    }

