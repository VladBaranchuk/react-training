using System.Net.Mime;
using System.Net;
using System.Text.Json;

namespace back_end
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception error)
            {
                int statusCode;
                var response = new ExceptionResponse(error.Message);

                switch (error)
                {
                    //case FluentValidation.ValidationException e:
                    //    statusCode = (int)HttpStatusCode.BadRequest;
                    //    response.ValidationErrors = e.Errors.Select(x => new ValidationError
                    //    {
                    //        ErrorMessage = x.ErrorMessage,
                    //        PropertyName = x.PropertyName,
                    //    });
                    //    break;
                    case ApplicationException e:
                        statusCode = (int)HttpStatusCode.NotFound;
                        break;
                    default:
                        statusCode = (int)HttpStatusCode.InternalServerError;
                        break;
                }

                context.Response.StatusCode = statusCode;
                context.Response.ContentType = MediaTypeNames.Application.Json;
                var result = JsonSerializer.Serialize(response);
                await context.Response.WriteAsync(result);
            }
        }
    }
}
