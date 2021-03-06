﻿using AbsenceTracker.Model.Common.IDomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Service.Common
{
    public interface ICompensationEntryService
    {
        Task<int> Add(ICompensationEntryDomain entry);
        Task<int> Delete(Guid id);
        Task<int> Delete(ICompensationEntryDomain entry);
        Task<ICompensationEntryDomain> Read(Guid id);
        Task<IEnumerable<ICompensationEntryDomain>> ReadAll();
        Task<int> Update(ICompensationEntryDomain entry);
    }
}
