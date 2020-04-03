using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace testApi.Controllers.info
{
    [ApiController]
    [Route("[controller]")]
    public class InfoController : ControllerBase
    {
        public static readonly string path = Path.GetFullPath(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "../../../html/info.html"));

        [HttpGet]
        [Produces("text/html")]
        public ContentResult get()
        {
            string text = System.IO.File.ReadAllText(path);
            return new ContentResult
            {
                ContentType = "text/html",
                Content = text
            };
        }

    }
}