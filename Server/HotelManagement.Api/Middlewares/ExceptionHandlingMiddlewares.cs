using System.ComponentModel.DataAnnotations;
using HotelManagement.Domain.Exceptions;
using ApplicationException = HotelManagement.Domain.Exceptions.ApplicationException;
using ValidationException = HotelManagement.Application.Exceptions.ValidationException;

namespace HotelManagement.Api.Middlewares
{
    public class ExceptionHandlingMiddlewares : IMiddleware
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

        private static async Task HandleException(HttpContext context, Exception e)
        {
            var statusCode = GetStatusCode(e);
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