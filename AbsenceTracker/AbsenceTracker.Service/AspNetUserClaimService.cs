using AbsenceTracker.Model.Common.IDomainModels;
using AbsenceTracker.Repository.Common.IRepository;
using AbsenceTracker.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Service
{
    public class AspNetUserClaimService : IAspNetUserClaimService
    {
        protected IAspNetUserClaimRepository AspNetUserClaimRepository { get; private set; }
        public AspNetUserClaimService(IAspNetUserClaimRepository rep)
        {
            this.AspNetUserClaimRepository = rep;
        }

        //Add AspNetUserClaim
        public async Task<int> Add(IAspNetUserClaimDomain entry)
        {
            try
            {
                return await AspNetUserClaimRepository.Add(entry);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //Delete AspNetUserClaim by id
        public async Task<int> Delete(string id)
        {
            try
            {
                return await AspNetUserClaimRepository.Delete(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //Delete AspNetUserClaim by object
        public async Task<int> Delete(IAspNetUserClaimDomain entry)
        {
            try
            {
                return await AspNetUserClaimRepository.Delete(entry);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //Get AspNetUserClaim by Id
        public async Task<IAspNetUserClaimDomain> Read(string id)
        {
            try
            {
                var response = await AspNetUserClaimRepository.Get(id);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //Get All AspNetUserClaim
        public async Task<IEnumerable<IAspNetUserClaimDomain>> ReadAll()
        {
            try
            {
                var response = await AspNetUserClaimRepository.GetAll();

                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        //Update AspNetUserClaim 
        public async Task<int> Update(IAspNetUserClaimDomain entry)
        {
            try
            {
                return await AspNetUserClaimRepository.Update(entry);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
