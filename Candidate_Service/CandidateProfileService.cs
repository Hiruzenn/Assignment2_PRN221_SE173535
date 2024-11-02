using Candidate_BusinessObjects.Models;
using Candidate_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Service
{
    public class CandidateProfileService : ICandidateProfileService
    {
        private readonly ICandidateProfileRepo candidateProfileRepo;
        public CandidateProfileService()
        {
            candidateProfileRepo = new CandidateProfileRepo();
        }
        public bool AddCandidateProfile(CandidateProfile candidateProfile) => candidateProfileRepo.AddCandidateProfile(candidateProfile);
        public bool DeleteCandidateProfile(CandidateProfile candidateProfile) => candidateProfileRepo.DeleteCandidateProfile(candidateProfile);
        public CandidateProfile? GetCandidateProfileById(string id) => candidateProfileRepo.GetCandidateProfileById(id);
        public List<CandidateProfile> GetCandidateProfiles() => candidateProfileRepo.GetCandidateProfiles();
        public bool UpdateCandidateProfile(CandidateProfile candidateProfile) => candidateProfileRepo.UpdateCandidateProfile(candidateProfile);
        public (List<CandidateProfile> Items, int TotalItems, int TotalPages) GetCandidateProfiles(int pageNumber, int pageSize)
        {
            var allProfiles = candidateProfileRepo.GetCandidateProfiles();
            var totalItems = allProfiles.Count();

            var pagedProfiles = allProfiles
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            var totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

            return (pagedProfiles, totalItems, totalPages);
        }
    }
}
