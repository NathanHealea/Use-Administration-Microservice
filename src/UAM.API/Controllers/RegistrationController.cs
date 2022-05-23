using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UAM.API.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/register")]
    public class RegistrationController : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> RegisterByEmailAndPassword()
        {

            return await Task.FromResult(Ok("pass"));
        }
    }
}
