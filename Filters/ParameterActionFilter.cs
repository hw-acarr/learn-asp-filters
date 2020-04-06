using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;
using System;

namespace TodoApi.Filters
{
    public class ParameterActionFilterAttribute : ActionFilterAttribute
    {
        private readonly string parameterName;

        // public ParameterActionFilterAttribute(string name)
        // {
        //     parameterName = name;
        // }

        private readonly Type passedType;

        public ParameterActionFilterAttribute(Type type)
        {
            passedType = type;
            parameterName = passedType.FullName;
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"{parameterName}: Leaving ParameterActionFilterAttribute#OnActionExecuted");
            Console.WriteLine(context.HttpContext.Response.StatusCode.ToString());
            base.OnActionExecuted(context);
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"{parameterName}: Entering ParameterActionFilterAttribute#OnActionExecuted");
            Console.WriteLine(context.HttpContext.Response.StatusCode.ToString());
            base.OnActionExecuting(context);
        }
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            Console.WriteLine($"{parameterName}: Entering ParameterActionFilterAttribute#OnResultExecuting");
            Console.WriteLine(context.HttpContext.Response.StatusCode.ToString());
            base.OnResultExecuting(context);
        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            Console.WriteLine($"{parameterName}: Leaving ParameterActionFilterAttribute#OnResultExecuted");
            Console.WriteLine(context.HttpContext.Response.StatusCode.ToString());
            base.OnResultExecuted(context);
        }

    }
}