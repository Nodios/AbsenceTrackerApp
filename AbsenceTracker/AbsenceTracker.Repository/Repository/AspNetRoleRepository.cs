using AbsenceTracker.DAL.Database;
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
    public class AspNetRoleRepository : IAspNetRoleRepository
    {
        private readonly IGenericRepository GenericRepository;

        public AspNetRoleRepository(IGenericRepository genericRepository)
        {
            this.GenericRepository = genericRepository;
        }
        //Add AspNetRole
        public async Task<int> Add(IAspNetRoleDomain entity)
        {
            try
            {
                return await GenericRepository.Add(Mapper.Map<AspNetRole>(entity));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //Delete AspNetRole by Id
        public async Task<int> Delete(string id)
        {
            try
            {
                var item = await GenericRepository.Get<AspNetRole>(id);

                if (item == null)
                    return 0;

                return await GenericRepository.Delete(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Delete AspNetRole by Object
        public async Task<int> Delete(IAspNetRoleDomain entity)
        {
            try
            {
                return await GenericRepository.Delete(Mapper.Map<AspNetRole>(entity));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Get AspNetRole by Id
        public async Task<IAspNetRoleDomain> Get(string id)
        {
            try
            {
                var response = Mapper.Map<IAspNetRoleDomain>(await GenericRepository.Get<AspNetRole>(id));
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Get all AspNetRole
        public async Task<IEnumerable<IAspNetRoleDomain>> GetAll()
        {
            try
            {
                var getData = Mapper.Map<IEnumerable<IAspNetRoleDomain>>(await GenericRepository.GetAll<AspNetRole>());
                return getData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Update AspNetRole
        public async Task<int> Update(IAspNetRoleDomain entity)
        {
            try
            {
                return await GenericRepository.Update(Mapper.Map<AspNetRole>(entity));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
