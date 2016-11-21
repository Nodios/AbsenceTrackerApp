using AbsenceTracker.Model.Common.IDomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Service.Common
{
    public interface IAspNetUserRoleService
    {
        Task<int> Add(IAspNetUserRoleDomain entry);
        Task<int> Delete(string id);
        Task<int> Delete(IAspNetUserRoleDomain entry);
        Task<IAspNetUserRoleDomain> Read(string id);
        Task<IEnumerable<IAspNetUserRoleDomain>> ReadAll();
        Task<int> Update(IAspNetUserRoleDomain entry);
    }
}
