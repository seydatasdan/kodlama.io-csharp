using System;

namespace metotlar
{
	class Program
	{
		static void Main(string[] args)
		{
			//clean code - best pratice

			string urunadi1 = "elma";
			double fiyati1 = 15;
			string aciklama1 = "Amasya elması";

			string[] meyveler = new string[] { };

			Product urun1 = new Product();
			urun1.Adi= "elma";
			urun1.Fiyati = 15;
			urun1.Aciklama = "Amasya elması";

			Product urun2 = new Product();
			urun2.Adi = "karpuz";
			urun2.Fiyati = 80;
			urun2.Aciklama = "Diyarbakir karpuzu";

			Product[] urunler = new Product[] { urun1, urun2 };

			// Type-safe -- Tip güvenli

			foreach (Product urun in urunler)
			{
				Console.WriteLine(urun.Adi);
				Console.WriteLine(urun.Fiyati);
				Console.WriteLine(urun.Aciklama);
				Console.WriteLine("--------------------------");
			}

			Console.WriteLine("--------------------Metotlar---------------");

			//encapsulation - kapsülleme

			SepetManager sepetManager = new SepetManager();
			sepetManager.Ekle(urun1);
			sepetManager.Ekle(urun2);

		    sepetManager.Ekle2("Armut", "Yeşil armut", 12,8);
			sepetManager.Ekle2("Elma", "Yeşil elma", 18,25);
			sepetManager.Ekle2("Karpuz", "Yeşil karpuz", 60,10);
		}
	}
}
