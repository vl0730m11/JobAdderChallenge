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
        //private readonly IRecruitmentService _recruitmentService;
        public RecruitmentController()
        {
            //_recruitmentService = recruitmentService;
        }

        [Route("getJobList")]
        [HttpGet]
        public async Task<IHttpActionResult> getJobList()
        {
            return Ok(new
            {
                data = "Testing"
            });
        }

        [Route("getCandidateList")]
        [HttpGet]
        public async Task<IHttpActionResult> getCandidateList()
        {
            return Ok(new
            {
                data = "Testing"
            });
        }
    }
}
