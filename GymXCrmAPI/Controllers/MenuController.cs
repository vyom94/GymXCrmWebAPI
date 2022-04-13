using CRM.Framework.Repositories;
using CRM.Framework.Services;
using CRM.Models.ApiResponseModel;
using CRM.Models.Dto;
using CRM.Models.PizzaMenu;
using CRM.Models.RelationModel;
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
        private readonly IGenericRepository<PizzaPrice> _pizzaPriceService;


        public MenuController(IGenericRepository<PizzaMasterMenu> pizzaMasterService, IGenericRepository<PizzaPrice> pizzaPriceService)
        {
            _pizzaMasterService = pizzaMasterService;
            _pizzaPriceService = pizzaPriceService;


        }

        [HttpGet]
        [Route("")]
        public ActionResult GetAll()
        {
            var pizzaMaster = _pizzaMasterService.
                               Queryable().Join(_pizzaPriceService.Queryable(), //inner sequence
                                pizzaMaster => pizzaMaster.Id//key selector
                                , pizzaPrice => pizzaPrice.PizzaId //key selector
                                , (pizzaMaster, pizzaPrice) => //projection result
                               new PizzaDto()
                               {Id= pizzaMaster.Id,
                                   Description =pizzaMaster.Description,
                                  ImageUrl= pizzaMaster.ImageUrl,
                                  Name= pizzaMaster.Name,
                                  Price= pizzaPrice.Price
                               }
                              );

            if (!pizzaMaster.Any())
            {

                return StatusCode((int)HttpStatusCode.NoContent, pizzaMaster);

            }
            return StatusCode((int)HttpStatusCode.OK, pizzaMaster);
        }
    }
}
