using Auth.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TestController : BaseController
    {
        [HttpGet]
        [Authorize]
        public IActionResult GetInformation() => Ok(CurrentUser.Information);

    }
}
