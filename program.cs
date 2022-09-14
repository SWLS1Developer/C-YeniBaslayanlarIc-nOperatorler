
    internal class Program
    {
        static void Main(string[] args)
        {
            int S1 = 10, S2 = 20,  S3 = 30, S4 =35;
            double sonuc = 0;

            sonuc = S1 + S2; // 10 + 20 = 30 
            sonuc = S1 - S2; //10 - 20 = -10 
            sonuc = S1 * S2; //10 * 20 = 200
            sonuc = S2 / S1; //20 / 10 = 2

            sonuc = 0; //Sonucu geri sıfıra sabitle;

            sonuc += S1; //sonuc = (sonuc + S1) ile aynı şey.   10
            sonuc -= S1; // 0 - 10 = -10
            sonuc *= S1; // 0 * 10 = 0
            sonuc /= S1; // 0 / 10 = 0

            //Modulus operatörü 
            sonuc = (S4 % S1) + (S3 % S1); //sonuc = (35 mod 10) + (30 mod 10) 
                                           //      = 5 + 0
                                           //Neden 35 mod 10 = 5?
                                           //35, 10'a tam bölünmüyor 35'i kendinden küçük en yakın 10'un katına yuvarlarsak 30'u buluruz
                                           //35'den de bu sonucu çıkarırsak geriye 5 çıkar
                                           //(30 mod 10) sıfırdır (0) çünkü 30, 10'a tam bölünür

            sonuc = Math.Abs(-10); // |-10| Mutlak Değer
            sonuc = Math.Sqrt(25); // 25'in karekökü.
            sonuc = Math.Cos(180); //180 derecelik açının cosünüs değerini verir eğer pixeller ile çalışacaksanız aşağıdaki satırı inceleyin. Math.Sin(Açı); da mevcuttur
            sonuc = Math.Cos((Math.PI / 180) * 45); // Derece çok küçük değerler ile çalışmamıza olanak tanımadığı için açımızı (45°) PI / 180 ile çarparak radyana dönüştürüyoruz
            sonuc = Math.Exp(10); // e (Eulerin değişmezi) ^ 10. e üzeri on ile aynı şeydir. Math.Pow(Math.E, 10) diye de yazılabilir
            sonuc = Math.Truncate(10.4879); // Sayının tam kısmını döndürür: 10
            sonuc = Math.Round(15.6); //Sayıyı yuvarlar sadece yukarı veya aşapı yuvarlamak için Math.Floor ve Math.Celling fonksiyonlarına bakabilirsiniz. 16



            //MANTIKSAL OPERATORLER

            bool sonucBool = false;
            sonucBool = !sonucBool; //Tersine çevrilir false ise true, true ise false olur
            sonucBool = (10 > 50); //False 10, 50'den küçüktür
            sonucBool = (10 < 50); //True 10, 50'den küçüktür
            sonucBool = (50 >= 50); // True 50 (Sayı 1) büyüktür veya eşittir 50 (Sayı 2) (Küçüktür eşittir de var)
            sonucBool = 10 != 30; //False 10 30'a eşit değildir


            //BITWİSE OPERATORLER (^,&,|)
            Flagler buffer = Flagler.F1; // Flagler enumunu bir değişken gibi kullandık ve F1 flagini içine atadık.

            //Mevcut flagi değiştirmeden yeni flag ilave etme;
            buffer = (buffer | Flagler.F2); // | OR ekleme operatoru olarak çalışmaktadır.
            buffer |= Flagler.F2;
            //Neden OR (|) tek bir değişkene ekleme yapıyor;
            //Binary'de bakalım bir de

            //   0001
            //   0010
            // OR----
            //   0011

            //Flag var mı diye kontrol etme;
            sonucBool = buffer.HasFlag(Flagler.F1); //True .HasFlag fonksiyonu kontrol etmek için kullanılabilir veya
            sonucBool = (buffer & Flagler.F1) == Flagler.F1;

            //AND (&) Operatörü nasıl kontrol ediyor?
            //Bir filtre görevi görüyor eğer iki girdi de 1 (true) ise sonuç 1 (true) oluyor

            //   0011
            //   0010   (F2)
            //AND-----
            //   0010 == 0010 Geri F2'ye eşit oldu

            //   0011
            //   0100   (F3)
            //AND-----
            //   0000 != 0010 F3'e eşit değil değer 0000 demekki F3 mevcut değil

            //Flag çıkarma  (XOR)
            buffer = (buffer ^ Flagler.F2);
            buffer ^= Flagler.F2;

            //   0011
            //   0010
            //XOR-----
            //   0001 

            //Sonuç 0001' oldu ve F2 flagi çıkartılmış oldu.
            
        }

        [Flags]
        enum Flagler
        {
            Yok = 0,
            F1 = 2,
            F2 = 2 << 1,
            F3 = 2 << 2,
            F4 = 2 << 3,
        }
    }
