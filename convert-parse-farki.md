# Convert Parse Farkı

Türlerin Yapısal isimleri altından Int32.Parse\(string\) / int.Parse\(string\) şeklinde ulaşılabilen bu metodlar ile yanlızca string türdeki değişkenleri Tam yada Gerçek Sayı türüne dönüştürebiliriz.

Bir string dönüşüm işleminde 3 farklı hata \(error\) oluşabilir. Bunlar;

* **ArgumentNullException :** değer null \(tanımlanmış fakat değer atanmamış\) olduğunda oluşur,
* **FormatException :** değer uygun formatta olmağı zaman \(alfanumerik karakter içerdiğinde\) oluşur,
* **OverflowException :** değer dönüştürülecek hedef türün sınırlarının dışında ise oluşur.

 Convert sınıfı altında bulunan ve To ifadesi ile başlayıp türlerin yapısal karşılıkları ile devam eden Convert.ToInt32\(string\) şeklindeki metodlar ile Parse metodlarından farklı olarak yanlızca string değil  _bool, byte, char,DateTime, decimal, double, float, int, long, object, sbyte, short, string, uint, long ve short_ türlerinin tamamından dönüştürme işlemi yapabilir.

 _Ayrıca Parse metodlarından farklı olarak Convert sınıfı altındaki metodlarda **ArgumentNullException** hatası yoktur, kendilerine dönüştürme işlemi için null bir girdi verildiğinde sıfır \(0\) değeri döndürürler._



