namespace MVCITI.Middelwares
{
    using Microsoft.AspNetCore.Http;
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Builder;
    public static class RequestLoggerExtensions
    {
        public static IApplicationBuilder UseCustomMiddle(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomMiddle>();
        }
    }
    public class CustomMiddle
    {
        private readonly RequestDelegate _next;

        public CustomMiddle(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {

            Console.WriteLine($"hello in my middleware");

            await _next(context);

            Console.WriteLine("you are welcome in any time");
        }
    }
}