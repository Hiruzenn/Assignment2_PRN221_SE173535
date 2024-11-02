using Candidate_BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Service
{
    public interface ICandidateProfileService
    {
        (List<CandidateProfile> Items, int TotalItems, int TotalPages) GetCandidateProfiles(int pageNumber, int pageSize);
        CandidateProfile? GetCandidateProfileById(string id);
        List<CandidateProfile> GetCandidateProfiles();
        bool AddCandidateProfile(CandidateProfile candidateProfile);
        bool DeleteCandidateProfile(CandidateProfile candidateProfile);
        bool UpdateCandidateProfile(CandidateProfile candidateProfile);
    }
}
