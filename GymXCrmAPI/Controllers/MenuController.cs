using CRM.Framework.Repositories;
using CRM.Framework.Services;
using CRM.Models.ApiResponseModel;
using CRM.Models.PizzaMenu;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace GymXCrmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IGenericRepository<PizzaMasterMenu> _pizzaMasterService;
        private readonly IResult _result;
        public MenuController(IGenericRepository<PizzaMasterMenu> pizzaMasterService, IResult result)
        {
            _pizzaMasterService = pizzaMasterService;
            _result = result;
        }

        [HttpGet]

        public IResult GetAll()
        {
            var pizzaMaster = _pizzaMasterService.Query(x => x.Active && !x.Deleted).Include(y => y.PizzaCrust).Include(z => z.PizzaSize).Include(k => k.PizzaToppings).Select().ToList();
            if (pizzaMaster != null)
            {
                _result.ResultData = pizzaMaster;
                _result.ResultStatus = HttpStatusCode.OK;
                _result.Messsage = "Success";
            }
            else
            {
                _result.ResultStatus = HttpStatusCode.NoContent;
                _result.Messsage = "failed";
            }
            return _result;
        }
    }
}
