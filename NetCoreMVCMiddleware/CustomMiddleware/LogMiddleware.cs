using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMVCMiddleware.CustomMiddleware
{
    public class LogMiddleware
    {
        private RequestDelegate _next;
        public LogMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            //logic action 
            int a = 5;
            await _next(context);
        }
    }
}
