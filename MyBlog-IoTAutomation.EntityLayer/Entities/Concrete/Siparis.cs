using MyBlog_IoTAutomation.EntityLayer.Entities.Abstract;

namespace MyBlog_IoTAutomation.EntityLayer.Entities.Concrete
{
    public class Siparis : BaseEntity<int>
    {
        public int KonutId { get; set; }
        public virtual Konut Konut { get; set; }
        public int MusteriId { get; set; }
        public virtual Musteri Musteri { get; set; }
        public virtual ICollection<SiparisDetay> SiparisDetaylar { get; set; }

    }
}
