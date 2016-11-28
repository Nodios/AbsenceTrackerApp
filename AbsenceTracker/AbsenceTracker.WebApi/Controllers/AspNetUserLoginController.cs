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
using AbsenceTracker.Common;
using AbsenceTracker.LoginAuthentication;
using AbsenceTracker.Model.Common.IDomainModels;

namespace AbsenceTracker.WebApi.Controllers
{
    [RoutePrefix("api/aspnetuserlogin")]
    public class AspNetUserLoginController : ApiController
    {
        protected IAspNetUserLoginService AspNetUserLoginService;
        //For checking if user from AD is in AbsenceTracker database
        protected IAspNetUserService AspNetUserService;

        public AspNetUserLoginController(IAspNetUserLoginService aspNetUserLogin, IAspNetUserService aspNetUserService)
        {
            this.AspNetUserLoginService = aspNetUserLogin;
            this.AspNetUserService = aspNetUserService;
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


        [HttpPost]
        [Route("login")]
        public async Task<HttpResponseMessage> Login(UserCredentials credentials)
        {
            try
            {
                if (credentials == null || credentials.UserName == null || credentials.Password == null)
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid input");

                var user = ValidateUser.Validate(credentials);
                //If isValid == null then user doesn't exist, else it returns user object of type UserPrincipal
                if (user == null)
                    return Request.CreateErrorResponse(HttpStatusCode.NoContent, "Invalid credentials");
                //If user is not in AbsenceTracked database add him
                var response = await AspNetUserService.FindByUserName(credentials.UserName);

                if (response == null)
                {
                    //mapp
                    var userView = new AspNetUserView()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Email = user.EmailAddress,
                        UserName = user.SamAccountName,
                        EmailConfirmed = false,
                        PhoneNumberConfirmed = false,
                        TwoFactorEnabled = false,
                        LockoutEnabled = false,
                        AccessFailedCount = 0
                    };

                    var result = await AspNetUserService.Add(Mapper.Map<IAspNetUserDomain>(userView));

                    if (result == 0)
                        return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Couldn't add user to database.");
                }

                //Create response
                //Token duration is 10 minute
                var tokenDuration = DateTime.UtcNow.AddMinutes(10);
                var token = new TokenFactory(tokenDuration).GenerateToken();
                var loginResponse = new LoginResponse() { UserName = credentials.UserName, Token = token };

                //Add token id db for user
                var aspNetUserLoginView = new AspNetUserLoginView() { ProviderKey = token.TokenValue, UserId = response.Id, LoginProvider = " " };
                //var tokenResponse = Update(aspNetUserLoginView);  //Implement update

                return Request.CreateResponse(HttpStatusCode.OK, loginResponse);
            }
            catch(Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
           
        }


    }
}
