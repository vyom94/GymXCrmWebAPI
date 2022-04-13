using CRM.Core.Extension;
using CRM.Models.Dto;
using CRM.Models.Enums;
using EnumsNET;
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
    public class EnumController : ControllerBase
    {
        [HttpGet]
        [Route("GetPizzaSize")]
        public ActionResult GetPizzaSize()
        {
            var dtos = new List<EnumDto>();
            var enums = Enum.GetValues(typeof(sizeEnum)).Cast<sizeEnum>();

            if (!enums.Any())
            {

                return StatusCode((int)HttpStatusCode.NoContent, dtos);

            }

            foreach (var enumValue in enums)
            {
                dtos.Add(new EnumDto
                {
                    Value = (int)enumValue,
                    Name = enumValue.ToString(),
                    Description = enumValue.GetFriendlyName()
                });
            }
            return StatusCode((int)HttpStatusCode.OK, dtos);
        }

        [HttpGet]
        [Route("GetPizzaCrust")]
        public ActionResult GetPizzaCrust()
        {
            var dtos = new List<EnumDto>();
            var enums = Enum.GetValues(typeof(crustEnum)).Cast<crustEnum>();

            if (!enums.Any())
            {

                return StatusCode((int)HttpStatusCode.NoContent, dtos);

            }

            foreach (var enumValue in enums)
            {
                dtos.Add(new EnumDto
                {
                    Value = (int)enumValue,
                    Name = enumValue.ToString(),
                    Description = enumValue.GetFriendlyName()
                });
            }
            return StatusCode((int)HttpStatusCode.OK, dtos);
        }

        [HttpGet]
        [Route("GetPizzaToppings")]
        public ActionResult GetPizzaToppings()
        {
            var dtos = new List<EnumDto>();
            var enums = Enum.GetValues(typeof(toppingEnums)).Cast<toppingEnums>();

            if (!enums.Any())
            {

                return StatusCode((int)HttpStatusCode.NoContent, dtos);

            }

            foreach (var enumValue in enums)
            {
                dtos.Add(new EnumDto
                {
                    Value = (int)enumValue,
                    Name = enumValue.ToString(),
                    Description = enumValue.GetFriendlyName()
                });
            }
            return StatusCode((int)HttpStatusCode.OK, dtos);
        }
    }
}
