using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace job_matching_main.ScoringStrategies
{
    //Combine the two lists and into one and then loop through the resulting list, keeping track of if you've seen a particular item before.
    //Pros - more time efficient than the brute force approach - O(n) time complexity
    //Cons - uses more memory than the brute force approach. Still requires an exact match between items.
    public class DictionaryExactMatchApproach
    {
        public int GenerateScore(List<string> jobCharacteristics, List<string> candidateCharacteristics)
        {
            //Combine the lists
            var fullList = jobCharacteristics;
            foreach (string candidateCharacteristic in candidateCharacteristics)
            {
                fullList.Add(candidateCharacteristic);
            }

            var totalCharacteristics = fullList.Count;
            int matchingCharacteristics = 0;
            HashSet<string> characteristicsSeenSoFar = new HashSet<string>();

            //Go through the full list and keep track of matches
            foreach (string characteristic in fullList)
            {
                if (characteristicsSeenSoFar.Contains(characteristic.ToLower()))
                {
                    matchingCharacteristics += 2; //Increment the number of matching characteristics by 2 like before as the the matches will be present in both lists
                }
                else
                {
                    characteristicsSeenSoFar.Add(characteristic.ToLower());
                }
            }

            //Return the score as a percent of matches per total number of letters, rounded to the nearest integer
            //(Given time I'd refactor this into its own method as it's repeated across strategies)
            var score = (double)matchingCharacteristics / (double)totalCharacteristics;
            return (int)(score * 100);
        }
    }
}
