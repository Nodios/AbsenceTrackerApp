using AbsenceTracker.DAL.Database;
using AbsenceTracker.Model.Common.IDomainModels;
using AbsenceTracker.Model.DomainModels;
using AbsenceTracker.Repository.Common.IGenericRepository;
using AbsenceTracker.Repository.Common.IRepository;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Repository.Repository
{
    public class CompensationRepository : ICompensationRepository
    {
        private readonly IGenericRepository GenericRepository;

        public CompensationRepository(IGenericRepository genericRepository)
        {
            this.GenericRepository = genericRepository;
        }

        //Add Compensation
        public async Task<int> Add(ICompensationDomain entity)
        {
            try
            {
                return await GenericRepository.Add(Mapper.Map<Compensation>(entity));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //Delete Compensation by Id
        public async Task<int> Delete(string id)
        {
            try
            {
                var item = await GenericRepository.Get<Compensation>(id);

                if (item == null)
                    return 0;

                return await GenericRepository.Delete(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Delete Compensation by Object
        public async Task<int> Delete(ICompensationDomain entity)
        {
            try
            {
                return await GenericRepository.Delete(Mapper.Map<Compensation>(entity));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Get CompensationEntry by Id
        public async Task<ICompensationDomain> Get(string id)
        {
            try
            {
                var response = Mapper.Map<CompensationDomain>(await GenericRepository.Get<Compensation>(id));
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Get all Compensations
        public async Task<IEnumerable<ICompensationDomain>> GetAll()
        {
            try
            {
                var getData = Mapper.Map<IEnumerable<ICompensationDomain>>(await GenericRepository.GetAll<Compensation>());
                return getData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Update Compensation
        public async Task<int> Update(ICompensationDomain entity)
        {
            try
            {
                return await GenericRepository.Update(Mapper.Map<Compensation>(entity));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
