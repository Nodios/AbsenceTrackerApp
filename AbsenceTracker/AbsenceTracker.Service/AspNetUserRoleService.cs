using AbsenceTracker.Model.Common.IDomainModels;
using AbsenceTracker.Model.DomainModels;
using AbsenceTracker.Repository.Common.IRepository;
using AbsenceTracker.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Service
{
    public class AspNetUserRoleService : IAspNetUserRoleService
    {
        protected IAspNetUserRoleRepository AspNetUserRoleRepository { get; private set; }
        public AspNetUserRoleService(IAspNetUserRoleRepository rep)
        {
            this.AspNetUserRoleRepository = rep;
        }

        //Add AspNetUserRole
        public async Task<int> Add(IAspNetUserRoleDomain entry)
        {
            try
            {
                return await AspNetUserRoleRepository.Add(entry);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //Delete AspNetUserRole by id
        public async Task<int> Delete(string id)
        {
            try
            {
                return await AspNetUserRoleRepository.Delete(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //Delete AspNetUserRole by object
        public async Task<int> Delete(IAspNetUserRoleDomain entry)
        {
            try
            {
                return await AspNetUserRoleRepository.Delete(entry);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //Get AspNetUserRole by Id
        public async Task<IAspNetUserRoleDomain> Read(string id)
        {
            try
            {
                var response = await AspNetUserRoleRepository.Get(id);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //Get All AspNetUserRole
        public async Task<IEnumerable<IAspNetUserRoleDomain>> ReadAll()
        {
            try
            {
                var response = await AspNetUserRoleRepository.GetAll();

                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        //Update AspNetUserRole Entry
        public async Task<int> Update(IAspNetUserRoleDomain entry)
        {
            try
            {
                return await AspNetUserRoleRepository.Update(entry);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
