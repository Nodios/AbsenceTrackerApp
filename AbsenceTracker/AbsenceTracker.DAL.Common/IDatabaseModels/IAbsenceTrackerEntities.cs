using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.DAL.Common.IDatabaseModels
{
    public interface IAbsenceTrackerEntities : IDisposable
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbSet Set(Type entityType);
        int SaveChanges();
        IEnumerable<DbEntityValidationResult> GetValidationErrors();
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        DbEntityEntry Entry(object entity);
        string ConnectionString { get; set; }
        bool AutoDetectChangedEnabled { get; set; }
        void ExecuteSqlCommand(string p, params object[] o);
        void ExecuteSqlCommand(string p);
        Task<int> SaveChangesAsync();
        DbContextConfiguration Configuration { get; }
    }
}
