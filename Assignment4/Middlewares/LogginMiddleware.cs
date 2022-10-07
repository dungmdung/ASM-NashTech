using System.Diagnostics;

#pragma warning restore format

namespace Assignment4.Middlewares
{
    public class LogginMiddleware
    {
        private readonly RequestDelegate _next;

        public LogginMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var request = context.Request;
            var response = context.Response;

            string requestInfo = "Scheme: " + request.Scheme +
            "\tHost " + request.Host +
            "\tPath " + request.Path +
            "\tQueryString " + request.QueryString +
            "\tRequest Body " + request.Body;

            Debug.Write(requestInfo);
            File.WriteAllText("textinformation.txt", requestInfo);

            await _next(context);
        }
    }
}