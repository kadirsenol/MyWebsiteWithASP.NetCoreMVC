using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog_IoTAutomation.EntityLayer.Entities.Concrete;
using MyBlog_IoTAutomation.EntityLayer.Entity_Config.Abstract;

namespace MyBlog_IoTAutomation.EntityLayer.Entity_Config.Concrete
{
    public class UrunConfig : BaseConfig<Urun, int>
    {
        public override void Configure(EntityTypeBuilder<Urun> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.UrunAdi).HasMaxLength(50);
            builder.Property(p => p.StokAdet).HasMaxLength(10);
            builder.Property(p => p.Fiyat).HasMaxLength(10);

        }
    }
}
