# ASPWebApiOgreniyorum: E-Ticaret API Serüveni 🛒

Bu proje, adım adım bir e-ticaret backend sisteminin nasıl inşa edileceğini gösteren, Türkçe dilinde hazırlanmış bir eğitim serisidir. Her ders, projenin gelişim sürecine göre **commit-commit** ilerlemektedir.

## 🚀 Proje Vizyonu
Sıfırdan başlayarak; veri tabanı tasarımından (ERD) başlayıp, güvenli (Auth), performanslı ve ölçeklenebilir bir Web API mimarisine ulaşmak.

## 🛠 Teknik Mimari ve İçerik
Proje boyunca aşağıdaki kavramlar uygulamalı olarak işlenecektir:

* **Mimari Yapı:** MVC (Model-View-Controller) desenine dayalı API tasarımı.
* **Veri Yönetimi:** Entity Framework Core ile Code-First yaklaşımı.
* **Veri Modelleme (ERD):** * `Product` (Ürün), `Category` (Kategori), `Order` (Sipariş) ve `User` (Kullanıcı) arasındaki ilişkiler.
    * Bire-çok ($1:N$) ve Çoka-çok ($N:N$) ilişki kuralları.
* **Modern Teknikler:**
    * DTO (Data Transfer Object) ve AutoMapper kullanımı.
    * Repository Pattern ve Unit of Work.
    * JWT (JSON Web Token) ile Kimlik Doğrulama.
    * Middleware ve Global Hata Yönetimi.

---

## 🗺 Yol Haritası (E-Ticaret Adımları)

1.  **Aşama 1: Temeller** * Proje altyapısının kurulması ve ilk "Kategori" modelinin oluşturulması.
2.  **Aşama 2: Veri İlişkileri (ERD)**
    * Ürün ve Kategori arasındaki bağlantının kurulması (Entity Configuration).
3.  **Aşama 3: Veritabanı ve Migrations**
    * EF Core ile SQL tabanlı (SQLite/PostgreSQL) veritabanı operasyonları.
4.  **Aşama 4: Business Logic & Controllers**
    * E-ticaret akışları (Sepet işlemleri, ürün listeleme, stok kontrolü).
5.  **Aşama 5: Güvenlik ve Ödeme Simülasyonu**
    * Kullanıcı kayıt/giriş ve sipariş tamamlama süreçleri.

---

## 💻 Geliştirme Ortamı
Bu proje tamamen **GitHub Codespaces** üzerinde geliştirilmektedir. Bu sayede hiçbir kurulum yapmadan "Code > Codespaces > Create" diyerek projeye katkıda bulunabilir veya denemeler yapabilirsiniz.

---
> **Not:** Her dersin detayları ilgili commit mesajlarında ve kod yorumlarında belirtilmiştir. Takip etmek için commit geçmişini inceleyebilirsiniz.