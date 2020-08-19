using job_matching_main.ScoringStrategies;
using System.Collections.Generic;

namespace job_matching_main
{
    public class JobMatching
    {
        private readonly IScoringStrategy strategy;

        public JobMatching(IScoringStrategy strategy) //Use dependency injection to pass in the scoring strategy, to easily swap out different approaches.
        {
            this.strategy = strategy;
        }

        public int MatchJob(List<string> jobCharacteristics, List<string> candidateCharacteristics)
        {
            //Input validation - if the job or candidate has no characteristics, assume they do not match and return a score of 0
            if ((jobCharacteristics == null || jobCharacteristics.Count < 1) || (candidateCharacteristics == null || candidateCharacteristics.Count < 1))
            {
                return 0;
            }
            
            var score = this.strategy.GenerateScore(jobCharacteristics, candidateCharacteristics);
            return score;
        }
    }
}
