using System;
using System.Collections.Generic;

namespace OOP_3
{
	class Program
	{
		static void Main(string[] args)
		{
			ICrediManager ihtiyacCrediManager = new İhtiyacCrediManager();
			ICrediManager tasitCrediManager = new TasitCrediManager();
			ICrediManager konutCrediManager = new KonutCrediManager();

			ILoggerService datebaseLoggerService = new DateBaseLoggerService();
			ILoggerService fileLogerService = new FileLoggerService();

			BasvuruManager basvuruManager = new BasvuruManager();
			basvuruManager.BasvuruYap(konutCrediManager, datebaseLoggerService);

			List<ICrediManager> Credis = new List<ICrediManager>() {ihtiyacCrediManager, tasitCrediManager };

			//basvuruManager.CrediOnBilgilendirmesiYap(Credis);
		}
	}
}
