using JobAdderChallenge.Data.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace JobAdderChallenge.Services.JobAdderService
{
    public interface IJobAdderService
    {
        Task<List<JobModel>> getJobList();
        Task<List<CandidateModel>> getCandidateList();
    }
    public class JobAdderService : IJobAdderService
    {
        private string JobAdderUrl = "http://private-76432-jobadder1.apiary-mock.com/";
        public JobAdderService()
        {
            
        }

        public async Task<List<JobModel>> getJobList()
        {
            var result = new List<JobModel>();
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(JobAdderUrl + "jobs");
            if (response.IsSuccessStatusCode)
            {
                var res = await response.Content.ReadAsStreamAsync();
                StreamReader reader = new StreamReader(res);
                result = JsonConvert.DeserializeObject<List<JobModel>>(reader.ReadToEnd().Trim());
            }
            return result;
        }

        public async Task<List<CandidateModel>> getCandidateList()
        {
            var result = new List<CandidateModel>();
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(JobAdderUrl + "candidates");
            if (response.IsSuccessStatusCode)
            {
                var res = await response.Content.ReadAsStreamAsync();
                StreamReader reader = new StreamReader(res);
                result = JsonConvert.DeserializeObject<List<CandidateModel>>(reader.ReadToEnd().Trim());
            }
            return result;
        }
    }
}
