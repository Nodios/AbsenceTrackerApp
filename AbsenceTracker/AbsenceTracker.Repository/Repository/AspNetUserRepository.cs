using AbsenceTracker.Model.Common.IDomainModels;
using AbsenceTracker.Repository.Common.IGenericRepository;
using AbsenceTracker.Repository.Common.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AbsenceTracker.DAL.Database;
using AbsenceTracker.Model.DomainModels;
using System.Data.Entity;

namespace AbsenceTracker.Repository.Repository
{
    public class AspNetUserRepository : IAspNetUserRepository
    {
        private readonly IGenericRepository GenericRepository;

        public AspNetUserRepository(IGenericRepository genericRepository)
        {
            this.GenericRepository = genericRepository;
        }
        //Add AspNetUser
        public async Task<int> Add(IAspNetUserDomain entity)
        {
            try
            {
                return await GenericRepository.Add(Mapper.Map<AspNetUser>(entity));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //Delete AspNetUser by Id
        public async Task<int> Delete(string id)
        {
            try
            {
                var item = await GenericRepository.Get<AspNetUser>(id);

                if (item == null)
                    return 0;

                return await GenericRepository.Delete(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Delete AspNetUser by Object
        public async Task<int> Delete(IAspNetUserDomain entity)
        {
            try
            {
                return await GenericRepository.Delete(Mapper.Map<AspNetUser>(entity));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Get AspNetUser by Id
        public async Task<IAspNetUserDomain> Get(string id)
        {
            try
            {
                var response = Mapper.Map<IAspNetUserDomain>(await GenericRepository.Get<AspNetUser>(id));
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Get all AspNetUser
        public async Task<IEnumerable<IAspNetUserDomain>> GetAll()
        {
            try
            {
                var getData = Mapper.Map<IEnumerable<IAspNetUserDomain>>(await GenericRepository.GetAll<AspNetUser>());
                return getData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Update AspNetUser
        public async Task<int> Update(IAspNetUserDomain entity)
        {
            try
            {
                return await GenericRepository.Update(Mapper.Map<AspNetUser>(entity));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //Get user by username
        public async Task<IAspNetUserDomain> GetByUsername(string username)
        {
            try
            {
                var response = Mapper.Map<IAspNetUserDomain>(await GenericRepository
                    .GetQueryable<AspNetUser>().Where(x => x.UserName == username)
                    .Include(a => a.Absences).FirstOrDefaultAsync());
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
