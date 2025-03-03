using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace Filter_Authorization.Models.Filters
{
    public class AddHeaderFilter :Attribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add("MyHeaderOnFilter","This Is a Test add Header");
        }
    }
}
