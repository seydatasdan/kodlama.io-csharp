﻿using System;
using System.Collections.Generic;
using System.Text;

namespace metotlar
{
	class SepetManager
	{
		// naming convention
		public void Ekle(Product urun)
		{
			Console.WriteLine("Sepete eklendi : " + urun.Adi);
		}

		public void Ekle2(string urunAdi,string aciklama,double fiyat, int stokadedi)
		{
			Console.WriteLine("Sepete eklendi: " + urunAdi);
		}
	}
}
