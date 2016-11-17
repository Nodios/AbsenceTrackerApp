using AbsenceTracker.Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        //protected IContext Context;

        public UnitOfWork()//IContext context
        {
            //this.Context = context;
        }

        public async Task<int> Commit()
        {
            try
            {
                //return await Context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            //Context.Dispose();
            throw new NotImplementedException();
        }
    }
}
