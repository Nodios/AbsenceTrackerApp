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
    public class VacationService : IVacationService
    {
        protected IVacationRepository VacationRepository { get; private set; }
        public VacationService(IVacationRepository rep)
        {
            this.VacationRepository = rep;
        }

        //Add Vacation
        public async Task<int> Add(IVacationDomain entry)
        {
            try
            {
                return await VacationRepository.Add(entry);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //Delete Vacation by id
        public async Task<int> Delete(Guid id)
        {
            try
            {
                return await VacationRepository.Delete(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //Delete Vacation by object
        public async Task<int> Delete(IVacationDomain entry)
        {
            try
            {
                return await VacationRepository.Delete(entry);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //Get Vacation by Id
        public async Task<IVacationDomain> Read(Guid id)
        {
            try
            {
                var response = await VacationRepository.Get(id);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //Get All Vacations
        public async Task<IEnumerable<IVacationDomain>> ReadAll()
        {
            try
            {
                var response = await VacationRepository.GetAll();

                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        //Update Vacation
        public async Task<int> Update(IVacationDomain entry)
        {
            try
            {
                return await VacationRepository.Update(entry);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
