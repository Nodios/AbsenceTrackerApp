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
    [RoutePrefix("api/sickness")]
    public class SicknessController : ApiController
    {
        protected ISicknessService SicknessService;

        public SicknessController(ISicknessService service)
        {
            this.SicknessService = service;
        }

        [HttpGet]
        [Route("getall")]
        public async Task<HttpResponseMessage> GetAll()
        {
            try
            {
                var response = Mapper.Map<IEnumerable<SicknessView>>(await SicknessService.ReadAll());

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
                var response = AutoMapper.Mapper.Map<SicknessView>(await SicknessService.Read(id));

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
        //public async Task<HttpResponseMessage> Add(SicknessView sicknessView)
        //{
        //    try
        //    {
        //        if (sicknessView.Absence == null || sicknessView.StartDate == null || sicknessView.EndDate == null || sicknessView.Time == 0)
        //            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid request");

        //        sicknessView.Id = Guid.NewGuid().ToString();

        //        var response = await SicknessService.Add(Mapper.Map<SicknessDomain>(sicknessView));

        //        return Request.CreateResponse(HttpStatusCode.OK, response);
        //    }
        //    catch (Exception e)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
        //    }

        //}

        [HttpDelete]
        [Route("delete")]
        public async Task<HttpResponseMessage> Delete(string id)
        {
            try
            {
                var response = await SicknessService.Delete(id);

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
        public async Task<HttpResponseMessage> Update(SicknessView sicknessView)
        {
            try
            {
                var toBeUpdated = await SicknessService.Read(sicknessView.Id);

                if (toBeUpdated == null)
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Entry not found");

                if (sicknessView.StartDate != null)
                {
                    toBeUpdated.StartDate = sicknessView.StartDate;
                }
                if (sicknessView.EndDate != null)
                {
                    toBeUpdated.EndDate = sicknessView.EndDate;
                }
                if (sicknessView.Time != 0)
                {
                    toBeUpdated.Time = sicknessView.Time;
                }

                var response = await SicknessService.Update(Mapper.Map<SicknessDomain>(toBeUpdated));

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }
    }
}
