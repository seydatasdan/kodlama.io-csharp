using System;

namespace classintro
{
	class Program
	{
		static void Main(string[] args)
		{
			string adi = "seyda";
			int yas = 21;

			kurs kurs1 = new kurs();
			kurs1.Kursadi = "C#";
			kurs1.Egitmen = "Engin Demiroğ";
			kurs1.İzlenmeorani = "68";

			kurs kurs2 = new kurs();
			kurs2.Kursadi = "Python";
			kurs2.Egitmen = "Asaf Demir";
			kurs2.İzlenmeorani = "48";

			kurs kurs3 = new kurs();
			kurs3.Kursadi = "Java";
			kurs3.Egitmen = "Kerem Ali";
			kurs3.İzlenmeorani = "71";

			//Console.WriteLine(kurs1.Kursadi + " : " + kurs1.Egitmen);

			kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };

			foreach(var kurs in kurslar)
			{
				Console.WriteLine(kurs.Kursadi + " : " + kurs.Egitmen);
			}
		}
	}

	class kurs
	{
		public string Kursadi { get; set; }
		public string Egitmen { get; set; }
		public string İzlenmeorani { get; set; }
	}
}
