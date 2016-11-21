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
    [RoutePrefix("api/aspnetuserrole")]
    public class AspNetUserRoleController : ApiController
    {
        protected IAspNetUserRoleService AspNetUserRoleService;

        public AspNetUserRoleController(IAspNetUserRoleService service)
        {
            this.AspNetUserRoleService = service;
        }

        [HttpGet]
        [Route("getall")]
        public async Task<HttpResponseMessage> GetAll()
        {
            try
            {
                var response = Mapper.Map<IEnumerable<AspNetUserRoleView>>(await AspNetUserRoleService.ReadAll());

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
                var response = AutoMapper.Mapper.Map<CompensationView>(await AspNetUserRoleService.Read(id));

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
        public async Task<HttpResponseMessage> Add(AspNetUserRoleView aspNetUserRoleView)
        {
            try
            {
                if (aspNetUserRoleView.Name == null)
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid request.");

                aspNetUserRoleView.Id = Guid.NewGuid().ToString();

                var response = await AspNetUserRoleService.Add(Mapper.Map<IAspNetUserRoleDomain>(aspNetUserRoleView));

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
                var toBeDeleted = await AspNetUserRoleService.Read(id);

                if (toBeDeleted == null)
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Couldn't find entry.");

                var response = await AspNetUserRoleService.Delete(id);

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
        public async Task<HttpResponseMessage> Update(AspNetUserRoleView aspNetUserRoleView)
        {
            try
            {
                var toBeUpdated = await AspNetUserRoleService.Read(aspNetUserRoleView.Id);

                if (toBeUpdated == null)
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Entry not found");

                if (aspNetUserRoleView.Name != null)
                {
                    toBeUpdated.Name = aspNetUserRoleView.Name;
                }

                var response = await AspNetUserRoleService.Update(Mapper.Map<AspNetUserRoleDomain>(toBeUpdated));

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }


    }
}
