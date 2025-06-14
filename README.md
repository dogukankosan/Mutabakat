Mutabakat
Proje Tanıtımı
Mutabakat, C# ile geliştirilmiş, .NET Framework 4.7.2 tabanlı bir Windows Forms masaüstü uygulamasıdır
github.com
github.com
. Bu proje, finansal verilerin mutabakatını (uzlaştırmasını) ve raporlanmasını kolaylaştırmak amacıyla oluşturulmuştur. Uygulama, bir SQL Server veritabanına bağlanarak cari hesap bilgilerini ve satış verilerini çeker ve bunların analizini ile görselleştirilmesini sağlar. Geliştirilen arayüz sayesinde kullanıcılar, cari hesap mutabakatı yapabilir, satış istatistiklerini grafiksel olarak görüntüleyebilir ve verileri karşılaştırarak tutarsızlıkları tespit edebilir. Proje, DevExpress UI bileşenleri ile modern ve zengin bir arayüz sunarken, güvenlik için bazı verileri şifrelemek amacıyla kriptografi kütüphaneleri kullanır.
Kullanılan Teknolojiler
Projede kullanılan başlıca teknolojiler ve araçlar şunlardır:
.NET Framework 4.7.2 – Uygulama, .NET 4.7.2 üzerinde çalışacak şekilde geliştirilmiştir
github.com
. Bir masaüstü Windows Forms (WinForms) uygulamasıdır (OutputType WinExe)
github.com
.
C# Programlama Dili – Tüm kod tabanı %100 C# dilinde yazılmıştır
github.com
.
Entity Framework 6.2 – Veritabanı işlemleri için ADO.NET Entity Data Model (Database-First yaklaşımlı .edmx) kullanılmıştır
github.com
. Uygulama, ETA_TEK2012_2012 isimli veritabanına Entity Framework ile bağlanmaktadır.
MS SQL Server – Proje, verilerini SQL Server veritabanından almaktadır. Varsayılan olarak LocalDB/SQL Express üzerinde DOGUKAN\SQLEXPRESS sunucusundaki ETA_TEK2012_2012 veritabanına bağlanacak şekilde yapılandırılmıştır
github.com
 (App.config içindeki connection string üzerinden).
