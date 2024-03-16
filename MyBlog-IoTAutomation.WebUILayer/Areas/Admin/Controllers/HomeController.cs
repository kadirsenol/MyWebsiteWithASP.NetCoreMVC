using Microsoft.AspNetCore.Mvc;

namespace MyBlog_IoTAutomation.WebUILayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
