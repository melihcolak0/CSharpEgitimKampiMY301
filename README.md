# :gem:C# Eğitim Kampı (#301)
Bu repository, Murat Yücedağ'ın C# Eğitim Kampı isimli eğitiminin #301 OOP Modülü: C# ile N Katmanlı Mimari modülünü içermektedir.

## :pushpin: Proje 1 -> OOP Modülü: Dört Katmanlı Mimaride Entity Layer'ın Oluşturulması
Bu projede OOP (Nesne Yönelimli Programlama) ile dört katmanlı bir mimari oluşturacağız. Bu aşamada projenin katmanlarını oluşturdum. Ardından da Entity Layer'daki Sınıfları ve sınıfların içerisindeki Property'leri oluşturdum.

## :pushpin: Proje 2 -> OOP Modülü: Dört Katmanlı Mimaride Data Access Katmanı ve Context Sınıfı
Bu projede OOP ile oluşturduğumuz dört katmanlı mimarinin DataAccess katmanını ve Context sınıfını oluşturdum. Data Access katmanı uygulamanın veri tabanı ile etkileşim kurmasını sağlayan yapıların toplandığı katmandır. Context sınıfı ise Entity Framework’ün veri tabanına bağlanmasını sağlayan sınıftır.

## :pushpin: Proje 3 -> OOP Modülü: Dört Katmanlı Mimaride Migration İşlemleri ve Abstract Interfaces
Bu projede OOP ile oluşturduğumuz dört katmanlı mimaride migration işlemlerini yaptım. Migration işlemleri veri tabanı şemasındaki değişiklikleri yönetmek için kullanılan bir özelliktir. Migration’lar, veri tabanı ile kod arasındaki tutarlılığı sağlamak amacıyla yapılan değişikliklerin versiyonlanmasına olanak tanır. Sonrasında ise Abstract klasörü içerisine Interface'leri oluşturdum. Bu interface'ler, farklı varlıklar (entity) için veri erişim katmanında (Data Access Layer - DAL) temel veri erişim operasyonlarını belirtmek amacıyla tanımlandılar.

## :pushpin: Proje 4 -> ORM Yapısı: Entity Framework'de Database First ve Model Oluşturma
Bu projede Entity Framework'de Database First (Var Olan Veri tabanını Kullanma) yaklaşımını kullandım. Öncelikle MS SQL Server'dan bir veri tabanı oluşturdum. Daha sonra ADO.NET Entity Data Model kullanarak bu veri tabanını Entity Framework aracılığıyla C# kodlarına aktardım. Bu şekilde, veri tabanındaki tablolar ve ilişkiler C# sınıflarına dönüştürülmüş oldu. Bu sınıflar, veri tabanındaki her tabloya karşılık gelen C# nesneleri olarak kullanılabilir hale geldi.

## :pushpin: Proje 5 -> ORM Yapısı: Entity Framework Metotları ile Proje Uygulaması
Bu projede Entity Framework metotlarını kullanarak basit bir proje oluşturdum. Projede Listeleme, Ekleme, Silme, Güncelleme ve Id'ye Göre Getirme işlemlerini öncesinde bir Form ekranında butonlara atayarak kullandım. Sonrasında bu butonları kullanarak Entity Framework sayesinde SQL komutları kullanmadan DataGridView üzerinde veri tabanı işlemlerini uyguladım.

## :pushpin: Proje 6 -> ORM Yapısı: Entity Framework'de Tur Projesi ve Location İşlemleri
Bu projede Entity Framework metotlarını kullanarak, bir önceki projede oluşturmuş olduğum projeye, bir başka Form ekledim. Bu Form üzerinden MS SQL Server'da oluşturmuş olduğum TblLocation isimli tablonun verileri ile Listeleme, Ekleme, Silme ve Güncelleme işlemlerini bir buton kullanarak ve DataGridView üzerinde görüntüleyerek oluşturdum.

