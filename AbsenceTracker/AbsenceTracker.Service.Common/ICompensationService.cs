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
        Task<int> Delete(string id);
        Task<int> Delete(ICompensationDomain entry);
        Task<ICompensationDomain> Read(string id);
        Task<IEnumerable<ICompensationDomain>> ReadAll();
        Task<int> Update(ICompensationDomain entry);
    }
}