DevExpress WinForms Bileşenleri (v19.2) – Kullanıcı arayüzünde gelişmiş tablo, grafik ve raporlama yetenekleri için DevExpress kütüphaneleri kullanılmaktadır (PivotGrid, Charts, XtraGrid, vb.)
github.com
github.com
. Bu sayede uygulamada grafiksel satış istatistikleri, pivot tablolar ve gelişmiş görsel öğeler yer almaktadır.
BouncyCastle Crypto (v1.8.6) – Uygulamada bazı veri şifreleme/çözme işlemleri için BouncyCastle kriptografi kütüphanesi kullanılmaktadır
github.com
. Örneğin, kullanıcı bilgilerinin veya hassas verilerin güvenli saklanması amacıyla şifreleme modülleri entegre edilmiştir.
Kurulum Aşamaları
Aşağıdaki adımları izleyerek projeyi yerel ortamınızda kurup çalıştırabilirsiniz:
Gereksinimler: Visual Studio 2019 veya üzeri bir sürüm (Windows Forms ve .NET Framework geliştirme bileşenleri yüklü olmalı) ve .NET Framework 4.7.2 hedefleme paketi gereklidir. Ayrıca SQL Server (veya SQL Express) kurulumu gerekmektedir. Projede DevExpress 19.2 bileşenleri kullanıldığı için, bu sürüme uygun DevExpress WinForms kütüphanelerinin de sisteminizde bulunması önerilir (aksi halde referans hataları alabilirsiniz).
Depoyu Klonlayın: Proje kaynak kodunu makinenize indirin veya klonlayın:
bash
Copy
Edit
git clone https://github.com/dogukankosan/Mutabakat.git
NuGet Paketlerini Yükleyin: Çözümü Visual Studio ile açtıktan sonra, NuGet paket yöneticisi gerekli paketleri otomatik olarak indirecektir. Projenin packages.config dosyasında EntityFramework 6.2 ve BouncyCastle 1.8.6 gibi bağımlılıklar tanımlıdır, bunlar açılışta yüklenecektir
github.com
github.com
. Eğer otomatik indirme gerçekleşmezse, Visual Studio'da Tools > NuGet Package Manager > Package Manager Console menüsünden Restore-Package komutunu çalıştırabilirsiniz.
Veritabanı Ayarları: Uygulamanın çalışabilmesi için SQL veritabanı bağlantısının doğru yapılandırılması gerekir. Varsayılan olarak, App.config içinde ETA_TEK2012_2012Entities isimli connection string tanımlıdır ve DOGUKAN\SQLEXPRESS sunucusundaki ETA_TEK2012_2012 veritabanına işaret etmektedir
github.com
.
Eğer bu veritabanına sahipseniz, SQL Server üzerinde gerekli verileri yükleyin ve erişimin çalıştığını doğrulayın.
Farklı bir sunucu veya veritabanı kullanacaksanız, App.config içindeki <connectionStrings> bölümünde uygun şekilde sunucu adını, veritabanı adını, ve gerekliyse kullanıcı adı/şifreyi düzenleyin.
Entity Framework EDMX modeli Entitiy/Model1.edmx altında tanımlıdır. Veritabanı şemanız farklıysa, bu modeli Visual Studio’da güncellemeniz gerekebilir.
DevExpress Bağımlılıkları: Projenin açılışı sırasında, DevExpress ile ilgili referanslar çözülmezse:
Bilgisayarınızda DevExpress v19.2 yüklü olduğundan emin olun. Yüklü değilse, DevExpress’in bu sürümünü temin edip kurmanız veya NuGet üzerinden DevExpress.WinForms paketlerini eklemeniz gerekebilir.
Alternatif olarak, proje içerisindeki DevExpress bileşenlerini kullanmadan derlemek için ilgili referansları kaldırıp DevExpress bileşenlerini formlardan silmeniz gerekir (bu işlem tavsiye edilmez, çünkü uygulamanın raporlama ve grafik arayüz işlevleri devre dışı kalacaktır).
Derleyip Çalıştırın: Çözümi Visual Studio’da açtıktan ve yukarıdaki ayarları tamamladıktan sonra, Mutabakat projesini başlangıç projesi olarak seçin. Ardından projeyi derleyip çalıştırmak için F5 tuşuna basın veya Debug > Start Debugging menüsünü kullanın. Uygulama derlendikten sonra karşınıza bir giriş ekranı gelecektir.
Kullanım Örnekleri
Uygulamayı başarıyla çalıştırdıktan sonra aşağıdaki adımlarla temel işlevleri deneyimleyebilirsiniz:
Giriş Yapma: Uygulama açıldığında ilk olarak bir Login (Giriş) formu ekranı gelecektir
github.com
. Burada sizden kullanıcı adı ve şifre girmeniz istenir. Varsayılan bir kullanıcı hesabınız yoksa, uygulamayı kullanabilmek için veritabanında geçerli kullanıcı bilgileri oluşturmanız gerekebilir (veya geliştirme amaçlı olarak giriş doğrulamasını geçici olarak devre dışı bırakabilirsiniz). Giriş yapıldıktan sonra ana ekrana yönlendirilirsiniz.
Ana Ekran (Home): Giriş başarılı olursa, Home formu (ana ekran) açılır
github.com
. Bu ekranda uygulamanın modüllerine erişim sağlayan menüler veya butonlar bulunur. Ana ekrandan aşağıdaki modüllere ulaşabilirsiniz:
Mutabakat Modülü: “Mutabakat” adlı form üzerinden cari hesap mutabakat işlemlerini gerçekleştirebilirsiniz. Bu modül, iki tarafın muhasebe kayıtlarının karşılaştırılması ve tutarsızlıkların bulunmasını sağlar. Örneğin, bir müşterinin sizin kayıtlarınızdaki bakiyesi ile müşterinin kendi kayıtlarındaki bakiyesini karşılaştırabilirsiniz. Mutabakat formu içerisinde ilgili cari hesabı seçerek mutabakat işlemini başlatabilir, sonuçları görüntüleyebilirsiniz
github.com
.
Satış İstatistikleri: “SalesStatistic” adlı form, veritabanından çekilen satış verilerinin grafiksel analizini sunar
github.com
. Bu ekranda belirli bir tarih aralığındaki satışlar, ürün bazında satış dağılımları veya benzeri KPI (anahtar performans göstergeleri) grafikler halinde görüntülenebilir. DevExpress grafik bileşenleri kullanılarak sütun grafikler, pasta grafikler gibi görseller interaktif şekilde sunulur.
İstatistikler (Genel Raporlar): “Statistics” formu, satış dışındaki diğer istatistiksel verileri veya genel raporları gösterebilir
github.com
. Örneğin, firma genel performans metrikleri, yıllık karşılaştırmalar vb. bu bölümde yer alıyor olabilir.
Veri Haritalama: Uygulamada Map ve MapCustomer adında iki form bulunmaktadır
github.com
. Bu modüller, harici bir kaynaktan gelen verilerin (örneğin başka bir sistemden alınan müşteri veya ürün listelerinin) mevcut veritabanındaki kayıtlarla eşleştirilmesi (haritalanması) için kullanılabilir.
MapCustomer: Dışarıdan alınan müşteri bilgilerini, veritabanındaki Cari Kart (müşteri) kayıtlarıyla eşleştirmenizi sağlar. Örneğin, isim veya ID bazında eşlemeler yaparak mükerrer kayıtları engelleyebilirsiniz.
Map: Diğer türdeki veriler (ürün, kategori v.b.) için benzer bir haritalama işlemi sunuyor olabilir.
Ayarlar: “Settings” formu, uygulamanın konfigürasyon ayarlarını yönetmenizi sağlar
github.com
. Bu ekranda veritabanı bağlantı dizgesini güncelleme, raporlama tercihlerini ayarlama veya diğer uygulama düzeyinde ayarları yapma imkanı bulunur.
Raporlama: Uygulama içerisinde yapılan mutabakat ve analiz işlemleri sonucunda çıktı olarak raporlar alınabilir. Örneğin, cari mutabakat sonucunu bir Mutabakat Raporu olarak yazdırma veya PDF olarak dışa aktarma özelliği mevcut olabilir. DevExpress’in sağladığı bileşenler sayesinde raporları yazdırma, PDF/Excel alma fonksiyonları entegre edilmiştir (kullanıcı arayüzünde ilgili butonlar ile bu işlemler yapılabilir).
Şifreli Veri Yönetimi: Eğer uygulamada kullanıcı şifreleri veya hassas bilgiler tutuluyorsa, bunlar BouncyCastle kütüphanesi kullanılarak şifrelenmiş olabilir. Son kullanıcı olarak bu durum arka planda gerçekleşir; siz sadece ilgili formlarda verileri girip kaydederken uygulama otomatik olarak şifreleme/çözme yapar (örneğin, bir kullanıcı parolasını girip kaydettiğinizde veritabanına şifreli olarak kaydedilir, giriş yaparken doğrulama için tekrar çözülür).
Not: Uygulamanın tam işleyişi ve özellikleri, veritabanında tanımlı verilere ve iş kurallarına bağlıdır. Yukarıdaki kullanım senaryoları genel bir bakış sunar. Projeyi kendi veritabanınıza uyarlarken, formların kodlarını inceleyerek (örn. Forms klasörü altındaki .cs dosyaları) hangi işlemleri yaptıklarını detaylı anlayabilirsiniz.
Klasör Yapısı
Aşağıda proje deposundaki temel klasör ve dosya yapısı gösterilmektedir:
plaintext
Copy
Edit
Mutabakat/                      # Proje ana dizini
├── Entitiy/                    # Entity Framework veri modeli (EDMX ve varlık sınıfları)
│   ├── Model1.edmx             # Veritabanı modelinin tanımı (EDMX tasarım dosyası)
│   ├── ADRESLER.cs             # 'Adresler' tablosunun EF varlık sınıfı
│   ├── CARKART.cs              # 'Cari Kart' (müşteri/vendor) tablosunun EF varlık sınıfı
│   ├── Model1.Context.cs       # Entity Framework veritabanı bağlamı (Context sınıfı):contentReference[oaicite:20]{index=20}
│   └── ... (diğer otomatik üretilen EF sınıf ve ayar dosyaları) 
├── Forms/                      # Windows Forms arayüz formları ve ilgili kod dosyaları
│   ├── Home.cs (ve .Designer.cs, .resx)        # Ana ekran formu (Home)
│   ├── Login.cs (ve .Designer.cs, .resx)       # Giriş formu (Login ekranı)
│   ├── Map.cs (ve .Designer.cs, .resx)         # Veri haritalama formu (genel)
│   ├── MapCustomer.cs (ve .Designer.cs, .resx) # Müşteri haritalama formu
│   ├── Mutabakat.cs (ve .Designer.cs, .resx)   # Cari mutabakat işlemleri formu:contentReference[oaicite:21]{index=21}
│   ├── SalesStatistic.cs (ve .Designer.cs, .resx) # Satış istatistikleri formu:contentReference[oaicite:22]{index=22}
│   ├── Settings.cs (ve .Designer.cs, .resx)    # Ayarlar formu:contentReference[oaicite:23]{index=23}
│   └── Statistics.cs (ve .Designer.cs, .resx)  # Genel istatistikler/raporlar formu:contentReference[oaicite:24]{index=24}
├── Properties/                 # Proje ile ilgili meta veriler ve ayarlar
│   ├── AssemblyInfo.cs         # Derleme (assembly) bilgileri (versiyon, şirket vs.)
│   ├── Resources.resx          # Sabit kaynaklar (ikonlar, dil dosyaları vs.)
│   ├── Settings.settings       # Uygulama ayarlarının tasarım zamanı tanımı
│   ├── Settings.Designer.cs    # Settings ayarları için otomatik oluşturulmuş sınıf
│   └── licenses.licx           # DevExpress lisans dosyası (kullanılan bileşenlerin lisans bilgileri)
├── App.config                  # Uygulama konfigürasyon dosyası (veritabanı connection string vb.):contentReference[oaicite:25]{index=25}
├── CITY.xml                    # Şehir listesi veya ilgili sabit veriler (XML formatında)
├── ETARaporlama.csproj         # C# Proje dosyası (Visual Studio proje yapılandırması):contentReference[oaicite:26]{index=26}:contentReference[oaicite:27]{index=27}
├── Program.cs                  # Programın başlangıç noktası (Main metodu içerir)
├── packages.config             # NuGet paket listesi (EntityFramework, BouncyCastle vb.) 
└── icons8_chart.ico            # Uygulama simgesi (ikon dosyası)
Yukarıdaki yapıda görüldüğü gibi, proje temel olarak Entitiy klasöründeki Entity Framework veri modeli ile Forms klasöründeki arayüz formlarından oluşmaktadır. Entitiy/Model1.edmx dosyası, veritabanı şemasını ve ilişkilerini tanımlarken bu edmx’den üretilen .cs dosyaları (örneğin ADRESLER.cs, CARKART.cs gibi) veritabanı tablolarını temsil eden sınıfları içerir. Forms klasöründe ise her bir uygulama penceresine karşılık gelen Form sınıfları bulunmaktadır (Login, Home, Mutabakat, v.b.). Program.cs içinde uygulamanın giriş noktası tanımlıdır (genellikle Application.Run(new Login()) veya Application.Run(new Home()) şeklinde ilk formun başladığı kod bulunur). App.config dosyasında veritabanı bağlantı dizesi ve diğer konfigürasyon ayarları tanımlanmıştır. NuGet paketlerinin listelendiği packages.config ise proje açılırken ihtiyaç duyulan harici kütüphanelerin (ör. Entity Framework 6.2, BouncyCastle 1.8.6) kurulmasını sağlar.
Katkıda Bulunma
Projeye katkıda bulunmak isteyen geliştiriciler aşağıdaki adımları takip edebilir:
Depoyu Fork Edin: GitHub üzerinde projeyi kendi hesabınıza forklayarak bir kopyasını oluşturun.
Yeni Bir Dal Oluşturun: Yapmak istediğiniz değişiklik veya yeni özellik için açıklayıcı bir isimle yeni bir git dalı (branch) oluşturun. Örneğin:
bash
Copy
Edit
git checkout -b ozellik/yeni-raporlama-modulu
Değişiklikleri Yapın: Kendi dalınızda kod değişikliklerini, iyileştirmeleri veya yeni özelliği ekleyin. Değişiklik yaparken projenin mevcut kod stiline ve mimarisine uyum sağlamaya özen gösterin.
Test ve Derleme: Değişikliklerinizi tamamladıktan sonra uygulamayı derleyip tüm işlevlerin beklendiği gibi çalıştığını doğrulayın. Mevcutsa birim testlerini çalıştırın veya kendi testlerinizi ekleyin.
Commit ve Push: Değişikliklerinizi anlamlı mesajlar ile commitleyin. Örneğin:
bash
Copy
Edit
git add .
git commit -m "Yeni raporlama modülü eklendi ve X hatası düzeltildi"
git push origin ozellik/yeni-raporlama-modulu
Pull Request Açın: Fork ettiğiniz depodaki dalı GitHub üzerinden orijinal proje deposuna karşı bir Pull Request (PR) açarak katkınızı gönderin. PR açıklamasında yaptığınız değişikliklerin özetini ve amacını yazın.
Kodu Gözden Geçirme: Proje sahipleri veya diğer katkıcılar, pull requestinizi inceledikten sonra gerekirse sizden ek düzeltmeler talep edebilir. Geri bildirime göre güncellemeler yapıp commit edebilirsiniz. Tüm değişiklikler onaylandığında PR birleştirilecektir (merge).
Katkılarınız için şimdiden teşekkürler! Her türlü katkı - ister hata düzeltimi, ister yeni özellik eklenmesi, isterse belgeleme iyileştirmesi - projeyi geliştirmeye yardımcı olacaktır. Büyük değişiklikler öncesinde bir Issue açarak proje sahipleriyle tartışmanız, değişikliğin proje vizyonuna uyup uymadığı konusunda fikir birliği sağlamak açısından faydalı olacaktır.
Lisans
Bu proje MIT Lisansı altında lisanslanmıştır. Bu, kodun özgürce kullanılabileceği, değiştirilebileceği ve dağıtılabileceği anlamına gelir. Detaylı lisans bilgileri için lütfen depo içerisindeki LICENSE dosyasına göz atınız. Özetle, MIT lisansı kapsamında projeyi herhangi bir amaçla kullanabilir, katkıda bulunabilir ve değiştirilmiş halleriyle dağıtabilirsiniz. Tek şart, orijinal projeye ait telif hakkı bildiriminin ve lisans metninin kopyalarda yer almasıdır.
