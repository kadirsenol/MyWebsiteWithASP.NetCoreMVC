using MyBlog_IoTAutomation.EntityLayer.Entities.Abstract;

namespace MyBlog_IoTAutomation.EntityLayer.Entities.Concrete
{
    public class Kategori : BaseEntity<int>
    {
        public string KategoriAdi { get; set; }
        public virtual ICollection<Urun> Urunler { get; set; }

    }
}
