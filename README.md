# 🦠 Virus & Antivirus Simulation (Educational)

Bu proje, C# Windows Forms kullanılarak geliştirilmiş **eğitim amaçlı** ve tamamen **zararsız** bir virüs-antivirüs simülasyonudur. Zararlı yazılımların çalışma mantığını (dosya oluşturma) ve antivirüs yazılımlarının temel çalışma prensibini (imza tabanlı tarama) göstermek amacıyla hazırlanmıştır.

## 🚀 Proje İçeriği

Proje iki ana uygulamadan oluşur:

### 1. FakeVirusApp (Sahte Virüs Simülasyonu)
- Kullanıcı butona tıkladığında `C:\FakeVirusTest` dizininde bir dosya oluşturur.
- Dosya içeriğine zararsız ama belirlenmiş bir "imza" metni yazar.
- Metin, internette popüler olan mizahi "Azerbaijan Virus" şakasını içerir:
  > *"Hi, I am Azerbaijan virus, due to poor technology in my country I not able to damage your computer, please be kind enough to smash your computer with a hammer"*

### 2. AntivirusApp (Antivirüs Simülasyonu)
- Belirlenen bir klasörü (varsayılan: `C:\FakeVirusTest`) tarar.
- Dosyaların içeriğini okuyarak zararlı imzayı ("Azerbaijan virus") arar.
- İmzayı bulduğu dosyaları "Tehdit" olarak işaretler ve siler.
- İşlem günlüğü (log) tutarak kullanıcıyı bilgilendirir.

## 🛠️ Teknolojiler
- **Dil:** C#
- **Platform:** .NET 8.0
- **Arayüz:** Windows Forms (WinForms)
- **IDE:** Visual Studio 2022

## ⚠️ Yasal Uyarı
Bu yazılım **tamamen eğitim ve gösterim amaçlıdır**. 
- Gerçek bir virüs, trojan veya zararlı kod **İÇERMEZ**.
- Sisteminize zarar vermez.
- Antivirüs yazılımı sadece bu projede tanımlanan metni içeren test dosyalarını siler.

## 📥 Kurulum ve Kullanım

1. Projeyi indirin veya kopyalayın.
2. `virus_antivirus.sln` dosyasını Visual Studio ile açın.
3. Çözümü derleyin (Build Solution).
4. Önce **FakeVirusApp**'i çalıştırıp "virüs"ü oluşturun.
5. Sonra **AntivirusApp**'i çalıştırıp klasörü taratın ve temizleyin.

---
*Geliştirilmiş eğitim projesi.*
