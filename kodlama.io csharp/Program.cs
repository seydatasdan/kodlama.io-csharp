using System;

namespace kodlama.io_csharp
{
	class Program
	{
		static void Main(string[] args)
		{
			//type safety = tip güvenliği
			//Do not repeat yourself

			string kategorietiketi = "kategori";
			int ogrencisayisi = 32000;
			double faizorani = 1.025;
			bool sistemegirisyapmismi = false;
			double dolardun = 7.35;
			double dolarbugun = 7.45;

			if(dolardun>dolarbugun)
			{
				Console.WriteLine("azalis butonu");
			}
			else if (dolardun<dolarbugun)
			{
				Console.WriteLine("artis butonu");
			}
			else
			{
				Console.WriteLine("degismedi butonu");
			}




			if (sistemegirisyapmismi == true)
			{
				Console.WriteLine("Kullanici ayarlari butonu");
			}
			else
			{
				Console.WriteLine("Giris yap butonu");
			}


			Console.WriteLine(kategorietiketi);
		}
	}
}
