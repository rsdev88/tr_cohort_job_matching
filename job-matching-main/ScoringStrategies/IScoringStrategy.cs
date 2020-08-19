using System.Collections.Generic;

namespace job_matching_main.ScoringStrategies
{
    public interface IScoringStrategy
    {
        int GenerateScore(List<string> jobCharacteristics, List<string> candidateCharacteristics);
    }
}
