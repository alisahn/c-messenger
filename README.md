[![Build Status](https://github.com/ytdl-org/youtube-dl/workflows/CI/badge.svg)](https://github.com/alisahn/csharp-messenger)


PhatChat Messenger, C# ile yazılmış, ağ üzerinden haberleşme uygulamasını kapsar.

- [KURULUM](#kurulum)
- [KULLANIM](#kullanim)
- [ÖNEMLİ NOTLAR](#notlar)
- [ÖNERİLER](#%C3%B6neri%CC%87ler)

# KURULUM

Kullanıcı bilgilerini MySQL db içinde sakladım. Bu yüzden dosya içindeki "patchat.sql" isimli dosyayı MySQL içine aktarmanız gerekiyor. 

 - [http://localhost/phpmyadmin/index.php](http://localhost/phpmyadmin/index.php) adresine gidip "patchat" isimli bir veritabanı oluşturun/
 - `patchat.sql` dosyasını oluşturduğunuz database içine import edin.
 - `user` tablosu içine Kullanıcı bilgileri ekleyin (port bilgisine boş olduğundan emin olduğunuz bir port numarası yazın. Örnek: user_1 için : 81, user_2 için: 82).
 - `Messenger/Db.cs` içinde database bilgilerinizi kendi bilgilerinizle değiştirin.
 - Aynı ağa bağlı olduğunuzdan ve boş portları kullandığınızdan emin olun


# KULLANIM

 -Database'de user tablonuza eklediğiniz kullanıcı bilgilerini aşağıdaki login ekranına girmelisiniz.
 ![alt text](https://github.com/alisahn/csharp-messenger/blob/master/img/img1.png)

 -Başarılı giriş yaptıktan sonra aşağıdaki chat ekranına kendinizin ve mesajlaşmak istediğiniz kullanıcının port ve host bilgilerini girmelisiniz.
 ![alt text](https://github.com/alisahn/csharp-messenger/blob/master/img/img3.png)

 -Kullanıcı adınızın yanındaki checkbox kutusundan kendinizi Aktif hale getirin ve "Kullanıcı Listesi"nden kontrol edin.
 ![alt text](https://github.com/alisahn/csharp-messenger/blob/master/img/img2.png)

 -Bilgilerin doğruluğundan emin olduktan sonra "Başlat" butonuyla bağlantı kurabilirsiniz. Bu işlemleri mesaj göndermek istediğiniz diğer kullanıcının da yapması gerekiyor.

# NOTLAR

 - port bilgilerine her kullanıcı için boş port numaraları girmeniz gerekiyor.
 - host bilginizi bilmiyorsanız cmd ekranında `ipconfig` yazarak, Wi-Fi için en altta IPv4 adresiniz host bilginizdir.
 - Uygulamanın çalışabilmesi için iki kullanıcının da aynı ağa bağlı olması gerektiğini unutmayınız. 
 - Uygulama testini tek bir cihazda uygulamayı 2 kez çalıştırarak da yapabilirsiniz.
 - Uygulama testini aynı ağa bağlı farklı 2 cihazda da test edebilirsiniz
 - Uygulama testini farklı ağlara bağlı iki uzak cihaz ile test yapmak istiyorsanız Hamachi Server gibi uygulamalarla uzak bilgisayarları aynı ağa bağladıktan sonra sorunsuz test edebilirsiniz.


# ÖNERİLER

 - Arayüz çalışmamı [Bu video'yu](https://www.youtube.com/watch?v=2EcIQEbKBuY&t=477s) uyguladım ve daha sonra özelleştirdim.
 - [MaterialSkin](https://www.nuget.org/packages/MaterialSkin) son sürümünü buradan inceleyebilirsiniz.