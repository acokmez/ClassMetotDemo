using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Ahmet Bey";
            musteri1.KrediLimiti = 8950;
            musteri1.Borc = 356.32;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Melek Hanım";
            musteri2.KrediLimiti = 18965;
            musteri2.Borc = 123.56;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Mehmet Bey";
            musteri3.KrediLimiti = 3455;
            musteri3.Borc = 1356.78;

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriSil(musteri3);
            musteriManager.MusteriListele(musteriler);

        }
    }
}
