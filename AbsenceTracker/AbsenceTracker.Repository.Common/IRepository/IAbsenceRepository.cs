using AbsenceTracker.Model.Common.IDomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Repository.Common.IRepository
{
    public interface IAbsenceRepository
    {
        Task<int> Add(IAbsenceDomain entity);
        Task<int> Delete(string id);
        Task<int> Delete(IAbsenceDomain entity);
        Task<IAbsenceDomain> Get(string id);
        Task<IEnumerable<IAbsenceDomain>> GetAll();
        Task<int> Update(IAbsenceDomain entity);
    }
}
