using System.Text.Json;
using HotelManagement.Application.Exceptions;
using HotelManagement.Domain.Exceptions;
using ApplicationException = HotelManagement.Domain.Exceptions.ApplicationException;

namespace HotelManagement.Api.Middlewares
{
    public class ExceptionHandlingMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception e)
            {
                //TODO Add Logger and log stack trace
                await HandleException(context, e);
            }
        }

        private static async Task HandleException(HttpContext httpContext, Exception e)
        {
            var code = GetStatusCode(e);
            var response = new
            {
                title = GetTitle(e),
                statusCode = code,
                details = e.Message,
                errors = GetErrors(e)
            };

            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = code;
            await httpContext.Response.WriteAsync(JsonSerializer.Serialize(response));
        }

        private static int GetStatusCode(Exception exception) =>
            exception switch
            {
                BadRequestException => StatusCodes.Status400BadRequest,
                ValidationException => StatusCodes.Status422UnprocessableEntity,
                NotFoundException => StatusCodes.Status404NotFound,
                _ => StatusCodes.Status500InternalServerError
            };

        private static string GetTitle(Exception exception) =>
            exception switch
            {
                ApplicationException ex => ex.Title,
                _ => "Server Error"
            };

        private static IReadOnlyDictionary<string, string[]> GetErrors(Exception exception)
        {
            IReadOnlyDictionary<string, string[]> errors = null;

            if (exception is ValidationException ex)
            {
                errors = ex.ErrorsDictionary;
            }

            return errors;
        }
    }
}