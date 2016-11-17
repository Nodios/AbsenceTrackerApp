using AbsenceTracker.Repository.Common.IGenericRepository;
using AbsenceTracker.Repository.Common.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Repository.Repository
{
    public class SicknessRepository : ISicknessRepository
    {
        private readonly IGenericRepository GenericRepository;

        public SicknessRepository(IGenericRepository genericRepository)
        {
            this.GenericRepository = genericRepository;
        }
    }
}
