using MyBlog_IoTAutomation.BussinesLayer.Abstract;
using MyBlog_IoTAutomation.DataAccessLayer.Repositories.Abstract;
using MyBlog_IoTAutomation.EntityLayer.Entities.Concrete;

namespace MyBlog_IoTAutomation.BussinesLayer.Concrete
{
    public class MusteriManager : IMusteriManager
    {
        private readonly IRepository<Musteri, int> _musrepo;
        public MusteriManager(IRepository<Musteri, int> musrepo)
        {
            _musrepo = musrepo;
        }

        //CRUD VE QUERY KURALLARINI IMusteriManager INTERFACEDEN IMPLAMENT ET
    }
}
