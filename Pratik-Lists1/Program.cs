
using System.Collections.Generic;

// Davetliler listesi oluşturuldu
List<String> isimler = new List<string>() { "Bülent Ersoy ", "Ajda Pekkan ", "Ebru Gündeş", "Hadise", "Hande Yener", "Tarkan", "Funda Arar", "Demet Akalın" };

// Bu değişken, isimleri yazdırırken her bir isme sıralama numarası vermek için kullanılacak.
int siralama = 1;

// isimler listesindeki her bir öğe için döngü başlatılıyor.
foreach (string isim in isimler)
{
    // Konsola sırayla sıralama numarası ve isim yazdırılıyor.
    Console.WriteLine($"{siralama} " + isim);
    siralama++;
}

Console.ReadKey();