using MyBlog_IoTAutomation.DataAccessLayer.DBContexts;
using MyBlog_IoTAutomation.DataAccessLayer.Repositories.Concrete;
using MyBlog_IoTAutomation.EntityLayer.Entities.Concrete;

namespace MyBlog_IoTAutomation.Test
{
    //Bu projeyi console uygulaması açmamım sebebi veri tabanına verilerimi buradan yüklemek ve test edebilmek için.
    internal class Program
    {

        static async Task Main(string[] args) // Main icerisinde cagirilan metotlar thread olduklari icin
                                              // Main metodunun da async ve Task ile gorev yonetimini yonetebilmesi saglanir.
        {

            //Veritabanında benim veri ekleyeceğim tablolarım için repositoryler.Diger tablolar musteri siparisi
            //neticesinde register olacagindan simdilik benim admin panelim icin gerekli tabloları test edecegim.
            //Bir unity conteynıra repolar ilgili etiketleri ile ekleyip merkezleştirilebilirdim. Burada sadece denemek için new ledim.
            Repository<SqlDbContext, Urun, int> urunrepo = new Repository<SqlDbContext, Urun, int>();
            Repository<SqlDbContext, Kategori, int> katerepo = new Repository<SqlDbContext, Kategori, int>();
            Repository<SqlDbContext, Konut, int> konutrepo = new Repository<SqlDbContext, Konut, int>();

            Kategori sicaklikkategori = new Kategori()
            {
                KategoriAdi = "Sıcaklık"
            };

            await katerepo.Insert(sicaklikkategori); // Insert metodu async oldugu icin  
                                                     // donusunu de await olarak beklet-  
                                                     // memiz gerekiyor. Cunku dondurme  
                                                     // zamanlamasi microsoftun guvenilir
                                                     // kollarina emanet..


            ICollection<Kategori> gelenkategori = await katerepo.GetAll(p => p.KategoriAdi == "Sıcaklık"); // Urun kategoriye bagimli oldugundan id degerini db den cekerek
                                                                                                           // ilgili urunun kategoriId property sine register yaptım.
                                                                                                           // Repositorimde GetAll metodunu async tanimladigimdan burada await ile karsiladim.
            int katid = 0;
            foreach (Kategori item in gelenkategori)
            {
                Console.WriteLine($"Sıcaklık kategorisinin Id degeri: {item.Id}");
                katid = item.Id;
            }

            Urun AkilliKlima = new Urun()
            {
                UrunAdi = "IoTKlima",
                Fiyat = "50$",
                StokAdet = "100",
                KategoriId = katid
            };

            await urunrepo.Insert(AkilliKlima);

            Konut bagkonut = new Konut()
            {
                KonutTip = KonutType.bagevi

            };

            await konutrepo.Insert(bagkonut);


            Console.WriteLine("Veritabanı islemleriniz basarı ile gerceklesti.. :)");

        }
    }
}
