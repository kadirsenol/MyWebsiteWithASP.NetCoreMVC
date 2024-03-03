using MyBlog_IoTAutomation.BussinesLayer.Abstract;
using MyBlog_IoTAutomation.BussinesLayer.Concrete;
using MyBlog_IoTAutomation.DataAccessLayer.DBContexts;
using MyBlog_IoTAutomation.DataAccessLayer.Repositories.Abstract;
using MyBlog_IoTAutomation.DataAccessLayer.Repositories.Concrete;
using MyBlog_IoTAutomation.EntityLayer.Entities.Concrete;

namespace MyBlog_IoTAutomation.WebUILayer
{
    public class Program
    {
        public static async Task Main(string[] args) // Program async belirtilerek iþ parcacýklarýnýn gorev yonetimi saglandi.
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<IMusteriManager, MusteriManager>();
            builder.Services.AddScoped<IRepository<Musteri, int>, Repository<SqlDbContext, Musteri, int>>(); // BussinesLayer hazir oldukdan sonra bu servisi kaldýr. Sadece Managerli kismi dursun.
            builder.Services.AddScoped<IRepository<Urun, int>, Repository<SqlDbContext, Urun, int>>();
            builder.Services.AddScoped<IRepository<Kategori, int>, Repository<SqlDbContext, Kategori, int>>();
            builder.Services.AddScoped<IRepository<Konut, int>, Repository<SqlDbContext, Konut, int>>();
            builder.Services.AddScoped<IRepository<Siparis, int>, Repository<SqlDbContext, Siparis, int>>();
            builder.Services.AddScoped<IRepository<SiparisDetay, int>, Repository<SqlDbContext, SiparisDetay, int>>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
