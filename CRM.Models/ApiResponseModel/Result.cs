using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

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
            set {
                _ResultData = Regex.Unescape(JsonConvert.SerializeObject(JsonConvert.SerializeObject(value, Formatting.None,
                          new JsonSerializerSettings
                          {
                              ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                              PreserveReferencesHandling = PreserveReferencesHandling.All
                          }))).Replace(@",\","");
            }
        }
    }
}
