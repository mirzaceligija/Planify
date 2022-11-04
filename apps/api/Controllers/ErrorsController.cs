using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  [ApiController]
  [Route("/api/[controller]")]
  public class ErrorsController : ControllerBase
  {
    [Route("/error")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public IActionResult Error()
    {
      Exception? exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
      return Problem(title: exception?.Message);
    }
  }
}
