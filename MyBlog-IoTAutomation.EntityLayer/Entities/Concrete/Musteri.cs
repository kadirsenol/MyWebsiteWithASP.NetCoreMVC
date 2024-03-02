using MyBlog_IoTAutomation.EntityLayer.Entities.Abstract;

namespace MyBlog_IoTAutomation.EntityLayer.Entities.Concrete
{
    public class Musteri : BaseEntity<int>
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string TcNo { get; set; }
        public string Adres { get; set; }
        public virtual ICollection<Siparis> Siparisler { get; set; }

    }
}
