using System.Collections.Generic;

namespace job_matching_main.ScoringStrategies
{

    //*************************
    // I ran out of time but would would aim to compare against a white list of accepted terms for non-peferct matching.
    //***********************

    //Uses a similar strategy to the DictionaryPerfectMatch approach but does not require perfect matches between the characteristics
    //Pros - more time efficient than the brute force approach - O(n) time complexity, does not require perfect matches (which are unlikely in production if input strings are free text)
    //Cons - uses more memory than the brute force approach.
    public class DictionaryImperfectMatches
    {
        public int GenerateScore(List<string> jobCharacteristics, List<string> candidateCharacteristics)
        {
            return 100;
        }
    }
}
