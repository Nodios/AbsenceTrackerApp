using AbsenceTracker.Model.Common.IDomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Service.Common
{
    public interface ICompensationService
    {
        Task<int> Add(ICompensationDomain entry);
        Task<int> Delete(Guid id);
        Task<int> Delete(ICompensationDomain entry);
        Task<ICompensationDomain> Read(Guid id);
        Task<IEnumerable<ICompensationDomain>> ReadAll();
        Task<int> Update(ICompensationDomain entry);
    }
}
