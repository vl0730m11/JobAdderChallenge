using JobAdderChallenge.Data.Models;
using JobAdderChallenge.Services.RecruitmentService;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobAdderChallenge.UnitTests
{
    [TestFixture]
    public class RecruitmentTests
    {
        private readonly IRecruitmentService _recruitmentService;

        public RecruitmentTests(IRecruitmentService recruitmentService)
        {
            _recruitmentService = recruitmentService;
        }

        [Test]
        public void getMaxScore_ReturnMaxScore()
        {
            //Arrange

            //Act
            var job = new JobModel
            {
                jobId = 13,
                name = "Office Coordinator",
                company = "Sucosis",
                skills = "reception, data-entry, ordering, detail"
            };
                
            var result = _recruitmentService.getMaxScore(job);

            //Assert
            Assert.That(result == 10);
        }
    }
}
