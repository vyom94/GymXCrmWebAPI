using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace CRM.Models.ApiResponseModel
{
    public class Result<T>
    {
        public T Item { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }

        public static Result<T> Execute(int statusCode = 200, string message = "OK") => new Result<T> { Item = default, Message = message, StatusCode = statusCode };
        public static Result<T> Execute(T data, int statusCode = 200, string message = "OK") => new Result<T> { Item = data, Message = message, StatusCode = statusCode };


        private static Type typeOf(T entity)
        {
            throw new NotImplementedException();
        }
    }

    public class Result
    {
        public object Item { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        //public static Result Execute(int statusCode = 200, string message = "OK") => new Result { Item = null, Message = message, StatusCode = statusCode };
        public static Result Execute(int statusCode, object Item = null) => new Result { Item = Item, StatusCode = statusCode };
    }
}
