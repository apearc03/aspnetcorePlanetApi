using Microsoft.AspNetCore.Mvc;

namespace testApi.Controllers.error
{

    [ApiController]
    public class ErrorController : ControllerBase
    {

        [ApiExplorerSettings(IgnoreApi = true)]
        [Route("/error")]
        public IActionResult Error() => Problem();
    }
}