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
    [RoutePrefix("api/vacation")]
    public class VacationController : ApiController
    {
        protected IVacationService VacationService;

        public VacationController(IVacationService service)
        {
            this.VacationService = service;
        }

        [HttpGet]
        [Route("getall")]
        public async Task<HttpResponseMessage> GetAll()
        {
            try
            {
                var response = Mapper.Map<IEnumerable<VacationView>>(await VacationService.ReadAll());

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        [HttpGet]
        [Route("get")]
        public async Task<HttpResponseMessage> Get(Guid id)
        {
            try
            {
                var response = AutoMapper.Mapper.Map<VacationView>(await VacationService.Read(id));

                if (response == null)
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid id.");

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        //[HttpPost]
        //[Route("add")]
        //public async Task<HttpResponseMessage> Add(VacationView vacationView)
        //{
        //    try
        //    {
        //        if (vacationView.Absence == null || vacationView.StartDate == null || vacationView.EndDate == null || vacationView.Time == 0 || vacationView.TimeLeft == 0)
        //            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid request");

        //        vacationView.Id = Guid.NewGuid().ToString();

        //        var response = await VacationService.Add(Mapper.Map<VacationDomain>(vacationView));

        //        return Request.CreateResponse(HttpStatusCode.OK, response);
        //    }
        //    catch (Exception e)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
        //    }

        //}

        [HttpDelete]
        [Route("delete")]
        public async Task<HttpResponseMessage> Delete(Guid id)
        {
            try
            {
                var response = await VacationService.Delete(id);

                if (response == 0)
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Couldn't delete entry.");

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        //[HttpPut]
        //[Route("update")]
        //public async Task<HttpResponseMessage> Update(VacationView vacationView)
        //{
        //    try
        //    {
        //        var toBeUpdated = await VacationService.Read(vacationView.Id);

        //        if (toBeUpdated == null)
        //            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Entry not found");

        //        if (vacationView.StartDate != null)
        //        {
        //            toBeUpdated.StartDate = vacationView.StartDate;
        //        }
        //        if (vacationView.EndDate != null)
        //        {
        //            toBeUpdated.EndDate = vacationView.EndDate;
        //        }
        //        if (vacationView.Time != 0)
        //        {
        //            toBeUpdated.Time = vacationView.Time;
        //        }
        //        if (vacationView.TimeLeft != 0)
        //        {
        //            toBeUpdated.TimeLeft = vacationView.TimeLeft;
        //        }

        //        var response = await VacationService.Update(Mapper.Map<VacationDomain>(toBeUpdated));

        //        return Request.CreateResponse(HttpStatusCode.OK, response);
        //    }
        //    catch (Exception e)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
        //    }
        //}
    }
}
