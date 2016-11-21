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
    [RoutePrefix("api/compensation")]
    public class CompensationController : ApiController
    {
        protected ICompensationService CompensationService;

        public CompensationController(ICompensationService service)
        {
            this.CompensationService = service;
        }

        [HttpGet]
        [Route("getall")]
        public async Task<HttpResponseMessage> GetAll()
        {
            try
            {
                var response = Mapper.Map<IEnumerable<CompensationView>>(await CompensationService.ReadAll());

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
                var response = AutoMapper.Mapper.Map<CompensationView>(await CompensationService.Read(id));

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
        public async Task<HttpResponseMessage> Add(CompensationView compensationView)
        {
            try
            {
                if (compensationView.Absence == null || compensationView.AbsenceDate == null ||
                    compensationView.EstimatedTime == 0 || compensationView.Id == null)
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid request.");

                compensationView.Id = Guid.NewGuid().ToString();

                var response = await CompensationService.Add(Mapper.Map<CompensationDomain>(compensationView));

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
                var toBeDeleted = await CompensationService.Read(id);

                if(toBeDeleted == null )
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Couldn't find entry.");

                var response = await CompensationService.Delete(id);

                if (response == 0)
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Couldn't delete entry.");

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        [HttpPut]
        [Route("update")]
        public async Task<HttpResponseMessage> Update(CompensationView compensationView)
        {
            try
            {
                var toBeUpdated = await CompensationService.Read(compensationView.Id);

                if (toBeUpdated == null)
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Entry not found");

                if (compensationView.CompensationEntries != null)
                {
                    toBeUpdated.CompensationEntries = Mapper.Map<ICollection<ICompensationEntryDomain>>(compensationView.CompensationEntries);
                }

                if (compensationView.TotalSpentTime != 0)
                    toBeUpdated.TotalSpentTime = compensationView.TotalSpentTime;

                var response = await CompensationService.Update(Mapper.Map<CompensationDomain>(toBeUpdated));

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

    }
}
