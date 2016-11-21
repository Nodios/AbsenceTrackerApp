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
    public class CompensationService : ICompensationService
    {
        protected ICompensationRepository CompensationRepository { get; private set; }
        public CompensationService(ICompensationRepository rep)
        {
            this.CompensationRepository = rep;
        }

        //Add Sickness
        public async Task<int> Add(ICompensationDomain entry)
        {
            try
            {
                return await CompensationRepository.Add(entry);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //Delete Compensation by id
        public async Task<int> Delete(string id)
        {
            try
            {
                return await CompensationRepository.Delete(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //Delete Compensation by object
        public async Task<int> Delete(ICompensationDomain entry)
        {
            try
            {
                return await CompensationRepository.Delete(entry);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //Get Compensation by Id
        public async Task<ICompensationDomain> Read(string id)
        {
            try
            {
                var response = await CompensationRepository.Get(id);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //Get All Compensations
        public async Task<IEnumerable<ICompensationDomain>> ReadAll()
        {
            try
            {
                var response = await CompensationRepository.GetAll();

                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Update Compensation Entry
        public async Task<int> Update(ICompensationDomain entry)
        {
            try
            {
                return await CompensationRepository.Update(entry);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
