

namespace Web.Api.IntegrationTests.Models.Request
{
    public class ExchangeRefreshTokenRequest
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}

