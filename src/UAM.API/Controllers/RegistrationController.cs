using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UAM.API.Models.Registration;

namespace UAM.API.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/register")]
    public class RegistrationController : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> RegisterByEmailAndPassword(EmailPasswordRegustrationModel model)
        {

            return await Task.FromResult(Ok(JsonConvert.SerializeObject(model)));
        }
    }
}
