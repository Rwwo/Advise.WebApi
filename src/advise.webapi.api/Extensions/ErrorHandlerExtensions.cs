﻿namespace advise.webapi.api.Extensions
{
    public static class ErrorHandlerExtensions
    {
        public static void ConfigureCustomExceptionHandler(this IApplicationBuilder app)
        {
            app.UseMiddleware<CustomExceptionMiddleware>();
        }
    }
}
