using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using job_matching_main;

namespace job_matching_tests
{
    [TestClass]
    public class JobMatchingTests
    {
        [TestMethod]
        public void NullJobCharacteristicsShouldReturnZero()
        {
            //Arrange
            var jobMatching = new JobMatching();
            List<string> jobCharacteristics = null;
            var candidateCharacteristics = new List<string>() { "React", ".NET" };

            var expectedResult = 0;

            //Act
            var result = jobMatching.MatchJob(jobCharacteristics, candidateCharacteristics);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void NullCandidateCharacteristicsShouldReturnZero()
        {
            //Arrange
            var jobMatching = new JobMatching();
            var jobCharacteristics = new List<string>() { "Remote", "Flexible hours" };
            List<string> candidateCharacteristics = null;

            var expectedResult = 0;

            //Act
            var result = jobMatching.MatchJob(jobCharacteristics, candidateCharacteristics);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void EmptyJobCharacteristicsShouldReturnZero()
        {
            //Arrange
            var jobMatching = new JobMatching();
            var jobCharacteristics = new List<string>();
            var candidateCharacteristics = new List<string>() { "React", ".NET" };

            var expectedResult = 0;

            //Act
            var result = jobMatching.MatchJob(jobCharacteristics, candidateCharacteristics);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void EmptyCandidateCharacteristicsShouldReturnZero()
        {
            //Arrange
            var jobMatching = new JobMatching();
            var jobCharacteristics = new List<string>() { "Remote", "Flexible hours" };
            var candidateCharacteristics = new List<string>();

            var expectedResult = 0;

            //Act
            var result = jobMatching.MatchJob(jobCharacteristics, candidateCharacteristics);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
