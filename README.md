# 📊 Mutabakat

## 📝 Tanıtım

**Mutabakat**, şirketlerin cari hesap ve mutabakat işlemlerini kolay, hızlı ve güvenli şekilde yönetebilmesi için geliştirilmiş kapsamlı bir Windows Forms uygulamasıdır. Müşteri, adres, bakiye ve raporlama süreçlerini merkezi bir arayüzde birleştirir.

---

## 🚀 Özellikler

- 👥 Cari kart (müşteri/vendor) yönetimi
- 📧 Toplu mutabakat maili gönderimi ve otomatik PDF oluşturma
- 🗺️ Adres haritalama ve detaylı veri aktarımı (Excel, PDF, HTML)
- 🏢 Farklı şirket/veritabanı ile çalışma
- 🔐 Kullanıcı girişi ve lisans kontrolü
- 📊 Satış ve müşteri istatistikleri, harita üzerinde görselleştirme
- ⚙️ Program ayarları ve kişiselleştirme
- 📁 Dış dosya tabanlı veritabanı bağlantı yönetimi

---

## 🏗️ Teknik Altyapı

- **Platform:** Windows Forms (C#)
- **Veritabanı:** SQL Server (Entity Framework - EDMX model)
- **Mimari:**
  - `Entitiy/` : Otomatik oluşturulan EF model ve varlık sınıfları (Model1.edmx, context ve tablo sınıfları)
  - `Forms/` : Tüm arayüzler ve iş mantığı (Login, Home, Mutabakat, Map, MapCustomer, Statistics, vb.)
- **Ek Kütüphaneler:**
  - DevExpress (gelişmiş arayüz ve gridler)
  - iTextSharp (dinamik PDF dökümanı üretimi)
  - LiveCharts (harita ve data görselleştirme)
- **Bağlantı:** Veritabanı bağlantısı `Database.txt` dosyasından okunur
- **Ekstra:** Basit şifreleme (Encryption.cs), lisans süresi kontrolü, toplu dosya işlemleri

---

## 📂 Klasör Yapısı

```
Mutabakat/
├── Entitiy/         # Entity Framework EDMX ve model dosyaları
├── Forms/           # Windows Forms arayüzleri ve iş mantığı
├── Properties/      # Proje ayarları, meta veriler
├── bin/             # Derlenmiş uygulama dosyaları
├── Database.txt     # Veritabanı bağlantı cümlesi
└── ...              # Diğer yardımcı ve konfigürasyon dosyaları
```

---

## ⚡ Kurulum

1. Projeyi klonlayın veya indirin.
2. SQL Server üzerinde ilgili veritabanlarını oluşturun.
3. `Database.txt` dosyasına bağlantı cümlenizi ekleyin.
4. Gerekli NuGet paketlerini yükleyin (iTextSharp, DevExpress, LiveCharts).
5. Visual Studio ile projeyi açıp çalıştırın.

---

## 🤝 Katkı

Katkı sağlamak için projeyi forklayabilir ve pull request gönderebilirsiniz.

---

## 📄 Lisans

Bu proje MIT lisansı ile sunulmuştur.
