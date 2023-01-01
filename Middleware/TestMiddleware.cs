using AuthMiddlewareExample.DTO;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json;

namespace AuthMiddlewareExample.Middleware
{
    public class TestMiddleware
    {
        private readonly RequestDelegate _next;

        public TestMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {

            string requestBody = await new StreamReader(context.Request.Body).ReadToEndAsync();
            var data = JsonConvert.DeserializeObject<ToDoDto>(requestBody);

            foreach (var header in context.Request.Headers)
            {
                Console.WriteLine($"{header.Key}: {header.Value}");
            }

            await _next(context);
        }
    }


}
