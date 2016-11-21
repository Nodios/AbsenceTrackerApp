using AbsenceTracker.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using AbsenceTracker.WebApi.ViewModels;

namespace AbsenceTracker.WebApi.Controllers
{
    [RoutePrefix("api/aspnetuser")]
    public class AspNetUserController : ApiController
    {
        protected IAspNetUserService AspNetUserService;

        public AspNetUserController(IAspNetUserService aspNetUser)
        {
            this.AspNetUserService = aspNetUser;
        }

        [HttpGet]
        [Route("getall")]
        public async Task<HttpResponseMessage> GetAll()
        {
            try
            {
                var response = Mapper.Map<IEnumerable<AspNetUserView>>(await AspNetUserService.ReadAll());

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpGet]
        [Route("get")]
        public async Task<HttpResponseMessage> Get(string id)
        {
            try
            {
                var response = AutoMapper.Mapper.Map<CompensationEntryView>(await CompensationEntryService.Read(id));

                if (response == null)
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bad id.");

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpPost]
        [Route("add")]
        public async Task<HttpResponseMessage> Add(CompensationEntryView compensationEntryView)
        {
            try
            {
                if (compensationEntryView.Date == null || compensationEntryView.SpentTime == 0)
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Krivi unos.");

                compensationEntryView.Id = Guid.NewGuid().ToString();

                var response = await CompensationEntryService.Add(Mapper.Map<CompensationEntryDomain>(compensationEntryView));

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        [HttpDelete]
        [Route("delete")]
        public async Task<HttpResponseMessage> Delete(string id)
        {
            try
            {
                var response = await CompensationEntryService.Delete(id);

                if (response == 0)
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Couldn't delete entry.");

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpPut]
        [Route("update")]
        public async Task<HttpResponseMessage> Update(CompensationEntryView compensationEntryView)
        {
            try
            {
                var toBeUpdated = await CompensationEntryService.Read(compensationEntryView.Id);

                if (toBeUpdated == null)
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Entry not found");

                if (compensationEntryView.Date != null)
                    toBeUpdated.Date = compensationEntryView.Date;
                if (compensationEntryView.SpentTime != 0)
                    toBeUpdated.SpentTime = compensationEntryView.SpentTime;

                var response = await CompensationEntryService.Update(Mapper.Map<CompensationEntryDomain>(toBeUpdated));

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
