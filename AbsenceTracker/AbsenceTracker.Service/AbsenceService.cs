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
    public class AbsenceService : IAbsenceService
    {
        protected IAbsenceRepository AbsenceRepository { get; private set; }
        public AbsenceService(IAbsenceRepository rep)
        {
            this.AbsenceRepository = rep;
        }

        //Add Absence
        public async Task<int> Add(IAbsenceDomain entry)
        {
            try
            {
                return await AbsenceRepository.Add(entry);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //Delete Absence by id
        public async Task<int> Delete(string id)
        {
            try
            {
                return await AbsenceRepository.Delete(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //Delete Absence by object
        public async Task<int> Delete(IAbsenceDomain entry)
        {
            try
            {
                return await AbsenceRepository.Delete(entry);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //Get Absence by Id
        public async Task<IAbsenceDomain> Read(string id)
        {
            try
            {
                var response = await AbsenceRepository.Get(id);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //Get All Absences
        public async Task<IEnumerable<IAbsenceDomain>> ReadAll()
        {
            try
            {
                var response = await AbsenceRepository.GetAll();

                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        //Update Absence
        public async Task<int> Update(IAbsenceDomain entry)
        {
            try
            {
                return await AbsenceRepository.Update(entry);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
