# KitaplikForm

[TR]

**Masaüstü Kitaplık ve Envanter Yönetim Uygulaması (WinForms/WPF)**

[![C#](https://img.shields.io/badge/Language-C%23-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Platform](https://img.shields.io/badge/Platform-Windows%20Desktop%20App-informational.svg)]()
[![Database](https://img.shields.io/badge/Database-SQL%20%7C%20Access%20%7C%20LocalDB-CC2927.svg)](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms)
[![GitHub repo size](https://img.shields.io/github/repo-size/abdullahhaktan/KitaplikForm)](https://github.com/abdullahhaktan/KitaplikForm)

---

## 💻 Proje Hakkında

Bu proje, bir kütüphanenin veya kişisel bir kitap koleksiyonunun **envanterini kolayca yönetmek** için C# dilinde geliştirilmiş bir masaüstü uygulamasıdır. Proje, temel **CRUD (Oluşturma, Okuma, Güncelleme, Silme)** işlemlerini bir **grafik arayüz (GUI)** üzerinden göstererek, masaüstü uygulamalarında veritabanı entegrasyonunun nasıl yapıldığını öğretmeyi amaçlar.

---

## ✨ Temel Özellikler

### Kitap Yönetimi
* **Kitap Ekleme:** Yeni kitapları (Ad, Yazar, Yayıncı, Sayfa Sayısı vb. bilgilerle) veritabanına kaydetme.
* **Kitap Listeleme:** Tüm kitapları veya filtrelenmiş kitapları tablo (DataGridView) üzerinde görüntüleme.
* **Kitap Güncelleme:** Mevcut bir kitabın bilgilerini düzenleme ve kaydetme.
* **Kitap Silme:** Seçili kitabı veritabanından kalıcı olarak kaldırma.
* **Arama ve Filtreleme:** Başlık, yazar veya türe göre kitap arama işlevselliği.

### Teknik Altyapı
* **Veritabanı:** Kitap verilerini kalıcı olarak saklamak için **SQL Server LocalDB, MS Access** veya benzeri hafif bir veritabanı kullanılmıştır.
* **Arayüz:** Proje, kullanıcı etkileşimi için **Windows Forms (WinForms)** veya **WPF** kullanılarak geliştirilmiştir.

---

## 🚀 Nasıl Çalıştırılır?

Bu proje, **Visual Studio** ve bir **.NET Masaüstü geliştirme ortamı** gerektirir.

1.  **Projeyi Klonlama:**
    ```bash
    git clone [https://github.com/abdullahhaktan/KitaplikForm](https://github.com/abdullahhaktan/KitaplikForm)
    cd KitaplikForm
    ```

2.  **Veritabanı ve Bağlantıyı Ayarlama:**
    * Projenin kullandığı **veritabanı dosyasını (`.mdf` veya `.accdb`)** bulun.
    * **`App.config`** veya ilgili bağlantı dizesi dosyasını açarak veritabanı yolunu veya bağlantı ayarlarını kendi yerel sisteminize göre güncelleyin.

3.  **Projeyi Başlatma:**
    * **Visual Studio** ile `.sln` (Solution) dosyasını açın.
    * Gerekliyse **NuGet** paketlerini geri yükleyin.
    * Çözümü derleyin ve **F5** tuşu ile uygulamayı çalıştırın. Uygulama, kitaplık yönetim arayüzünü açacaktır.

---
---

[EN]

# KitaplikForm

**Desktop Library and Inventory Management Application (WinForms/WPF)**

---

## 💻 About the Project

This project is a desktop application developed in C# to **easily manage the inventory** of a library or a personal book collection. The project aims to demonstrate fundamental **CRUD (Create, Read, Update, Delete)** operations through a **Graphical User Interface (GUI)**, teaching how database integration is performed in desktop applications.

---

## ✨ Core Features

### Book Management
* **Add Book:** Saving new books to the database with details (Title, Author, Publisher, Page Count, etc.).
* **List Books:** Displaying all books, or filtered books, in a table (DataGridView) format.
* **Update Book:** Editing and saving the information of an existing book.
* **Delete Book:** Permanently removing a selected book from the database.
* **Search and Filter:** Functionality to search for books by title, author, or genre.

### Technical Foundation
* **Database:** A lightweight database such as **SQL Server LocalDB, MS Access**, or similar is used to persistently store book data.
* **Interface:** The project is developed using **Windows Forms (WinForms)** or **WPF** for user interaction.

---

## 🚀 How to Run

This project requires **Visual Studio** and a **.NET Desktop development environment**.

1.  **Clone the Repository:**
    ```bash
    git clone [https://github.com/abdullahhaktan/KitaplikForm](https://github.com/abdullahhaktan/KitaplikForm)
    cd KitaplikForm
    ```

2.  **Configure Database and Connection:**
    * Locate the **database file (`.mdf` or `.accdb`)** used by the project.
    * Open the **`App.config`** or the relevant connection string file and update the database path or connection settings to match your local system.

3.  **Start the Project:**
    * Open the **`.sln`** (Solution) file with **Visual Studio**.
    * Restore **NuGet** packages if necessary.
    * Build the solution and run the application by pressing **F5**. The application will launch the library management interface.
---
---

<img width="490" height="322" alt="Ekran görüntüsü 2025-10-03 150150" src="https://github.com/user-attachments/assets/9ab5e7c8-ac4e-475f-9080-b457196364d3" />
