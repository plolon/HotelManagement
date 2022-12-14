using FluentValidation.Results;

namespace HotelManagement.Application.Extensions
{
    public static class ValidatorExtensions
    {
        public static string GenerateErrorMessages(this ValidationResult validator)
        {
            var message = "";
            validator.Errors
                .Select(x => x.ErrorMessage)
                .ToList()
                .ForEach(x => message += x);
            return message;
        }
    }
}