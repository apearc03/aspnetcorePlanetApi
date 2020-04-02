using System.IO;
using Microsoft.AspNetCore.Mvc;
using testApi.Controllers.info;
using Xunit;

namespace testApi.test.info
{
    public class InfoControllerTest
    {
        private readonly InfoController controller = new InfoController();
        private readonly string path = Path.GetFullPath(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "../../../html/info.html"));

        [Fact]
        public void get()
        {
            string s = System.AppDomain.CurrentDomain.BaseDirectory;
            ContentResult result = controller.get();
            Assert.Equal(File.ReadAllText(path), result.Content);
        }
    }
}