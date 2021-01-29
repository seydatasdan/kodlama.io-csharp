using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
	class Program
	{
		static void Main(string[] args)
		{

			//string[] isimler = new string[] { "Kerem", "Seyda", "Halil", "Beyza" };
			//Console.WriteLine(isimler[0]);
			//Console.WriteLine(isimler[1]);
			//Console.WriteLine(isimler[2]);
			//Console.WriteLine(isimler[3]);

			//isimler = new string[5];
			//isimler[4] = "İlker";
			//Console.WriteLine(isimler[4]);
			//Console.WriteLine(isimler[0]); //dizideki 0. eleman yani kerem yazmaz, boşluk gelir onun yerine çünkü new string derken yeni bir adres olşturduk ve oradaki 0. eleman gelir.

			List<string> isimler2 = new List<string> {"Kerem","Seyda","Halil","Beyza" };
			Console.WriteLine(isimler2[0]);
			Console.WriteLine(isimler2[1]);
			Console.WriteLine(isimler2[2]);
			Console.WriteLine(isimler2[3]);
			isimler2.Add("İlker");
			Console.WriteLine(isimler2[4]);
			Console.WriteLine(isimler2[0]);

			// Burada koleksiyonları kullandık ve bu kez keremi de yazdı. Koleksiyonlarda değerleri kaydedecek bir altyapı var.
		}
	}
}

