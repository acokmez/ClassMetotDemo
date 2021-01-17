using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri bilgisi sisteme eklendi!\t" + musteri.Id + " : " + musteri.Adi);
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri bilgisi sistemden silindi!\t" + musteri.Id + " : " + musteri.Adi);
        }
        public void MusteriListele(Musteri[] musteriler) // çalışmalarınızda başarılar dilerim..
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Bilgileri : " + musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.KrediLimiti);
                Console.WriteLine(musteri.Borc);
                Console.WriteLine("******************");
            }
        }

    }
}
