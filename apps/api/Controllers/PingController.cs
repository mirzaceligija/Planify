using ErrorOr;
using Microsoft.AspNetCore.Mvc;
using Planify.Infrastructure;

namespace API.Controllers
{
    public class PingController : BaseController
  {
    [HttpGet]
    public ActionResult<DateTime> Get()
    {
        return Ok(DateTime.Now);
    }

    [HttpGet("Test")]
    public IActionResult TestError()
    {
      ErrorOr<string> err = GetError();

      if(err.IsError && err.FirstError == Planify.Domain.Common.Errors.Errors.Task.DuplicateName)
      {
        return Problem(statusCode: StatusCodes.Status400BadRequest, title: err.FirstError.Description);
      }

      return err.Match(
        result => Ok("Everything is fine!"),
        errors => Problem(errors)
      );
    }

    // This chunk of code is temp
    private ErrorOr<string> GetError()
    {
      return Planify.Domain.Common.Errors.Errors.Task.DuplicateName;
    }
  }
}
