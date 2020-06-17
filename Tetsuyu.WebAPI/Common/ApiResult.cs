using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace Tetsuyu.WebAPI.Common
{
    public class ApiResult
    {
        public List<Result> Errors;
        public dynamic Data { get; private set; }

        [JsonIgnoreAttribute]
        public HttpStatusCode HttpStatusCode { get; private set; }

        [JsonIgnoreAttribute]
        public HttpRequestMessage Request { get; private set; }

        [JsonIgnoreAttribute]
        public HttpResponseMessage ResponseMessage
        {
            get
            {
                // HttpResponseMessage msg = new HttpResponseMessage { StatusCode = HttpStatusCode, Content =  { Data, Errors } };
                //return CreatedResult(HttpStatusCode, new { Data, Errors });
                // return Request.CreateResponse(HttpStatusCode, new { Data, Errors });
                return null;
            }
        }

        public ApiResult(HttpRequestMessage request, System.Net.HttpStatusCode httpStatusCode, dynamic result)
        {
            //Errors always present and possibly 0 count
            Errors = new List<Result>();
            HttpStatusCode = httpStatusCode;
            Data = result;
            Request = request;
        }

        public ApiResult(HttpRequestMessage request, System.Net.HttpStatusCode httpStatusCode, dynamic result, List<Result> errors)
        {
            //Errors always present and possibly 0 count
            Errors = new List<Result>();

            if (errors != null)
            {
                Errors = errors;
            }

            HttpStatusCode = httpStatusCode;
            Data = result;
            Request = request;
        }

        public ApiResult(HttpRequestMessage request, System.Net.HttpStatusCode httpStatusCode, dynamic result, Result error)
        {
            //Errors always present and possibly 0 count
            Errors = new List<Result>();

            if (error != null)
            {
                Errors.Add(error);
            }

            HttpStatusCode = httpStatusCode;
            Data = result;
            Request = request;
        }

        public ApiResult(HttpRequestMessage request, Exception exception)
        {
            Request = request;
            Errors = new List<Result>();
            Errors.Add(new Error(exception.Message, exception.InnerException == null ? "" : exception.InnerException.Message));
            HttpStatusCode = System.Net.HttpStatusCode.BadRequest;
            //add sentry?
        }

        //public ApiResult(HttpRequestMessage request, IList<FluentValidation.Results.ValidationFailure> errors)
        //{
        //    Request = request;
        //    Errors = new List<Result>();
        //    HttpStatusCode = System.Net.HttpStatusCode.BadRequest;

        //    foreach (FluentValidation.Results.ValidationFailure ErrorResult in errors)
        //    {
        //        Errors.Add(new Error(ErrorResult.ErrorCode, ErrorResult.ErrorMessage));
        //    }
        //}

        public ApiResult(HttpRequestMessage request, List<Result> errors)
        {
            Request = request;
            Errors = errors;
            HttpStatusCode = System.Net.HttpStatusCode.BadRequest;
        }
    }
}

