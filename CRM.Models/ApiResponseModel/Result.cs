using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace CRM.Models.ApiResponseModel
{
    public class Result : IResult
    {
        private object _ResultData;

        public string Messsage { get; set; }

        public HttpStatusCode ResultStatus { get; set; }

        public object ResultData
        {
            get { return _ResultData; }
            set { _ResultData = JsonConvert.DeserializeObject(JsonConvert.SerializeObject(value, Formatting.Indented, new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects })); }
        }
    }
}
