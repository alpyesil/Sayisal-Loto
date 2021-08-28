using System;

namespace Ders2
{
    class Program
    {
        static void Main(string[] args)
        {
            //-Sayısal Loto oyunu:
            //1.Adım: Program kullanıcıdan 1 - 49 arası 6 adet sayı girmesini isteyecek,
            //2.Adım:  6 elemanlı, 1 - 49 arası rastgele sayılardan oluşturulmuş bir dizi oluşturacak.
            //3.Adım: loto sayılarının olduğu dizi ve kullanıcı tahminlerinin olduğu dizi karşılaştırılarak eşleşen sayı adedi bulunacak.
            //4.Adım: Oyuncu 3’ün altında bilmişse program “Kazanamadınız.” mesajı verecek. Diğer durumlarda “Tebrikler X adet sayı bildiniz” mesajı verecek.
            //5.Adım: Oyuncunun bildiği sayılar ekrana yazdırılacak.

            int sayac = 0; //Tahmini ve Kazanma durmunu belirlemek için sayaç durumu.
            Console.WriteLine("Sayısal Loto");

            int[] sayisal = new int[6];
            Console.WriteLine("Lütfen 1 İle 49 arası 6 adet sayı girin \n");

            for (int i = 0; i < 6; i++)
            {
                Console.Write((i + 1) + ". Sayıyı girin: ");
                sayisal[i] = int.Parse(Console.ReadLine()); //kullanıcının girdiği sayılar

                if (sayisal[i] > 49 || sayisal[i] < 0) // 1-49 arası sayı olduğunu sorguluyor
                {
                    Console.WriteLine("1-49 arası sayı girmelisin");
                    i--;
                }

            }
            Console.WriteLine("Giriş yaptığınız sayılar: ");
            for (int i = 0; i < 6; i++)
            {
                Console.Write(sayisal[i] + " "); //Kullanıcının girdiği sayıların çıktısı               
            }
            int[] loto = new int[6];
            Random rnd = new Random();
            Console.WriteLine("\n" + "Loto sonuçları: ");
            for (int l = 0; l < 6; l++)
            {

                loto[l] = rnd.Next(1, 49); //1 ile 49 arası arası tahmin oluşuyor.

                Console.Write(loto[l] + " "); //Bilgisayarın oluşturduğu sayılar
            }

            Console.WriteLine("\n" + "Eşleşen Sayı veya sayılar aşağıdadır!!");

            if (sayisal[0] == loto[0] || sayisal[0] == loto[1] || sayisal[0] == loto[2] || sayisal[0] == loto[3] || sayisal[0] == loto[4] || sayisal[0] == loto[5]) // Kullanıcının girdiği 1. Sayıyı PC'nin kümlerini kontrol ederek matchliyor
            {
                sayac++; // Tahmin doğruysa sayaç 1 artıyor
                Console.WriteLine(sayisal[0]); // Tahmin doğruysa yazdırlan 1. Sayı
            }
            if (sayisal[1] == loto[0] || sayisal[1] == loto[1] || sayisal[1] == loto[2] || sayisal[1] == loto[3] || sayisal[1] == loto[4] || sayisal[1] == loto[5]) // Kullanıcının girdiği 2. Sayıyı PC'nin kümlerini kontrol ederek matchliyor
            {
                sayac++; // Tahmin doğruysa sayaç 1 artıyor
                Console.WriteLine(sayisal[1]); // Tahmin doğruysa yazdırlan 2. Sayı
            }
            if (sayisal[2] == loto[0] || sayisal[2] == loto[1] || sayisal[2] == loto[2] || sayisal[2] == loto[3] || sayisal[2] == loto[4] || sayisal[2] == loto[5]) // Kullanıcının girdiği 3. Sayıyı PC'nin kümlerini kontrol ederek matchliyor
            {
                sayac++; // Tahmin doğruysa sayaç 1 artıyor
                Console.WriteLine(sayisal[2]); // Tahmin doğruysa yazdırlan 3. Sayı
            }
            if (sayisal[3] == loto[0] || sayisal[3] == loto[1] || sayisal[3] == loto[2] || sayisal[3] == loto[3] || sayisal[3] == loto[4] || sayisal[3] == loto[5]) // Kullanıcının girdiği 4. Sayıyı PC'nin kümlerini kontrol ederek matchliyor
            {
                sayac++; // Tahmin doğruysa sayaç 1 artıyor
                Console.WriteLine(sayisal[3]); // Tahmin doğruysa yazdırlan 4. Sayı
            }
            if (sayisal[4] == loto[0] || sayisal[4] == loto[1] || sayisal[4] == loto[2] || sayisal[4] == loto[3] || sayisal[4] == loto[4] || sayisal[4] == loto[5]) // Kullanıcının girdiği 5. Sayıyı PC'nin kümlerini kontrol ederek matchliyor
            {
                sayac++; // Tahmin doğruysa sayaç 1 artıyor
                Console.WriteLine(sayisal[4]); // Tahmin doğruysa yazdırlan 5. Sayı
            }
            if (sayisal[5] == loto[0] || sayisal[5] == loto[1] || sayisal[5] == loto[2] || sayisal[5] == loto[3] || sayisal[5] == loto[4] || sayisal[5] == loto[5]) // Kullanıcının girdiği 6. Sayıyı PC'nin kümlerini kontrol ederek matchliyor
            {
                sayac++; // Tahmin doğruysa sayaç 1 artıyor
                Console.WriteLine(sayisal[5]); // Tahmin doğruysa yazdırlan 6. Sayı
            }
            Console.WriteLine("Eşleşme adedi: " +sayac);
            if (sayac < 3) // Kullanıcın kaç sayı tahmin ettiğini ona göre kazanığ kazanmadığını sorgulayan satır
            {
                Console.WriteLine("Kaybettiniz Malesef" + " " + sayac + " sayı bildiniz :(" ); // Kaybedildi baskısı
            }
            else
            {
                Console.WriteLine("KAZANDINIZ!! Tebrikler" + " " + sayac + " adet sayı bildiniz"); // Kazanıldı baskısı
            }

            Console.ReadKey();
        }

    }
}

