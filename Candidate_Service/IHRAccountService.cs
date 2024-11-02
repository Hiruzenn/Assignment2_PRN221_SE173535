using Candidate_BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Service
{
    public interface IHRAccountService
    {
        Hraccount GetHraccountByEmail(string email);
        IEnumerable<Hraccount> GetHraccounts();
    }
}
