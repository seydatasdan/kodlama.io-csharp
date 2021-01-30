using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
	class DateBaseLoggerService:ILoggerService
	{
		public void Log()
		{
			Console.WriteLine("Veritabanına loglandı.");
		}
	}
}
