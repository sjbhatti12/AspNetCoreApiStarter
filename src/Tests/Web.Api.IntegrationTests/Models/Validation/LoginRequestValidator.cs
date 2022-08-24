using FluentValidation;
using Web.Api.IntegrationTests.Models.Request;

namespace Web.Api.IntegrationTests.Models.Validation
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.UserName).NotEmpty();
            RuleFor(x => x.Password).NotEmpty();
        }
    }
}
