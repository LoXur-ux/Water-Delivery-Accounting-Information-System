using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLib
{
	internal class Product
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public double Volume { get; set; }

		public Product() { }

		public Product(string name, string description, decimal price, double volume)
		{
			Name = name;
			Description = description;
			Price = price;
			Volume = volume;
		}
	}
}
