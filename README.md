# 🎬 Patikaflix - Diziler Platformu (Console Uygulaması)

Bu proje, C# dilinde geliştirilmiş bir konsol uygulamasıdır. Kullanıcıdan dizi bilgilerini alarak liste oluşturan ve komedi dizilerini filtreleyip sıralayan bir sistem içerir.

## 🧩 Proje Yapısı

Proje, 3 ayrı `.cs` dosyasından oluşur:

| Dosya Adı         | Açıklama                                      |
|-------------------|-----------------------------------------------|
| `Program.cs`      | Uygulamanın giriş noktası, tüm işlemler burada yürütülür. |
| `Series.cs`       | Tüm dizi bilgilerini tutan sınıf.             |
| `ComedySeries.cs` | Sadece komedi dizilerine ait sade sınıf.      |

---

## 🛠 Özellikler

- Konsol üzerinden sınırsız sayıda dizi eklenebilir.
- Her dizi için:
  - Dizi Adı
  - Türü
  - Yönetmeni
  - Sezon Sayısı
  - Yayın Yılı alınır.
- Girilen dizilerden **"komedi"** türünde olanlar filtrelenir.
- Komedi dizileri:
  - **Dizi Adı**
  - **Türü**
  - **Yönetmeni**
  bilgileri ile yeni bir listeye aktarılır.
- Yeni liste hem dizi adına hem yönetmene göre **alfabetik** olarak sıralanır.

