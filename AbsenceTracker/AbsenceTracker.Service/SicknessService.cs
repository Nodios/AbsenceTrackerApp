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
    public class SicknessService : ISicknessService
    {
        protected ISicknessRepository SicknessRepository { get; private set; }
        public SicknessService(ISicknessRepository rep)
        {
            this.SicknessRepository = rep;
        }

        //Add Sickness
        public async Task<int> Add(ISicknessDomain entry)
        {
            try
            {
                return await SicknessRepository.Add(entry);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //Delete Sickness by id
        public async Task<int> Delete(string id)
        {
            try
            {
                return await SicknessRepository.Delete(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //Delete Sickness by object
        public async Task<int> Delete(ISicknessDomain entry)
        {
            try
            {
                return await SicknessRepository.Delete(entry);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //Get Sickness by Id
        public async Task<ISicknessDomain> Read(string id)
        {
            try
            {
                var response = await SicknessRepository.Get(id);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //Get All Sickness
        public async Task<IEnumerable<ISicknessDomain>> ReadAll()
        {
            try
            {
                var response = await SicknessRepository.GetAll();

                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Update Sickness Entry
        public async Task<int> Update(ISicknessDomain entry)
        {
            try
            {
                return await SicknessRepository.Update(entry);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
