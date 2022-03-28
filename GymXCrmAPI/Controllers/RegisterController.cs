using CRM.Framework.Repositories;
using CRM.Framework.Services;
using CRM.Models.ApiResponseModel;
using CRM.Models.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymXCrmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : BaseApiController
    {
        private readonly IGenericRepository<Users> _userService;
        public RegisterController(IGenericRepository<Users> userService)
        {
            _userService =userService;
        }
        [HttpGet]
       
        public IResult isRgistered()
        {
            _result.ResultData = false;
            return _result;
        }
    }
}
