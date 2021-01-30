using System;

namespace OOP_2
{
	class Program
	{
		static void Main(string[] args)
		{
			GercekMusteri musteri1 = new GercekMusteri();
			musteri1.MusteriNo = "12316";
			musteri1.Adi = "Seyda";
			musteri1.Soyadi = "Tasdan";
			musteri1.TcNo = "45689132";
			musteri1.Id = 3;

			
			TuzelMusteri musteri2 = new TuzelMusteri();
			musteri2.Id = 2;
			musteri2.MusteriNo = "45648";
			musteri2.SirketAdi = "Koıdlama.io";
			musteri2.VergiNo = "988763";

			Musteri musteri3 = new GercekMusteri(); // bir yerde new varsa bu referans numarası demektir.
			Musteri musteri4 = new TuzelMusteri();

			CustomerManager musteriManager = new CustomerManager();
			musteriManager.Add(musteri1);
			musteriManager.Add(musteri1);

		}
	}
}
