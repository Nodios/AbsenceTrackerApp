using AbsenceTracker.Model.Common.IDomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Repository.Common.IRepository
{
    public interface IAspNetUserRoleRepository
    {
        Task<int> Add(IAspNetUserRoleDomain entity);
        Task<int> Delete(string id);
        Task<int> Delete(IAspNetUserRoleDomain entity);
        Task<IAspNetUserRoleDomain> Get(string id);
        Task<IEnumerable<IAspNetUserRoleDomain>> GetAll();
        Task<int> Update(IAspNetUserRoleDomain entity);
    }
}
