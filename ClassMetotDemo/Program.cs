using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Emir";
            musteri1.Soyadi = "Uyğun";
            musteri1.Yasi = 21;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Mert";
            musteri2.Soyadi = "Er";
            musteri2.Yasi = 20;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Yasi);
                Console.WriteLine("-----------------");
            }


            MusteriManager musterimanager = new MusteriManager();
            musterimanager.MusteriEkle(musteri1);
            musterimanager.MusteriListele(musteri1);
            musterimanager.MusteriSil(musteri1);
            musterimanager.MusteriEkle(musteri2);
            musterimanager.MusteriListele(musteri2);
            musterimanager.MusteriSil(musteri2);



            Console.ReadLine();
        }
    }
}
