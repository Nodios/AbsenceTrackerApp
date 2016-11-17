using AbsenceTracker.Repository.Common;
using AbsenceTracker.Repository.Common.IGenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Repository.GenericRepository
{
    public class GenericRepository : IGenericRepository
    {
        //private readonly IContext Context {get; set; }
        protected IUnitOfWorkFactory UnitOfWorkFactory { get; set; }
        public GenericRepository(IUnitOfWorkFactory unitOfWorkFactory) //parameter IContext context
        {
            //this.Context = context;
            this.UnitOfWorkFactory = unitOfWorkFactory;
        }

        public async Task<int> Add<T>(T entity) where T : class
        {
            try
            {
                //Context.Set<T>().Add(entity);
                //return await Context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw e;
            }

            throw new NotImplementedException();

        }

        public async Task<int> Delete<T>(Guid id) where T : class
        {
            try
            {
                //T entity = await Get<T>(id);
                //Context.Set<T>().Remove(entity);
                //return await Context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw e;
            }

            throw new NotImplementedException();

        }

        public async Task<int> Delete<T>(T entity) where T : class
        {
            try
            {
                //Context.Set<T>().Remove(entity);
                //return await Context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw e;
            }

            throw new NotImplementedException();

        }

        public async Task<T> Get<T>(Guid id) where T : class
        {
            try
            {
                //var response = await Context.Set<T>().FindAsync(id);
                //return response;
            }
            catch (Exception e)
            {
                throw e;
            }

            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAll<T>() where T : class
        {
            try
            {
                //var response = await Context.Set<T>().ToListAsync();
                //return response;
            }
            catch (Exception e)
            {
                throw e;
            }

            throw new NotImplementedException();
        }

        public async Task<T> GetWhere<T>(Expression<Func<T, bool>> match) where T : class
        {
            try
            {
                //var response = await Context.Set<T>().FirstAsync(match);
                //return response;
            }
            catch (Exception e)
            {
                throw e;
            }

            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetRangeAsync<T>(Expression<Func<T, bool>> match) where T : class
        {
            try
            {
                //var response = await Context.Set<T>().Where(match).ToListAsync();
                //return response;
            }
            catch (Exception e)
            {
                throw e;
            }

            throw new NotImplementedException();
        }

        public async Task<int> Update<T>(T entity) where T : class
        {
            try
            {
                //Context.Set<T>().AddOrUpdate(entity);
                //return await Context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw e;
            }

            throw new NotImplementedException();
        }

        public IQueryable<T> GetQueryable<T>() where T : class
        {
            try
            {
                //return Context.Set<T>();
            }
            catch (Exception e)
            {
                throw e;
            }

            throw new NotImplementedException();
        }
    }
}
