using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AspInAction.Middlewares.Filters
{
    public class ExceptionHandler : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var error = new
            {
                Success = false,
                Errors = new [] {context.Exception.Message}
            };

            context.Result = new ObjectResult(error)
            {
                StatusCode = 200
            };
            context.ExceptionHandled = true;
        }
    }
}