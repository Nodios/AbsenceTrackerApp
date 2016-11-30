using AbsenceTracker.Model.Common.IDomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Repository.Common.IRepository
{
    public interface ICompensationRepository
    {
        Task<int> Add(ICompensationDomain entity);
        Task<int> Delete(Guid id);
        Task<int> Delete(ICompensationDomain entity);
        Task<ICompensationDomain> Get(Guid id);
        Task<IEnumerable<ICompensationDomain>> GetAll();
        Task<int> Update(ICompensationDomain entity);

    }
}
