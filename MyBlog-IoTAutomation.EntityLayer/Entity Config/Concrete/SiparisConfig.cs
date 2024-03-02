using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog_IoTAutomation.EntityLayer.Entities.Concrete;
using MyBlog_IoTAutomation.EntityLayer.Entity_Config.Abstract;

namespace MyBlog_IoTAutomation.EntityLayer.Entity_Config.Concrete
{
    public class SiparisConfig : BaseConfig<Siparis, int>
    {
        public override void Configure(EntityTypeBuilder<Siparis> builder)
        {
            base.Configure(builder);
        }
    }
}
