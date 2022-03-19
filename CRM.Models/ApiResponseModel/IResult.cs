using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace CRM.Models.ApiResponseModel
{
    public interface IResult
    {
        HttpStatusCode ResultStatus { get; set; }
        string Messsage { get; set; }
        object ResultData { get; set; }
    }
}
