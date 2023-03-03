
using MoodAnalyzer;
namespace MoodAnalyzerTest
{
            [TestClass]
            public class UnitTest1
            {
           AnalyseAndRespond mood = new AnalyseAndRespond();

            //-------------Test Case 1.1---------------//
            [TestMethod]
            public void GivenSadMoodShouldReturnSAD()
            {
                //Arrange
                string expected = "SAD";

                //Act
                string actual = mood.AnalyzeMood("I am in Sad Mood");

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
                string actual = mood.AnalyzeMood("I am in Any Mood");

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }

