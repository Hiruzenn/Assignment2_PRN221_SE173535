
using Candidate_BusinessObjects.Models;
using Candidate_Service;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CandidateManagement_GUI.Pages.JobPostingPages
{
    public class IndexModel : PageModel
    {
        private readonly IJobPostService _jobPostingService;

        public IndexModel(IJobPostService jobPostingService)
        {
            _jobPostingService = jobPostingService;
        }

        public IList<JobPosting> JobPosting { get; set; } = default!;

        public void OnGet()
        {
            JobPosting = _jobPostingService.GetJobPostings();
        }
    }
}
