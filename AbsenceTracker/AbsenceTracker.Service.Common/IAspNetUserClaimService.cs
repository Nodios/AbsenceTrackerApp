using AbsenceTracker.Model.Common.IDomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Service.Common
{
    public interface IAspNetUserClaimService
    {
        Task<int> Add(IAspNetUserClaimDomain entry);
        Task<int> Delete(string id);
        Task<int> Delete(IAspNetUserClaimDomain entry);
        Task<IAspNetUserClaimDomain> Read(string id);
        Task<IEnumerable<IAspNetUserClaimDomain>> ReadAll();
        Task<int> Update(IAspNetUserClaimDomain entry);
    }
}
