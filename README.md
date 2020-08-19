# tr_cohort_job_matching
Repo for the TR assessment day


During this exercise I decided to take an incremental approach to solving the problem, starting with some input validation for edge cases and implementing a brute force approach which gets the job done but is inefficient. I then aimed to incrementally improve my solution by adding new strategies which are e.g. more time efficient or e.g. use smarter matching than basic string comparisons (I unfortunately ran out of time on the latter). I used dependency injection on the main function to allow for the strategies to be easily swapped out.
