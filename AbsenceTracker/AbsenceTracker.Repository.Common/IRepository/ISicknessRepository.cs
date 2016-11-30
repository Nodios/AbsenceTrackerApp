using AbsenceTracker.Model.Common.IDomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Repository.Common.IRepository
{
    public interface ISicknessRepository
    {
        Task<int> Add(ISicknessDomain entity);
        Task<int> Delete(Guid id);
        Task<int> Delete(ISicknessDomain entity);
        Task<ISicknessDomain> Get(Guid id);
        Task<IEnumerable<ISicknessDomain>> GetAll();
        Task<int> Update(ISicknessDomain entity);

    }
}
