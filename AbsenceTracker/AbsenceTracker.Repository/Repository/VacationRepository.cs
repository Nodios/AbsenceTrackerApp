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
using AbsenceTracker.Repository.GenericRepository;

namespace AbsenceTracker.Repository.Repository
{
    public class VacationRepository : IVacationRepository
    {
        private readonly IGenericRepository GenericRepository;

        public VacationRepository(IGenericRepository genericRepository)
        {
            this.GenericRepository = genericRepository;
        }


        //Add Vacation
        public async Task<int> Add(IVacationDomain entity)
        {
            try
            {
                return await GenericRepository.Add(Mapper.Map<Vacation>(entity));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //Delete Vacation by Id
        public async Task<int> Delete(string id)
        {
            try
            {
                var item = await GenericRepository.Get<Vacation>(id);

                if (item == null)
                    return 0;

                return await GenericRepository.Delete(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Delete Vacation by Object
        public async Task<int> Delete(IVacationDomain entity)
        {
            try
            {
                return await GenericRepository.Delete(Mapper.Map<Vacation>(entity));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Get Vacation by Id
        public async Task<IVacationDomain> Get(string id)
        {
            try
            {
                var response = Mapper.Map<VacationDomain>(await GenericRepository.Get<Vacation>(id));
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Get all Vacations
        public async Task<IEnumerable<IVacationDomain>> GetAll()
        {
            try
            {
                var getData = Mapper.Map<IEnumerable<IVacationDomain>>(await GenericRepository.GetAll<Vacation>());
                return getData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Update Vacation
        public async Task<int> Update(IVacationDomain entity)
        {
            try
            {
                return await GenericRepository.Update(Mapper.Map<Vacation>(entity));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
