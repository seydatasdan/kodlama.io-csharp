using System;

namespace donguler
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			string kurs1 = "yazilim gelistirici yetistirme kampi";
			string kurs2 = "programlama baslangic icin temel kurs";
			string kurs3 = "java kursu";
			*/

			//yukardaki gibi tanımlamak zor olacağı için arraylerde tanımlarız.

			string[] kurslar = new string[] {"yazilim gelistirme kampi", "programlama baslangic icin temel kurs", "java" };



			for (int i =0; i<kurslar.Length ;i++) //kurslar.Lenght = kursların uzunluğunca o arrayde gezdi.
			{
				Console.WriteLine(kurslar[i]);
			}

			foreach (string kurs in kurslar) //kurslar içerisinde dolaş
			{
				Console.WriteLine(kurs);
			}
			
			Console.WriteLine("sayfa sonu - footer");
		}
	}
}
