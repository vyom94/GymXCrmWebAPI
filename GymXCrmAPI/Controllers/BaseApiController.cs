using CRM.Models.ApiResponseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace GymXCrmAPI.Controllers
{
    public class BaseApiController : ControllerBase
    {

        public IResult _result { get; set; }

    }
}
