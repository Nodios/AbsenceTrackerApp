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
    public class CompensationEntryService : ICompensationEntryService
    {
        protected ICompensationEntryRepository CompensationEntryRepository { get; private set; }
        public CompensationEntryService(ICompensationEntryRepository rep)
        {
            this.CompensationEntryRepository = rep;
        }

        //Add CompensationEntry
        public async Task<int> Add(ICompensationEntryDomain entry)
        {
            try
            {
                return await CompensationEntryRepository.Add(entry);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        //Delete CompensationEntry by id
        public async Task<int> Delete(string id)
        {
            try
            {
                return await CompensationEntryRepository.Delete(id);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        //Delete CompensationEntry by object
        public async Task<int> Delete(ICompensationEntryDomain entry)
        {
            try
            {
                return await CompensationEntryRepository.Delete(entry);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //Get CompensationEntry by Id
        public async Task<ICompensationEntryDomain> Read(string id)
        {
            try
            {
                var response = await CompensationEntryRepository.Get(id);
                return response;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        //Get All CompensationEntry 
        public async Task<IEnumerable<ICompensationEntryDomain>> ReadAll()
        {
            try
            {
                var response = await CompensationEntryRepository.GetAll();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        //Update Compensation Entry
        public async Task<int> Update(ICompensationEntryDomain entry)
        {
            try
            {
                return await CompensationEntryRepository.Update(entry);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }

}

