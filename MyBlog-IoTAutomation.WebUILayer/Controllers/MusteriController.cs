using Microsoft.AspNetCore.Mvc;
using MyBlog_IoTAutomation.BussinesLayer.Abstract;

namespace MyBlog_IoTAutomation.WebUILayer.Controllers
{
    public class MusteriController : Controller
    {

        private readonly IMusteriManager _musmanager; //BussinesLayer hazir olduktan sonra kullanicidan tutarli veri alip veritabanına register etmek icin.
        public MusteriController(IMusteriManager musmanager)
        {
            _musmanager = musmanager;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
