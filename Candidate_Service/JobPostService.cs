using Candidate_BusinessObjects.Models;
using Candidate_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Service
{
    public class JobPostService : IJobPostService
    {
        private readonly IJobPostRepo _jobPostingRepo;
        public JobPostService()
        {
            _jobPostingRepo = new JobPostRepo();
        }

        public bool AddJobPosting(JobPosting jobPosting) => _jobPostingRepo.AddJobPosting(jobPosting);

        public bool DeleteJobPosting(JobPosting jobPosting) => _jobPostingRepo.DeleteJobPosting(jobPosting);

        public JobPosting GetJobPostingById(string jobId) => _jobPostingRepo.GetJobPostingById(jobId);

        public List<JobPosting> GetJobPostings() => _jobPostingRepo.GetJobPostings();

        public bool UpdateJobPosting(JobPosting jobPosting) => _jobPostingRepo.UpdateJobPosting(jobPosting);
    }
}
