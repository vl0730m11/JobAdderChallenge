using JobAdderChallenge.Data.Models;
using JobAdderChallenge.Services.JobAdderService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobAdderChallenge.Services.RecruitmentService
{
    public interface IRecruitmentService
    {
        Task<List<JobModel>> getJobList();
        Task<List<CandidateModel>> getCandidateList();
        Task<BestCandidateModel> getBestCandidate(int jobId);
    }
    public class RecruitmentService : IRecruitmentService
    {
        private readonly IJobAdderService _jobAdderService;
        public RecruitmentService(IJobAdderService jobAdderService)
        {
            _jobAdderService = jobAdderService;
        }

        public async Task<List<JobModel>> getJobList()
        {
            var result = new List<JobModel>();

            result = await _jobAdderService.getJobList();

            return result;
        }

        public async Task<List<CandidateModel>> getCandidateList()
        {
            var result = new List<CandidateModel>();

            result = await _jobAdderService.getCandidateList();

            return result;
        }

        public async Task<BestCandidateModel> getBestCandidate(int jobId)
        {
            var result = new BestCandidateModel();
            var jobList = await getJobList();
            var candidateList = await getCandidateList();

            var job = jobList.FirstOrDefault(item => item.jobId == jobId);
            var bestScore = 0;
            var maxScore = 0;

            if (job == null)
            {
                return result;
            }

            maxScore = getMaxScore(job);

            candidateList.ForEach(candidate =>
            {
                var res = scoreingCandidate(candidate, job);
                if (bestScore < res)
                {
                    bestScore = res;
                    result = new BestCandidateModel
                    {
                        candidateId = candidate.candidateId,
                        name = candidate.name,
                        skillTags = candidate.skillTags,
                        score = bestScore,
                        maxScore = maxScore,
                    };
                }
            });

            return result;
        }

        private int scoreingCandidate(CandidateModel candidate, JobModel job)
        {
            //Score will be calculated according to skills required for the job
            //Ex: Job name: Office Coordinator - "skills": "recruiting, negotiation, placements, hr, admin"
            //recruiting = 5pts, negotiation = 4pts, etc.

            var result = 0;
            var candidateSkills = candidate.skillTags.Split(',');
            var jobSkills = job.skills.Split(',').Reverse().ToArray();

            foreach (string skill in jobSkills)
            {
                if (candidateSkills.Contains(skill))
                {
                    var index = Array.FindIndex(jobSkills, row => row.Contains(skill));
                    result += index + 1;
                }
            }

            return result;
        }

        private int getMaxScore(JobModel job) {
            var result = 0;
            var jobSkills = job.skills.Split(',');
            for (int i = 1; i <= jobSkills.Length; i++)
            {
                result += i;
            }

            return result;
        }

    }
}
