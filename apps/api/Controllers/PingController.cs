using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PingController : ControllerBase
    {
        [HttpGet]
        public ActionResult<DateTime> Get()
        {
            return Ok(DateTime.Now);
        }
    }
}
