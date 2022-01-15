using JobAdderChallenge.Services.RecruitmentService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace JobAdderChallenge.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("api/Recruitment")]
    public class RecruitmentController : ApiController
    {
        private readonly IRecruitmentService _recruitmentService;
        public RecruitmentController(IRecruitmentService recruitmentService)
        {
            _recruitmentService = recruitmentService;
        }

        [Route("getJobList")]
        [HttpGet]
        public async Task<IHttpActionResult> getJobList()
        {
            return Ok(new
            {
                data = await _recruitmentService.getJobList()
            });
        }

        [Route("getCandidateList")]
        [HttpGet]
        public async Task<IHttpActionResult> getCandidateList()
        {
            return Ok(new
            {
                data = await _recruitmentService.getCandidateList()
            });
        }

        [Route("getBestCandidate")]
        [HttpGet]
        public async Task<IHttpActionResult> getBestCandidate([FromUri] int jobId)
        {
            return Ok(new
            {
                data = await _recruitmentService.getBestCandidate(jobId)
            });
        }
    }
}
