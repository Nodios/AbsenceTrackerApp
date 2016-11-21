using AbsenceTracker.Model.Common.IDomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Service.Common
{
    public interface ISicknessService
    {
        Task<int> Add(ISicknessDomain entry);
        Task<int> Delete(string id);
        Task<int> Delete(ISicknessDomain entry);
        Task<ISicknessDomain> Read(string id);
        Task<IEnumerable<ISicknessDomain>> ReadAll();
        Task<int> Update(ISicknessDomain entry);



    }
}
