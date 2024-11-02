using Candidate_BusinessObjects.Models;
using Candidate_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Service
{
    public class HRAccountService : IHRAccountService
    {
        private IHRAccountRepo _repo;

        public HRAccountService()
        {
            _repo = new HRAccountRepo();
        }

        public Hraccount GetHraccountByEmail(string email) => _repo.GetHraccountByEmail(email);
        public IEnumerable<Hraccount> GetHraccounts() => _repo.GetHraccounts();
    }
}
