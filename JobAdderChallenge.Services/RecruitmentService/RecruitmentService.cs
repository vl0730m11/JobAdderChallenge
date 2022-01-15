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
    }
}
