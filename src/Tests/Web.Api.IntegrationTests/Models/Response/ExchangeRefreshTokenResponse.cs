using Web.Api.Core.Dto;

namespace Web.Api.IntegrationTests.Models.Response
{
    public class ExchangeRefreshTokenResponse
    {
        public AccessToken AccessToken { get; }
        public string RefreshToken { get; }

        public ExchangeRefreshTokenResponse(AccessToken accessToken, string refreshToken)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
        }
    }
}
