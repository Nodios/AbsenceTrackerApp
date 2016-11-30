using AbsenceTracker.DAL;
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
    public class SicknessRepository : ISicknessRepository
    {
        private readonly IGenericRepository GenericRepository;

        public SicknessRepository(IGenericRepository genericRepository)
        {
            this.GenericRepository = genericRepository;
        }

        //Add Sickness
        public async Task<int> Add(ISicknessDomain entity)
        {
            try
            {
                return await GenericRepository.Add(Mapper.Map<SicknessDomain>(entity));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //Delete Sickness by Id
        public async Task<int> Delete(Guid id)
        {
            try
            {
                var item = await GenericRepository.Get<Sickness>(id);

                if (item == null)
                    return 0;

                return await GenericRepository.Delete(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Delete Sickness by Object
        public async Task<int> Delete(ISicknessDomain entity)
        {
            try
            {
                return await GenericRepository.Delete(Mapper.Map<SicknessDomain>(entity));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Get Sickness by Id
        public async Task<ISicknessDomain> Get(Guid id)
        {
            try
            {
                var response = Mapper.Map<SicknessDomain>(await GenericRepository.Get<Sickness>(id));
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Get all Sickness
        public async Task<IEnumerable<ISicknessDomain>> GetAll()
        {
            try
            {
                var getData = Mapper.Map<IEnumerable<ISicknessDomain>>(await GenericRepository.GetAll<Sickness>());
                return getData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Update Sickness
        public async Task<int> Update(ISicknessDomain entity)
        {
            try
            {
                return await GenericRepository.Update(Mapper.Map<Sickness>(entity));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
