namespace MyBlog_IoTAutomation.EntityLayer.Entities.Abstract
{
    public abstract class BaseEntity<T>
    {
        public T Id { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
