using AbsenceTracker.Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbsenceTracker.DAL.Common.IDatabaseModels;

namespace AbsenceTracker.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        protected IAbsenceTrackerEntities Context;

        public UnitOfWork(IAbsenceTrackerEntities context)
        {
            this.Context = context;
        }

        public async Task<int> Commit()
        {
            return await Context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
