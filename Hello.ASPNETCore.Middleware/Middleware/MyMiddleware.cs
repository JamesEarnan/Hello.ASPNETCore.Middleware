using Hello.ASPNETCore.Middleware.Service;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello.ASPNETCore.Middleware.Middleware
{
    public class MyMiddleware
    {
        private readonly RequestDelegate _next;

        public MyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, IMyScopedService svc)
        {
            svc.MyProperty = 1000;
            await _next(httpContext);
        }
    }
}
