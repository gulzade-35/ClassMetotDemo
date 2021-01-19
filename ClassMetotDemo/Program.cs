using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Mehmet";
            musteri1.MusteriSoyadi = "Kara";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Ayşe";
            musteri2.MusteriSoyadi = "Öztürk";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAdi = "Gülnur";
            musteri3.MusteriSoyadi = "Aktaş";

            Musteri[] musteriler = new Musteri[]
            {
                musteri1,musteri2,musteri3
            };

            //Müşteri Ekleme
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            //Müşteri Listeleme
            musteriManager.Listele(musteriler);

            //Müşteri Silme

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);
        }
    }
}
