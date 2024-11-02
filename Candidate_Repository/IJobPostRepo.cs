using Candidate_BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
    public interface IJobPostRepo
    {
        List<JobPosting> GetJobPostings();
        JobPosting GetJobPostingById(string jobId);
        bool AddJobPosting(JobPosting jobPosting);
        bool DeleteJobPosting(JobPosting jobPosting);
        bool UpdateJobPosting(JobPosting jobPosting);
    }
}
