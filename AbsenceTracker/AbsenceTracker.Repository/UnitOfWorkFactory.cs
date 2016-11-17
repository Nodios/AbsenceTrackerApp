using AbsenceTracker.Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Repository
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        protected readonly IUnitOfWork UnitOfWOrk;

        public UnitOfWorkFactory(IUnitOfWork unitOfWork)
        {
            this.UnitOfWOrk = unitOfWork;
        }

        public IUnitOfWork CreateUnitOfWork()
        {
            return this.UnitOfWOrk;
        }
    }
}
