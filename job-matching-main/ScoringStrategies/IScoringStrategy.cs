using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace job_matching_main.ScoringStrategies
{
    public interface IScoringStrategy
    {
        int GenerateScore(List<string> jobCharacteristics, List<string> candidateCharacteristics);
    }
}
