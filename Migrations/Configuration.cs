namespace NavBarOtherMethod.Migrations
{
    using NavBarOtherMethod.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NavBarOtherMethod.Models.BlogDbCntext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NavBarOtherMethod.Models.BlogDbCntext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.MenuCategories.AddOrUpdate(
                new MenuCategory()
                {
                    Id = 1,

                    Name = "Siyaset",

                    Url = "Home/Siyaset",

                    IsVisible = true,

                    Order = 1
                },
                new MenuCategory()
                {
                    Id = 2,

                    Name = "Idman",

                    Url = "Home/Idman",

                    IsVisible = true,

                    Order = 2
                },
                new MenuCategory()
                {
                    Id = 3,

                    Name = "Muharibe",

                    Url = "Home/Muharibe",

                    IsVisible = true,

                    Order = 3
                }
          );
            context.News.AddOrUpdate(
                new News()
                {
                    Id = 1,

                    Title = "Dünya liderləri İlham Əliyevi təbrik edirlər - YENİLƏNİB",

                    Body = "Rusiya Federasiyası Dağıstan Respublikasının rəhbəri Vladimir Vasilyev " +

                    "Azərbaycan Respublikasının prezidenti İlham Əliyevə təbrik məktubu " +                   
                    "“Hörmətli İlham Heydər oğlu." +
                    "Doğum gününüz münasibətilə Sizi ürəkdən təbrik edirəm." +
                    "Siz uğurlara imza atmış bir dövlət xadimi kimi Azərbaycan " +
                    "Respublikasında sabitliyin və firavanlığın qarantısınız." +
                    "Sizin müdrikliyiniz, uzaqgörənliyiniz və geniş dünyagörüşünüz sayəsində " +
                    "bu gün Azərbaycan Respublikası dinamik inkişaf edən bir dövlətdir.",

                    IsVisible = true,

                    Order = 1,

                    MenuCategoryId = 1
                },
                new News()
                {
                    Id = 2,

                    Title = "“Sabah” altı futbolçusu ilə yollarını ayırdı",

                    Body = "Azərbaycan Premyer Liqasının debütantı olan “Sabah” FK bir neçə " +
                    "futbolçu ilə yollarını ayırıb. " +
                    "Oxu.Az xəbər verir ki, ukraynalı Vitali Kvaşuk, Əlibəy Məmmədli, Elvin " +
                    "Bədəlov, Aydın Bayramov, Tural Qürbətov və Ülvi İbazadə ilə olan " +
                    "müqaviləyə qarşılıqlı razılıq əsasında xitam verilib." +
                    "Əvəzində Bakı klubu dünən “Neftçi”dən ayrılmış Rəşad Eyyubovla 2,5 " +
                    "illik müqavilə bağlayıb.",                    

                    IsVisible = true,

                    Order = 1,

                    MenuCategoryId = 2
                },
                new News()
                {
                    Id = 3,

                    Title = "Zakir Həsənov hərbi liseyə baş çəkdi - FOTO",

                    Body = "Müdafiə naziri, general-polkovnik Zakir Həsənov Azərbaycan prezidenti,  " +
                    "Silahlı Qüvvələrin Ali Baş Komandanı İlham Əliyevin tapşırığına əsasən, " +
                    "Cəmşid Naxçıvanski adına Hərbi Liseydə əsaslı təmir-tikinti prosesi " +
                    "həyata keçirilən obyektlərə baxış keçirib. " +
                    "Bu barədə Oxu.Az-a Müdafiə Nazirliyindən məlumat verilib. " +
                    "Müdafiə naziri inşaatla bağlı əvvəl verilən tapşırıqların icrasını yoxlayıb, " +
                    "yerinə yetiriləcək işlərin keyfiyyətlə və vaxtında başa çatdırılması ilə bağlı "+
                    "konkret göstərişlər verib.",

                    IsVisible = true,

                    Order = 1,
                    
                    MenuCategoryId = 3
                }





                );






        }
    }
}
