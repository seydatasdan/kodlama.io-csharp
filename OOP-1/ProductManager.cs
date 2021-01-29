using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_1
{
	class ProductManager //ürün ile ilgili operasyonlar
	{
		//encapsulation
		public void Add(Product product)
		{
			Console.WriteLine(product.ProductName + "eklendi.");
		}

		public void Update(Product product)
		{
			Console.WriteLine(product.ProductName + "eklendi.");
		}
	}
}
