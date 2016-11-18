using AbsenceTracker.Model.Common.IDomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Repository.Common.IRepository
{
    public interface ICompensationEntryRepository
    {
        Task<int> Add(ICompensationEntryDomain entity);
        Task<int> Delete(string id);
        Task<int> Delete(ICompensationEntryDomain entity);
        Task<ICompensationEntryDomain> Get(string id);
        Task<IEnumerable<ICompensationEntryDomain>> GetAll();
        Task<int> Update(ICompensationEntryDomain entity);
    }
}
