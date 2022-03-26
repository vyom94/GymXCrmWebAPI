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
    public class RegisterController : ControllerBase
    {
        private IService<Users> userService;
        public RegisterController()
        {
            
        }
        [HttpGet]

        public IResult isRgistered()
        {
            return null;
        }
    }
}
