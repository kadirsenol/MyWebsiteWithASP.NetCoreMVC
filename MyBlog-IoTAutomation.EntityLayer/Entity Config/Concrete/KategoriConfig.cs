using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog_IoTAutomation.EntityLayer.Entities.Concrete;
using MyBlog_IoTAutomation.EntityLayer.Entity_Config.Abstract;

namespace MyBlog_IoTAutomation.EntityLayer.Entity_Config.Concrete
{
    public class KategoriConfig : BaseConfig<Kategori, int>
    {
        public override void Configure(EntityTypeBuilder<Kategori> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.KategoriAdi).HasMaxLength(50);
        }
    }
}
