using Microsoft.AspNetCore.Mvc;

namespace testApi.Controllers.error
{

    [ApiController]
    public class ErrorController : ControllerBase
    {

        [Route("/error")]
        public IActionResult Error() => Problem();
    }
}