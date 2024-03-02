using Microsoft.AspNetCore.Mvc;
using MyBlog_IoTAutomation.DataAccessLayer.Repositories.Abstract;
using MyBlog_IoTAutomation.EntityLayer.Entities.Concrete;

namespace MyBlog_IoTAutomation.WebUILayer.Controllers
{
    public class UrunController : Controller
    {

        private readonly IRepository<Urun, int> _urunrepo; //Urun ile ilgili tüm veritabanı CRUD ve Query islemlerini yapıp veri register edebilirsin.
        public UrunController(IRepository<Urun, int> urunrepo)
        {
            _urunrepo = urunrepo;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
