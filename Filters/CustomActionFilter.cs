using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace TodoApi.Filters
{
    public class CustomActionFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("Leaving CustomActionFilterAttribute#OnActionExecuted");
            Console.WriteLine(context.HttpContext.Response.StatusCode.ToString());
            base.OnActionExecuted(context);
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("Entering CustomActionFilterAttribute#OnActionExecuted");
            Console.WriteLine(context.HttpContext.Response.StatusCode.ToString());
            base.OnActionExecuting(context);
        }
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            Console.WriteLine("Entering CustomActionFilterAttribute#OnResultExecuting");
            Console.WriteLine(context.HttpContext.Response.StatusCode.ToString());
            base.OnResultExecuting(context);
        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            Console.WriteLine("Leaving CustomActionFilterAttribute#OnResultExecuted");
            Console.WriteLine(context.HttpContext.Response.StatusCode.ToString());
            base.OnResultExecuted(context);
        }

    }
}