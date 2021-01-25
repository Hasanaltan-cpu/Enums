# Convert Parse Farkı



Bir string dönüşüm işleminde 3 farklı hata \(error\) oluşabilir. Bunlar;

* **ArgumentNullException :** değer null \(tanımlanmış fakat değer atanmamış\) olduğunda oluşur,
* **FormatException :** değer uygun formatta olmağı zaman \(alfanumerik karakter içerdiğinde\) oluşur,
* **OverflowException :** değer dönüştürülecek hedef türün sınırlarının dışında ise oluşur.

