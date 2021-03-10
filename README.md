# Hasan
Geliştirilen yazılım metin (text) tabanlı bir dosya üzerinde bir takım işlemler yapılmasını
sağlayacaktır. Yazılım, parametre olarak bir dosya ismi alacaktır. Daha sonra kullanıcının seçmiş olduğu tuşlarla 
kelime bulma, değiştirme ve silme gibi işlevleri yerine getirmektedir. Kullanıcı dosya 
üzerinde istediği kadar işlem yapabilmektedir. Girilebilen tuşlar, işlevleri ve parametreleri aşağıdaki gibidir.
Ara=>Dosya içerisinde kelime arama işlemi yapar. 
Tuş, dosya içerisinde aranacak kelimeyi 
bulmak için 1 parametre almaktadır.
Değiştir=>Dosya içerisinde kelimelerin başka bir kelime ile 
değiştirilmesini sağlar. Tuş, dosya içerisinde 
bulunacak ve bulunan kelimenin değiştirileceği 
kelime olmak üzere 2 parametre almaktadır.
Sil=>Dosya içerisinde verilen kelimenin silme işlemini 
yapar. Tuş, dosya içerisinde silinecek kelime 
için 1 parametre almaktadır.
Komutların parametrelerinin belirlenmesinde de birtakım kurallar tanımlanmıştır. Eğer, kullanıcının girdiği 
kelimelerin harflerinde “-” işareti varsa bu herhangi bir harf anlamına gelmektedir. Eğer kullanıcının girdiği 
kelimelerin harflerinde “*” işareti varsa bu sıfır ya da sıfırdan fazla herhangi harf anlamına gelmektedir.
Örneğin, kullanıcı F aba komutunu girdiğinde yazılım aba kelimesi geçen kelimelerin sayısını dönmelidir. 
Eğer kullanıcı F –aba- komutunu girdiğinde yazılım 5 harfli baş harfi ve son harfi herhangi bir harf olan 
ortası ada olan kelimelerin sayısını dönmelidir. (Örneğin, radar, kadar vs) Eğer kullanıcı, F *ata* komutunu 
girdiğinde yazılım içerisinde ata geçen başında ve sonunda sıfır yada sıfırdan fazla sayıda herhangi harf olan 
kelimelerin sayısını dönmelidir. (Örneğin, salatalık, atamak vs) Bu kural sadece bulma (F) komutunda değil 
kelime değiştirme (R) ve silme (D) komutlarında da geçerlidir. 
