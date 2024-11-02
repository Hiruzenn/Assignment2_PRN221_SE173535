
using Candidate_BusinessObjects.Models;
using Candidate_Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CandidateManagement_GUI.Pages.JobPostingPages
{
    public class CreateModel : PageModel
    {
        private readonly IJobPostService _jobPostingService;
        public CreateModel(IJobPostService jobPostingService)
        {
            _jobPostingService = jobPostingService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public JobPosting JobPosting { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid || _jobPostingService.GetJobPostings() == null || JobPosting == null)
            {
                return Page();
            }

            _jobPostingService.AddJobPosting(JobPosting);
            return RedirectToPage("./Index");
        }
    }
}
