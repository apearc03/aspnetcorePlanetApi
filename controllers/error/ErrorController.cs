using Microsoft.AspNetCore.Mvc;

namespace testApi.Controllers
{

    [ApiController]
    public class ErrorController : ControllerBase
    {

        [Route("/error")]
        public IActionResult Error() => Problem();
    }
}