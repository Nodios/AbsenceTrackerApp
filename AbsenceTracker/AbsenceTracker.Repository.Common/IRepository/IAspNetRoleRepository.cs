using AbsenceTracker.Model.Common.IDomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Repository.Common.IRepository
{
    public interface IAspNetRoleRepository
    {
        Task<int> Add(IAspNetRoleDomain entity);
        Task<int> Delete(string id);
        Task<int> Delete(IAspNetRoleDomain entity);
        Task<IAspNetRoleDomain> Get(string id);
        Task<IEnumerable<IAspNetRoleDomain>> GetAll();
        Task<int> Update(IAspNetRoleDomain entity);
    }
}
