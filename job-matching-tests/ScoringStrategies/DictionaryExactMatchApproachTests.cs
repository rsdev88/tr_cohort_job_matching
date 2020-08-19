using job_matching_main.ScoringStrategies;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace job_matching_tests.ScoringStrategies
{
    [TestClass]
    public class DictionaryExactMatchApproachTests
    {
        [TestMethod]
        public void NoPerfectMatchesShouldReturnZero()
        {
            //Arrange
            var bruteForceApproach = new DictionaryExactMatchApproach();
            List<string> jobCharacteristics = new List<string>() { "Angular", "Java" };
            var candidateCharacteristics = new List<string>() { "React", ".NET" };

            var expectedResult = 0;

            //Act
            var result = bruteForceApproach.GenerateScore(jobCharacteristics, candidateCharacteristics);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void AllPerfectMatchesShouldReturnOneHundred()
        {
            //Arrange
            var bruteForceApproach = new DictionaryExactMatchApproach();
            List<string> jobCharacteristics = new List<string>() { "react", ".net" }; //Test case sensitivity too
            var candidateCharacteristics = new List<string>() { "React", ".NET" };

            var expectedResult = 100;

            //Act
            var result = bruteForceApproach.GenerateScore(jobCharacteristics, candidateCharacteristics);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void HalfPerfectMatchesShouldReturnFifty()
        {
            //Arrange
            var bruteForceApproach = new DictionaryExactMatchApproach();
            List<string> jobCharacteristics = new List<string>() { "Angular", ".net" };
            var candidateCharacteristics = new List<string>() { "React", ".NET" };

            var expectedResult = 50;

            //Act
            var result = bruteForceApproach.GenerateScore(jobCharacteristics, candidateCharacteristics);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TwoThirdsPerfectMatchesShouldReturnSixtySix()
        {
            //Arrange
            var bruteForceApproach = new DictionaryExactMatchApproach();
            List<string> jobCharacteristics = new List<string>() { "Angular", ".net", "flexible" };
            var candidateCharacteristics = new List<string>() { "React", ".NET", "Flexible" };

            var expectedResult = 66;

            //Act
            var result = bruteForceApproach.GenerateScore(jobCharacteristics, candidateCharacteristics);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
