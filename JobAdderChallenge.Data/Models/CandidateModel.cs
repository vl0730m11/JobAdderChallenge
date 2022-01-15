using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobAdderChallenge.Data.Models
{
    public class CandidateModel
    {
        public int candidateId { get; set; }
        public string name { get; set; }
        public string skillTags { get; set; }
    }
}