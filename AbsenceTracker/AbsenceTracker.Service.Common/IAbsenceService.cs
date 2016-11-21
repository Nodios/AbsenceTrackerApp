using AbsenceTracker.Model.Common.IDomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Service.Common
{
    public interface IAbsenceService
    {
        Task<int> Add(IAbsenceDomain entry);
        Task<int> Delete(string id);
        Task<int> Delete(IAbsenceDomain entry);
        Task<IAbsenceDomain> Read(string id);
        Task<IEnumerable<IAbsenceDomain>> ReadAll();
        Task<int> Update(IAbsenceDomain entry);
    }
}
