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
