using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog_IoTAutomation.EntityLayer.Entities.Concrete;
using MyBlog_IoTAutomation.EntityLayer.Entity_Config.Abstract;

namespace MyBlog_IoTAutomation.EntityLayer.Entity_Config.Concrete
{
    public class KonutConfig : BaseConfig<Konut, int>
    {
        public override void Configure(EntityTypeBuilder<Konut> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.KonutTip).HasMaxLength(3);
        }
    }
}
