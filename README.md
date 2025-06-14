# Mutabakat

## Tanıtım

**Mutabakat**, cari mutabakat işlemlerini, müşteri ve adres yönetimini, istatistiksel raporlamayı ve veri haritalamayı kolaylaştıran bir Windows Forms uygulamasıdır. Özellikle ticari firmaların cari hesaplarını yönetmek ve mutabakat süreçlerini hızlandırmak için geliştirilmiştir.

---

## Özellikler

- Cari kart ve müşteri yönetimi
- Cari mutabakat işlemleri (otomatik PDF oluşturma, toplu mail gönderimi)
- Müşteri adres haritalama ve raporlama (PDF, HTML, Excel aktarım desteği)
- Şirket seçimi ve farklı veritabanları ile çalışma desteği
- Kullanıcı girişi ve yetkilendirme
- İstatistiksel raporlar ve satış analizleri
- Program süresi kontrolü ve lisans mekanizması
- Ayarlar ve uygulama kişiselleştirme

---

## Teknik Altyapı

- **Platform:** Windows Forms (C#)
- **Veritabanı:** SQL Server (Entity Framework ile EDMX tabanlı modelleme)
- **Katmanlar:**
  - *Entitiy/*: Otomatik üretilen EF varlık sınıfları ve context (Model1.edmx)
  - *Forms/*: Arayüz ve iş mantığı (Login, Home, Mutabakat, Map, MapCustomer, Statistics vb.)
- **Bağlantı:** Veritabanı bağlantısı dış dosyadan okunur (Database.txt)
- **Ek Kütüphaneler:**  
  - DevExpress (arayüz ve grid kontrolleri)
  - iTextSharp (PDF oluşturma)
  - LiveCharts (harita ve görsel raporlama)
- **Ekstra:**  
  - Basit şifreleme/çözme işlemleri (Encryption.cs)
  - Program süresi ve lisanslama kontrolü

---

## Kurulum

1. Projeyi klonlayın veya indirin.
2. SQL Server üzerinde gerekli veritabanlarını oluşturun.
3. `Database.txt` dosyasına kendi bağlantı cümlenizi yazın.
4. Gerekli NuGet paketlerini yükleyin (iTextSharp, DevExpress, LiveCharts vb.).
5. Projeyi Visual Studio ile açıp başlatın.

---

## Klasör Yapısı

```
Mutabakat/
├── Entitiy/         # Entity Framework EDMX ve varlık sınıfları
├── Forms/           # Windows Forms arayüz ve iş mantığı
├── Properties/      # Proje ayarları ve kaynaklar
├── bin/             # Derlenmiş çıktı dosyaları
├── Database.txt     # Veritabanı bağlantı cümlesi
└── ...              # Diğer yardımcı ve konfigürasyon dosyaları
```

---

## Katkı

Katkıda bulunmak için projeyi forklayabilir ve pull request gönderebilirsiniz.

---

## Lisans

Bu proje MIT lisansı ile sunulmuştur.
