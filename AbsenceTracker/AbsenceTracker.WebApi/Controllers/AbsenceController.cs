using AbsenceTracker.Model.Common.IDomainModels;
using AbsenceTracker.Model.DomainModels;
using AbsenceTracker.Service.Common;
using AbsenceTracker.WebApi.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace AbsenceTracker.WebApi.Controllers
{
    [RoutePrefix("api/absence")]
    public class AbsenceController : ApiController
    {
        protected IAbsenceService AbsenceService;

        public AbsenceController(IAbsenceService service)
        {
            this.AbsenceService = service;
        }

        [HttpGet]
        [Route("getall")]
        public async Task<HttpResponseMessage> GetAll()
        {
            try
            {
                var response = Mapper.Map<IEnumerable<AbsenceView>>(await AbsenceService.ReadAll());

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        [HttpGet]
        [Route("get")]
        public async Task<HttpResponseMessage> Get(string id)
        {
            try
            {
                var response = AutoMapper.Mapper.Map<AbsenceView>(await AbsenceService.Read(id));

                if (response == null)
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid id.");

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        [HttpPost]
        [Route("add")]
        public async Task<HttpResponseMessage> Add(AbsenceView absenceView)
        {
            int counter = 0;
            try
            {
                //if (absenceView.Sickness != null)
                //{
                //    counter++;
                //}
                //if (absenceView.Vacation != null)
                //{
                //    counter++;
                //}
                //if (absenceView.Compensation != null)
                //{
                //    counter++;
                //}
                if (absenceView.Type == null || (counter == 0 || counter > 1))
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid request");

                absenceView.Id = Guid.NewGuid().ToString();

                var response = await AbsenceService.Add(Mapper.Map<AbsenceDomain>(absenceView));

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }

        }

        [HttpDelete]
        [Route("delete")]
        public async Task<HttpResponseMessage> Delete(string id)
        {
            try
            {
                var response = await AbsenceService.Delete(id);

                if (response == 0)
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Couldn't delete entry.");

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        [HttpPut]
        [Route("update")]
        public async Task<HttpResponseMessage> Update(AbsenceView absenceView)
        {
            int counter = 0;
            try
            {
                var toBeUpdated = await AbsenceService.Read(absenceView.Id);

                //if (absenceView.Sickness != null)
                //{
                //    counter++;
                //    toBeUpdated.Sickness = Mapper.Map<ISicknessDomain>(absenceView.Sickness);
                //}
                //if (absenceView.Vacation != null)
                //{
                //    counter++;
                //    toBeUpdated.Vacation = Mapper.Map<IVacationDomain>(absenceView.Vacation);
                //}
                //if (absenceView.Compensation != null)
                //{
                //    counter++;
                //    toBeUpdated.Compensation = Mapper.Map<ICompensationDomain>(absenceView.Compensation);
                //}

                if (toBeUpdated == null || (counter == 0 || counter > 1))
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Entry not found");

                var response = await AbsenceService.Update(Mapper.Map<AbsenceDomain>(toBeUpdated));

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }
    }
}
