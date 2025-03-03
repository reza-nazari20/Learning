using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Security.Claims;

namespace Filter_Authorization.Models.Filters
{
    public class AuthorizeActionFilter :Attribute, IAuthorizationFilter
    {
        private readonly string _role;
        public AuthorizeActionFilter(string role)
        {
            _role = role;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var isAuthorizes = CheckUserPermission(context.HttpContext.User, _role);
            if (!isAuthorizes)
            {
                context.Result = new UnauthorizedResult();
            }
        }

        private bool CheckUserPermission(ClaimsPrincipal user, string role)
        {
            if (role == "Admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
