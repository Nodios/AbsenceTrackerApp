﻿using AbsenceTracker.Model.Common.IDomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Service.Common
{
    public interface IAspNetUserService
    {
        Task<int> Add(IAspNetUserDomain entry);
        Task<int> Delete(string id);
        Task<int> Delete(IAspNetUserDomain entry);
        Task<IAspNetUserDomain> Read(string id);
        Task<IEnumerable<IAspNetUserDomain>> ReadAll();
        Task<int> Update(IAspNetUserDomain entry);
        Task<IAspNetUserDomain> FindByUserName(string email);
    }
}
