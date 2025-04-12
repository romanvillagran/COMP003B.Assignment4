namespace COMP003B.Assignment4.Middleware
{
    public class SimpleLogger
    {
        private readonly RequestDelegate _next;

        public SimpleLogger(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine($"Request: {context.Request.Path}");
            await _next(context);
        }
    }
}
