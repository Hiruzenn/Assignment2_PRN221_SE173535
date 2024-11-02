using Candidate_BusinessObjects.Models;
using Candidate_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
    public class JobPostRepo : IJobPostRepo
    {
        public bool AddJobPosting(JobPosting jobPosting) => JobPostDAO.Instance.AddJobPosting(jobPosting);

        public bool DeleteJobPosting(JobPosting jobPosting) => JobPostDAO.Instance.DeleteJobPosting(jobPosting);

        public JobPosting GetJobPostingById(string jobId) => JobPostDAO.Instance.GetJobPostingById(jobId);
        public List<JobPosting> GetJobPostings() => JobPostDAO.Instance.GetJobPostings();

        public bool UpdateJobPosting(JobPosting jobPosting) => JobPostDAO.Instance.UpdateJobPosting(jobPosting);
    }
}
