using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog_IoTAutomation.EntityLayer.Entities.Concrete;
using MyBlog_IoTAutomation.EntityLayer.Entity_Config.Abstract;

namespace MyBlog_IoTAutomation.EntityLayer.Entity_Config.Concrete
{
    public class MusteriConfig : BaseConfig<Musteri, int>
    {
        public override void Configure(EntityTypeBuilder<Musteri> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Adi).HasMaxLength(50);
            builder.Property(p => p.Adres).HasMaxLength(500);
            builder.Property(p => p.Soyadi).HasMaxLength(50);
            builder.Property(p => p.Email).HasMaxLength(50);
            builder.Property(p => p.Password).HasMaxLength(50);
            builder.Property(p => p.TcNo).HasMaxLength(11);
        }
    }
}
