using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog_IoTAutomation.EntityLayer.Entities.Concrete;
using MyBlog_IoTAutomation.EntityLayer.Entity_Config.Abstract;

namespace MyBlog_IoTAutomation.EntityLayer.Entity_Config.Concrete
{
    public class SiparisDetayConfig : BaseConfig<SiparisDetay, int>
    {
        public override void Configure(EntityTypeBuilder<SiparisDetay> builder)
        {
            base.Configure(builder);
            builder.HasKey(p => new { p.SiparisId, p.UrunId }); // İki adet key işaretlemek, sebebi ise; Bir siparişin
                                                                // birden fazla detayi olabilsin diye yani bunu da farklı
                                                                // urun kaydı ile sagliyor bu sekilde uniqten kurtuluyor.

            builder.Property(p => p.Id).ValueGeneratedOnAdd(); // Primary Key olmayan bir propu identity olarak seçmek.
                                                               // Bunun sebebi; eğer id property si de pk olarak işaret-
                                                               // lense idi aynı siparişten ve aynı üründen birden fazla
                                                               // kayıt olabilecekti. Bu da veri tutarsızlığına yol açar.
                                                               // Bundan dolayı id probunu pk olmadan identity işaretledim.
                                                               // Bu tablo siparişler tablosundan ayrıştırılmış bir tablodur
                                                               // bu nedenle bir id fieldine gerek yok evet, fakat ben burada
                                                               // id fieldi kullanmamın sebebi her bir sipariş detayını bağımsız
                                                               // görüp yorumlayabilmek ve daha iyi anlayabilmek içindir.

            builder.Property(p => p.ToplamTutar).HasMaxLength(50);


        }
    }
}
