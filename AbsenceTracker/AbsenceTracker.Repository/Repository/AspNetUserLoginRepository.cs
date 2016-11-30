using AbsenceTracker.DAL;
using AbsenceTracker.Model.Common.IDomainModels;
using AbsenceTracker.Repository.Common.IGenericRepository;
using AbsenceTracker.Repository.Common.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace AbsenceTracker.Repository.Repository
{
    public class AspNetUserLoginRepository : IAspNetUserLoginRepository
    {
        private readonly IGenericRepository GenericRepository;

        public AspNetUserLoginRepository(IGenericRepository genericRepository)
        {
            this.GenericRepository = genericRepository;
        }
        //Add AspNetUserLogin
        public async Task<int> Add(IAspNetUserLoginDomain entity)
        {
            try
            {
                return await GenericRepository.Add(Mapper.Map<AspNetUserLogin>(entity));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //Delete AspNetUserLogin by Id
        public async Task<int> Delete(string id)
        {
            try
            {
                var item = await GenericRepository.Get<AspNetUserLogin>(id);

                if (item == null)
                    return 0;

                return await GenericRepository.Delete(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Delete AspNetUserLogin by Object
        public async Task<int> Delete(IAspNetUserLoginDomain entity)
        {
            try
            {
                return await GenericRepository.Delete(Mapper.Map<AspNetUserLogin>(entity));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Get AspNetUserLogin by Id
        public async Task<IAspNetUserLoginDomain> Get(string id)
        {
            try
            {
                var response = Mapper.Map<IAspNetUserLoginDomain>(await GenericRepository.Get<AspNetUserLogin>(id));
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Get all AspNetUserLogin
        public async Task<IEnumerable<IAspNetUserLoginDomain>> GetAll()
        {
            try
            {
                var getData = Mapper.Map<IEnumerable<IAspNetUserLoginDomain>>(await GenericRepository.GetAll<AspNetUserLogin>());
                return getData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Update AspNetUserLogin
        public async Task<int> Update(IAspNetUserLoginDomain entity)
        {
            try
            {
                return await GenericRepository.Update(Mapper.Map<AspNetUserLogin>(entity));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
