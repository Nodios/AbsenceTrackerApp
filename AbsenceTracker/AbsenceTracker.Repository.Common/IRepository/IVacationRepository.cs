﻿using AbsenceTracker.Model.Common.IDomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Repository.Common.IRepository
{
    public interface IVacationRepository
    {
        Task<int> Add(IVacationDomain entity);
        Task<int> Delete(Guid id);
        Task<int> Delete(IVacationDomain entity);
        Task<IVacationDomain> Get(Guid id);
        Task<IEnumerable<IVacationDomain>> GetAll();
        Task<int> Update(IVacationDomain entity);
    }
}
