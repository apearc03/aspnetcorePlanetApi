using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace testApi.Controllers.info
{
    [ApiController]
    [Route("[controller]")]
    public class InfoController : ControllerBase
    {
        private readonly string path = Path.GetFullPath(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "../../../html/info.html"));

        [HttpGet]
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