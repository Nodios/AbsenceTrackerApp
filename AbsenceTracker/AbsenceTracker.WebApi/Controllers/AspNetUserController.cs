using AbsenceTracker.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using AbsenceTracker.WebApi.ViewModels;
using System.Threading.Tasks;
using AbsenceTracker.Model.DomainModels;

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
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        [HttpGet]
        [Route("get")]
        public async Task<HttpResponseMessage> Get(string id)
        {
            try
            {
                var response = Mapper.Map<AspNetUserView>(await AspNetUserService.Read(id));

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
        public async Task<HttpResponseMessage> Add(AspNetUserView aspNetUserView)
        {
            try
            {
                if (aspNetUserView.Email == null || aspNetUserView.EmailConfirmed == false || aspNetUserView.UserName == null 
                    || aspNetUserView.PasswordHash == null)
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid input.");

                aspNetUserView.Id = Guid.NewGuid().ToString();

                var response = await AspNetUserService.Add(Mapper.Map<AspNetUserDomain>(aspNetUserView));

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
                var aspNetUser = Mapper.Map<AspNetUserView>(await AspNetUserService.Read(id));

                if (aspNetUser.Absence.Count != 0)
                    return Request.CreateErrorResponse(HttpStatusCode.NotAcceptable,
                        "Cannot delete user. It has bound Absence.");
                else if(aspNetUser.Absence1.Count != 0)
                    return Request.CreateErrorResponse(HttpStatusCode.NotAcceptable,
                         "Cannot delete user. It has bound Absence.");
                else if(aspNetUser.AspNetRoles.Count != 0)
                    return Request.CreateErrorResponse(HttpStatusCode.NotAcceptable,
                         "Cannot delete user. It has bound user roles.");
                else if(aspNetUser.AspNetUserClaims.Count != 0)
                    return Request.CreateErrorResponse(HttpStatusCode.NotAcceptable,
                        "Cannot delete user. It has bound user claims.");
                else if(aspNetUser.AspNetUserLogins.Count != 0)
                    return Request.CreateErrorResponse(HttpStatusCode.NotAcceptable,
                       "Cannot delete user. It has bound user login.");


                if (aspNetUser == null)
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bad id.");

                var response = await AspNetUserService.Delete(id);

                if (response == 0)
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Couldn't delete maker.");

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        [HttpPut]
        [Route("update")]
        public async Task<HttpResponseMessage> Update(AspNetUserView aspNetUserView)
        {
            try
            {
                var toBeUpdated = await AspNetUserService.Read(aspNetUserView.Id);

                if (toBeUpdated == null)
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Entry not found");

                if (aspNetUserView.Email != null)
                    toBeUpdated.Email = aspNetUserView.Email;
                if (aspNetUserView.EmailConfirmed != false)
                    toBeUpdated.EmailConfirmed = aspNetUserView.EmailConfirmed;
                if (aspNetUserView.UserName != null)
                    toBeUpdated.UserName = aspNetUserView.UserName;
                if (aspNetUserView.PasswordHash != null)
                    toBeUpdated.PasswordHash = aspNetUserView.PasswordHash;

                var response = await AspNetUserService.Update(Mapper.Map<AspNetUserDomain>(toBeUpdated));

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }
    }
}
