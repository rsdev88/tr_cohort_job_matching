using System;
using System.Collections.Generic;

namespace job_matching_main.ScoringStrategies
{
    //Loop through each of the job characteristics and for each one, look to see if there are any candidate characteristics which are a perfect match.
    //Pros - simple and straightforward
    //Cons - inefficient (O(n^2) time complexity so very slow for large inputs, and requires a perfect match
    public class BruteForceApproach : IScoringStrategy
    {
        public int GenerateScore(List<string> jobCharacteristics, List<string> candidateCharacteristics)
        {
            var totalCharacteristics = jobCharacteristics.Count + candidateCharacteristics.Count;
            int matchingCharacteristics = 0;

            foreach (string jobCharacteristic in jobCharacteristics)
            {
                foreach (string candidateCharacteristic in candidateCharacteristics)
                {
                    //Compare ignoring letter case
                    if (jobCharacteristic.ToLower() == candidateCharacteristic.ToLower())
                    {
                        matchingCharacteristics += 2; //Increment the number of matching characteristics by 2 as the the matches will be present in both lists
                    }
                }
            }

            //Return the score as a percent of matches per total number of letters, rounded to the nearest integer
            var score = (double)matchingCharacteristics / (double)totalCharacteristics;
            return (int)(score * 100);
        }
    }
}
