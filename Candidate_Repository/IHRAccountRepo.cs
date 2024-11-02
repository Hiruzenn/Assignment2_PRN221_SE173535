using Candidate_BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
    public interface IHRAccountRepo
    {

        Hraccount GetHraccountByEmail(string email);
        public IEnumerable<Hraccount> GetHraccounts();
    }
}
