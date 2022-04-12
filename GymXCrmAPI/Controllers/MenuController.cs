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

        public MenuController(IGenericRepository<PizzaMasterMenu> pizzaMasterService)
        {
            _pizzaMasterService = pizzaMasterService;
        
        }

        [HttpGet]

        public ActionResult GetAll()
        {
            var pizzaMaster = _pizzaMasterService.
                                Query(pizza => pizza.Active)                         
                                .Select() 
                                .ToList();
        
            if (!pizzaMaster.Any())
            {
             
                return StatusCode((int)HttpStatusCode.NoContent, pizzaMaster);

            }
            return StatusCode((int)HttpStatusCode.OK, pizzaMaster);
        }
    }
}
