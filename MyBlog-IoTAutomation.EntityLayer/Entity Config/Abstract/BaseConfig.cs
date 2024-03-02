using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog_IoTAutomation.EntityLayer.Entities.Abstract;

namespace MyBlog_IoTAutomation.EntityLayer.Entity_Config.Abstract
{
    public abstract class BaseConfig<T, TId> : IEntityTypeConfiguration<T> where T : BaseEntity<TId>
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(p => p.CreateDate).HasDefaultValueSql("GetDate()");
        }
    }
}
