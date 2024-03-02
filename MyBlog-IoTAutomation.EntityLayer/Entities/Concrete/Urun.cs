using MyBlog_IoTAutomation.EntityLayer.Entities.Abstract;

namespace MyBlog_IoTAutomation.EntityLayer.Entities.Concrete
{
    public class Urun : BaseEntity<int>
    {
        public string UrunAdi { get; set; }
        public string Fiyat { get; set; }
        public string StokAdet { get; set; }
        public int KategoriId { get; set; }
        public virtual Kategori Kategori { get; set; }

        public virtual ICollection<SiparisDetay> SiparisDetaylar { get; set; }

    }
}
