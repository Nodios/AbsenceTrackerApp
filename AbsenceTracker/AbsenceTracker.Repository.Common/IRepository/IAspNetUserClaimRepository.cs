using AbsenceTracker.Model.Common.IDomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Repository.Common.IRepository
{
    public interface IAspNetUserClaimRepository
    {
        Task<int> Add(IAspNetUserClaimDomain entity);
        Task<int> Delete(string id);
        Task<int> Delete(IAspNetUserClaimDomain entity);
        Task<IAspNetUserClaimDomain> Get(string id);
        Task<IEnumerable<IAspNetUserClaimDomain>> GetAll();
        Task<int> Update(IAspNetUserClaimDomain entity);
    }
}
