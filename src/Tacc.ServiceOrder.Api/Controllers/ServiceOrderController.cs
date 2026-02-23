using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tacc.ServiceOrder.Api.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class ServiceOrderController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "Tacc Service order API is running", date = DateTime.Now });
        }
    }
}