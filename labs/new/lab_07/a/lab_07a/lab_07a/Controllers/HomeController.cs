using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [Route("/")]
    [ApiController]

    public class HomeController : ControllerBase
    {
        public ContentResult Index()
        {
            return Content(
                System.IO.File.ReadAllText(@"G:\LEARN\6 сем\ПИС(ASP.NET)\labs\new\lab_07\a\lab_04\WebApplication\WebApplication\Views\Home\Index.html"), "text/html");
        }

        
    }
}