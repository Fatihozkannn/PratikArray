using System;

class Program
{
    static void Main()
    {
        // 1 - 10 adet tam sayı verisi alacak bir dizi tanımlanıyor.
        int[] sayilar = new int[10];

        // 2 - Dizinin elemanlarını kullanıcıdan alıyoruz (for döngüsü ile)
        Console.WriteLine("Lütfen 10 adet tam sayı giriniz:");
        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.Write($"{i + 1}. sayıyı girin: ");
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Foreach ile dizi elemanları ekrana yazdırılıyor
        Console.WriteLine("\nGirdiğiniz sayılar:");
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }

        // 3 - Yeni bir değer alınıyor ve diziye 11. eleman olarak ekleniyor
        Console.Write("\nYeni bir sayı giriniz (11. sayı): ");
        int yeniSayi = Convert.ToInt32(Console.ReadLine());

        // Yeni sayı eklenerek yeni bir dizi oluşturuluyor
        int[] yeniDizi = new int[sayilar.Length + 1];
        for (int i = 0; i < sayilar.Length; i++)
        {
            yeniDizi[i] = sayilar[i];
        }
        yeniDizi[10] = yeniSayi; // 11. sayı eklendi

        // 4 - Dizi büyükten küçüğe sıralanıyor
        Array.Sort(yeniDizi);        // Önce küçükten büyüğe sıralanır
        Array.Reverse(yeniDizi);     // Sonra ters çevrilerek büyükten küçüğe olur

        // Sıralanmış diziyi yazdırma
        Console.WriteLine("\nSıralanmış dizi (büyükten küçüğe):");
        foreach (int sayi in yeniDizi)
        {
            Console.WriteLine(sayi);
        }
    }
}
