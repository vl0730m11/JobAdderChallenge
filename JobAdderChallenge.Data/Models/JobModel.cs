using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobAdderChallenge.Data.Models
{
    public class JobModel
    {
        public int jobId { get; set; }
        public string name { get; set; }
        public string company { get; set; }
        public string skills { get; set; }
    }
}