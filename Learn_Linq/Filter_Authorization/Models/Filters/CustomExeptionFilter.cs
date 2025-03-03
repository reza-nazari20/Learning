using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;

namespace Filter_Authorization.Models.Filters
{
    public class CustomExeptionFilter :Attribute, IExceptionFilter
    {
        private readonly IModelMetadataProvider _metadataProvider;

        public CustomExeptionFilter(IModelMetadataProvider metadataProvider)
        {
            _metadataProvider = metadataProvider;
        }

        public void OnException(ExceptionContext context)
        {
            var result = new ViewResult { ViewName = "CustomException" };
            result.ViewData = new ViewDataDictionary(_metadataProvider, context.ModelState);
            result.ViewData.Add("Exception",context.Exception);
            context.ExceptionHandled = true;
            context.Result = result;
        }
    }
}