## :pushpin: Proje 7 -> ORM Yapısı: Entity Framework Metotları ve Linq Sorgular
Bu projede Entity Framework metotlarını kullanarak, bir önceki projede oluşturmuş olduğum projenin Lokasyon tablosunun istatistiklerini çıkardım. Lokasyon Sayısı, Toplam Kapasite, Rehber Sayısı, Ortalama Kapasite, Ortalama Tur Fiyatı, Eklenen Son Ülke, Kapadokya Tur Kapasitesi, Türkiye Turları Ortalama Kapasite, Roma Tur Rehberi, En Yüksek Kapasiteli Tur, En Pahalı Tur ve Ayşegül Çınar Tur Sayısı gibi istatistikleri MS SQL Server üzerinden LINQ sorguları ile alarak Windows Form üzerinde label kullanarak yazdırdım. Aşağıda oluşturmuş olduğum FrmStatistics formunu görebilirsiniz:

<div align="center">
  <img src="https://github.com/melihcolak0/CSharpEgitimKampiMY301/blob/ac72eb081f3ef57cc0425d418281b3ed496a368f/locationStatisticsSS.jpg" alt="image alt">
</div>

## :pushpin: Proje 8 -> OOP Modülü: Dört Katmanlı Mimaride EntityState Komutları, Generic Repository Sınıfı ve Entity Framework Sınıfları
Bu projede OOP ile oluşturduğumuz dört katmanlı mimaride ilk olarak GenericRepository'i oluşturdum. GenericRepository, yazılım tasarımında sık kullanılan bir desen (design pattern) olan Repository Pattern'in jenerik (generic) bir uygulamasıdır. Repository Pattern, bir uygulamanın veri erişim katmanını (Data Access Layer - DAL) soyutlamak ve yönetilebilir hale getirmek için kullanılır. GenericRepository, bu yapıyı tüm varlıklar (entities) için genelleştirerek tekrar eden kodları ortadan kaldırır ve modüler bir yapı sunar. EfAdminDal, EfCustomerDal gibi eklediğim sınıflar, Entity Framework kullanılarak oluşturulmuş ve Data Access Layer (DAL) içerisinde yer alan veri erişim sınıflarıdır. Bu sınıflar, Entity Framework'ün özelliklerini kullanarak veritabanıyla etkileşim kurar. Her bir sınıf, belirli bir entity (varlık) ile ilgili CRUD (Create, Read, Update, Delete) işlemlerini veya özel sorguları gerçekleştirir.

## :pushpin: Proje 9 -> OOP Modülü: Dört Katmanlı Mimaride Business Katmanı ve Logic Kurallar
Bu projede OOP ile oluşturduğumuz dört katmanlı mimaride Business Layer'da Generic (genel) bir interface olup, temel CRUD (Create, Read, Update, Delete) işlemleri için şablon sağlayan IGenericService Interface'ini oluşturdum. Sonrasında ICategoryService, ICustomerService, IOrderService ve IProductService Interface'lerini oluşturdum. Eğer sadece Category, Customer, Order ve Product için özel bir iş mantığı gerekiyorsa ICategoryService, ICustomerService, IOrderService ve IProductService Interface'lerinin içerisinde tanımlanabilir. Bunlar ayrıca IGenericService<<awd>Category>, IGenericService<<awd>Customer>, IGenericService<<awd>Order> ve IGenericService<<awd>Product> arayüzlerinden türetilir. Devamında ICategoryService arayüzünü implement (Nasıl yapılacağını tanımlar.) eden, Category entity'sine özgü iş mantığını ve CRUD işlemlerini uygulayan, Veri katmanı (Data Access Layer - DAL) ile iş katmanı arasında bir köprü görevi gören, İş mantığının somut uygulanmasını sağlayan ve ICategoryDal üzerinden veri erişim katmanına bağlanarak veri işlemlerini gerçekleştiren CategoryManager sınıfını ve aynı şekilde bu işlemleri Customer, Order ve Product için de yapan CustomerManager, OrderManager ve ProductManager sınıflarını oluşturdum.
