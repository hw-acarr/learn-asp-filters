using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace TodoApi.Filters
{
    public class CustomResultFilterAttribute : ResultFilterAttribute
    {
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            Console.WriteLine("Leaving CustomResultFilterAttribute#OnResultExecuted");
            Console.WriteLine(context.HttpContext.Response.StatusCode.ToString());
            base.OnResultExecuted(context);
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            Console.WriteLine("Entering CustomResultFilterAttribute#OnResultExecuting");
            Console.WriteLine(context.HttpContext.Response.StatusCode.ToString());
            base.OnResultExecuting(context);
        }
    }
}