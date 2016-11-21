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
        Task<int> Delete(string id);
        Task<int> Delete(ISicknessDomain entity);
        Task<ISicknessDomain> Get(string id);
        Task<IEnumerable<ISicknessDomain>> GetAll();
        Task<int> Update(ISicknessDomain entity);

    }
}
