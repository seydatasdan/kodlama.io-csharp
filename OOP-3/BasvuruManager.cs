using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
	class BasvuruManager
	{
		//Method injection
		public void BasvuruYap(ICrediManager crediManager,ILoggerService loggerService)
		{
			//Basvuran bilgileri 
			//
			crediManager.Hesapla();
			loggerService.Log();
		}
		public void CrediOnBilgilendirmesiYap(List<ICrediManager>Credis)
		{
			foreach(var credi in Credis)
			{
				credi.Hesapla();
			}
		}

	}
}
