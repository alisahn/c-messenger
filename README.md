[![Build Status](https://github.com/ytdl-org/youtube-dl/workflows/CI/badge.svg)](https://github.com/alisahn/csharp-messenger)


PhatChat Messenger, C# ile yazılmış, ağ üzerinden haberleşme uygulamasını kapsar.

- [KURULUM](#kurulum)

# KURULUM

Kullanıcı bilgilerini MySQL db içinde sakladım. Bu yüzden dosya içindeki "patchat.sql" isimli dosyayı MySQL içine aktarmanız gerekiyor. 

 - [http://localhost/phpmyadmin/index.php](http://localhost/phpmyadmin/index.php) adresine gidip "patchat" isimli bir veritabanı oluşturun 
 - `user` tablosu içine Kullanıcı bilgileri ekleyin (port bilgisine boş olduğundan emin olduğunuz bir port numarası yazın. Örnek: user_1 için : 81, user_2 için: 82).
 - `Messenger/Db.cs` içinde database bilgilerinizi kendi bilgilerinizle değiştirin.
 - Aynı ağa bağlı olduğunuzdan ve boş portları kullandığınızdan emin olun
