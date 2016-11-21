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
    public class AspNetUserClaimRepository : IAspNetUserClaimRepository
    {
        private readonly IGenericRepository GenericRepository;

        public AspNetUserClaimRepository(IGenericRepository genericRepository)
        {
            this.GenericRepository = genericRepository;
        }
        //Add AspNetUserClaim
        public async Task<int> Add(IAspNetUserClaimDomain entity)
        {
            try
            {
                return await GenericRepository.Add(Mapper.Map<AspNetUserClaim>(entity));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //Delete AspNetUserClaim by Id
        public async Task<int> Delete(string id)
        {
            try
            {
                var item = await GenericRepository.Get<AspNetUserClaim>(id);

                if (item == null)
                    return 0;

                return await GenericRepository.Delete(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Delete AspNetUserClaim by Object
        public async Task<int> Delete(IAspNetUserClaimDomain entity)
        {
            try
            {
                return await GenericRepository.Delete(Mapper.Map<AspNetUserClaim>(entity));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Get AspNetUserClaim by Id
        public async Task<IAspNetUserClaimDomain> Get(string id)
        {
            try
            {
                var response = Mapper.Map<IAspNetUserClaimDomain>(await GenericRepository.Get<AspNetUserClaim>(id));
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Get all AspNetUserClaim
        public async Task<IEnumerable<IAspNetUserClaimDomain>> GetAll()
        {
            try
            {
                var getData = Mapper.Map<IEnumerable<IAspNetUserClaimDomain>>(await GenericRepository.GetAll<AspNetUserClaim>());
                return getData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Update AspNetUserClaim
        public async Task<int> Update(IAspNetUserClaimDomain entity)
        {
            try
            {
                return await GenericRepository.Update(Mapper.Map<AspNetUserClaim>(entity));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
