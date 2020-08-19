using System.Collections.Generic;

namespace job_matching_main
{
    public class JobMatching
    {
        public int MatchJob(List<string> jobCharacteristics, List<string> candidateCharacteristics)
        {
            //Input validation - if the job or candidate has no characteristics, assume they do not match and return a score of 0
            if ((jobCharacteristics == null || jobCharacteristics.Count < 1) || (candidateCharacteristics == null || candidateCharacteristics.Count < 1))
            {
                return 0;
            }

            return 100;
        }
    }
}
