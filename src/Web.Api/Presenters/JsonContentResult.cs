using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Presenters
{
  public sealed class JsonContentResult : Microsoft.AspNetCore.Mvc.ContentResult
    {
    public JsonContentResult()
    {
      ContentType = "application/json";
    }
  }
}
