using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tetsuyu.WebAPI.Common
{
    public abstract class Result
    {
        public string Title;
        public string Message;

        //Possibily used to refer to an enum value for the scenario of failure
        public dynamic Scenario;
        public dynamic Data;

        public Result()
        {

        }

        public Result(string title, string message, dynamic scenario = null, dynamic data = null)
        {
            Title = title;
            Message = message;
            Scenario = scenario;
            Data = data;
        }

        public Result(string title, string message, dynamic data)
        {
            Title = title;
            Message = message;
            Data = data;
            Scenario = null;
        }

        public Result(dynamic scenario)
        {
            Title = null;
            Message = null;
            Data = null;
            Scenario = scenario;
        }
    }

    public class Error : Result
    {
        public Error(string title, string message) : base(title, message) { }
        public Error(string message) : base("Error", message) { }
        public Error(dynamic scenario) : base((object)scenario) { }
    }

    public class Success : Result
    {
        public Success() : base() { }
        public Success(string title, string message) : base(title, message) { }
        public Success(string message) : base("Success", message) { }
        public Success(string title, string message, dynamic data) : base(title, message, (object)data) { }
    }

    public class Warning : Result
    {
        public Warning(string title, string message) : base(title, message) { }
        public Warning(string message) : base("Warning", message) { }
    }

    public class ReduxFormError
    {
        public string Field { get; set; }
        public string Error { get; set; }
    }
}
