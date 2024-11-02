﻿
using Candidate_BusinessObjects.Models;
using Candidate_Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CandidateManagement_GUI.Pages.JobPostingPages
{
    public class DeleteModel : PageModel
    {
        private readonly IJobPostService _jobPostingService;

        public DeleteModel(IJobPostService jobPostingService)
        {
            _jobPostingService = jobPostingService;
        }

        [BindProperty]
        public JobPosting JobPosting { get; set; } = default!;

        public IActionResult OnGet(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobposting = _jobPostingService.GetJobPostingById(id);

            if (jobposting == null)
            {
                return NotFound();
            }
            else
            {
                JobPosting = jobposting;
            }
            return Page();
        }

        public IActionResult OnPost(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobposting = _jobPostingService.GetJobPostingById(id);
            if (jobposting != null)
            {
                JobPosting = jobposting;
                _jobPostingService.DeleteJobPosting(jobposting);
            }

            return RedirectToPage("./Index");
        }
    }
}
