## Develop server
Run .sln file at JobAdderChallenge/JobAdderChallenge.sln, add JobAdderChallenge to IIS Manager API. Navigate to `http://localhost:29003`

## Develop AngularWeb
open JobAdderChallenge.Web/JobAdderChallengeAngular
Run `npm install` for installing packages
Run `ng build`
Run `ng serve`

## About JobAdderChallenge
Propose a solution for JobAdder Challenge
- Create a web application that will help a recruiter automatically match candidates to open jobs
- For each job, display a candidate that is the most-qualified to fill that job.
- Candidate skill Tags are listed in order from strongest to weakest.
- Job skills are listed in order from most-relevant to least-relevant.

# Scoring Mechanism
Score will be calculated according to skills required for the job, from most-relevant to least-relevant
- Ex: Job name: Office Coordinator 
- "skills": "recruiting, negotiation, placements, hr, admin" -> 5 skills listed
- recruiting = 5pts, negotiation = 4pts, etc.
- maxScore = 5 + 4 + 3 + 2 + 1 = 15

# Exceptions
- In case of 2 or more candidates share the same score, system will emit candidate who applied first