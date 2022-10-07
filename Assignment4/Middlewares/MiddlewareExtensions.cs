namespace Assignment4.Middlewares
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UserLogginMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LogginMiddleware>();
        }
    }
}