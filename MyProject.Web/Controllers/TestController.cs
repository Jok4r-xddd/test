using Microsoft.AspNetCore.Mvc;
using MyProject.Web.Models;

namespace MyProject.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Igor Hnízdo",
                Cipher = 123
            };
            return View(data);
        }
    }
}
