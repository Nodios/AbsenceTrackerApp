using AbsenceTracker.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using System.Threading.Tasks;
using AbsenceTracker.WebApi.ViewModels;
using AbsenceTracker.Model.DomainModels;

namespace AbsenceTracker.WebApi.Controllers
{
    [RoutePrefix("api/aspnetuserlogin")]
    public class AspNetUserLoginController : ApiController
    {
        protected IAspNetUserLoginService AspNetUserLoginService;

        public AspNetUserLoginController(IAspNetUserLoginService aspNetUserLogin)
        {
            this.AspNetUserLoginService = aspNetUserLogin;
        }

        [HttpGet]
        [Route("getall")]
        public async Task<HttpResponseMessage> GetAll()
        {
            try
            {
                var response = Mapper.Map<IEnumerable<AspNetUserLoginView>>(await AspNetUserLoginService.ReadAll());

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
                var response = Mapper.Map<AspNetUserLoginView>(await AspNetUserLoginService.Read(id));

                if (response == null)
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid input.");

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        [HttpPost]
        [Route("add")]
        public async Task<HttpResponseMessage> Add(AspNetUserLoginView aspNetUserLoginView)
        {
            try
            {
                if (aspNetUserLoginView.LoginProvider == null || aspNetUserLoginView.ProviderKey == null
                    || aspNetUserLoginView.UserId == null)
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid input.");

                var response = await AspNetUserLoginService.Add(Mapper.Map<AspNetUserLoginDomain>(aspNetUserLoginView));

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }

        } 
    }
}
