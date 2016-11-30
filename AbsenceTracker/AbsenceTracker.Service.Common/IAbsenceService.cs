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
        Task<int> Delete(Guid id);
        Task<int> Delete(IAbsenceDomain entry);
        Task<IAbsenceDomain> Read(Guid id);
        Task<IEnumerable<IAbsenceDomain>> ReadAll();
        Task<int> Update(IAbsenceDomain entry);
        Task<IEnumerable<IAbsenceDomain>> ReadAllSickness();
        Task<IEnumerable<IAbsenceDomain>> ReadAllVacation();
        Task<IEnumerable<IAbsenceDomain>> ReadAllCompensation();
    }
}
