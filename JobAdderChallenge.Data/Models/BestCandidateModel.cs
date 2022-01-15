using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobAdderChallenge.Data.Models
{
    public class BestCandidateModel : CandidateModel 
    {
        public int score { get; set; }
        public int maxScore { get; set; }
    }
}