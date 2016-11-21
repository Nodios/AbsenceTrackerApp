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
using AbsenceTracker.Model.DomainModels;

namespace AbsenceTracker.Repository.Repository
{
    public class CompensationEntryRepository : ICompensationEntryRepository
    {
        private readonly IGenericRepository GenericRepository;

        public CompensationEntryRepository(IGenericRepository genericRepository)
        {
            this.GenericRepository = genericRepository;
        }
        //Add CompensationEntry
        public async Task<int> Add(ICompensationEntryDomain entity)
        {
            try
            {
                return await GenericRepository.Add(Mapper.Map<CompensationEntry>(entity));
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        //Delete CompensationEntry by Id
        public async Task<int> Delete(string id)
        {
            try
            {
                var item = await GenericRepository.Get<CompensationEntry>(id);

                if (item == null)
                    return 0;

                return await GenericRepository.Delete(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Delete CompensationEntry by Object
        public async Task<int> Delete(ICompensationEntryDomain entity)
        {
            try
            {
                return await GenericRepository.Delete(Mapper.Map<CompensationEntry>(entity));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Get CompensationEntry by Id
        public async Task<ICompensationEntryDomain> Get(string id)
        {
            try
            {
                var response = Mapper.Map<CompensationEntryDomain>(await GenericRepository.Get<CompensationEntry>(id));
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Get all CompensationEntries
        public async Task<IEnumerable<ICompensationEntryDomain>> GetAll()
        {
            try
            {
                var getData = Mapper.Map<IEnumerable<ICompensationEntryDomain>>(await GenericRepository.GetAll<CompensationEntry>());
                return getData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Update CompensationEntry
        public async Task<int> Update(ICompensationEntryDomain entity)
        {
            try
            {
                return await GenericRepository.Update(Mapper.Map<CompensationEntry>(entity));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
