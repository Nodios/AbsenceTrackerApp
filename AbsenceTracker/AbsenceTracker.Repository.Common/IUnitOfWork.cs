using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Repository.Common
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> Commit();
        void Dispose();
    }
}
