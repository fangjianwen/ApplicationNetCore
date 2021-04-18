using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationNetCore.Filter
{
    public class AuthenFilterAttribute : IAuthorizationFilter
    {
        //每个action执行之前都会进入这个方法
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            //如果不通过认证 重定向到/Account/Login
            if (context.HttpContext.User.Identity.IsAuthenticated || HasAllowAnonymous(context) == true) return;
            context.Result = new RedirectToActionResult("Login", "Account", null);
        }

        //用于判断Action有没有AllowAnonymous标签，微软写的
        private bool HasAllowAnonymous(AuthorizationFilterContext context)
        {
            var filters = context.Filters;
            for (var i = 0; i < filters.Count; i++)
            {
                if (filters[i] is IAllowAnonymousFilter)
                {
                    return true;
                }
            }

            var endpoint = context.HttpContext.GetEndpoint();
            if (endpoint?.Metadata?.GetMetadata<IAllowAnonymous>() != null)
            {
                return true;
            }

            return false;
        }



    }
}
