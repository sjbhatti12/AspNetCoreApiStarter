using FluentValidation;
using Web.Api.IntegrationTests.Models.Request;

namespace Web.Api.IntegrationTests.Models.Validation
{
    public class ExchangeRefreshTokenRequestValidator : AbstractValidator<ExchangeRefreshTokenRequest>
    {
        public ExchangeRefreshTokenRequestValidator()
        {
            RuleFor(x => x.AccessToken).NotEmpty();
            RuleFor(x => x.RefreshToken).NotEmpty();
        }
    }
}
