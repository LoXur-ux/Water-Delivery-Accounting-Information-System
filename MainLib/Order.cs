using System;
using System.Collections.Generic;

namespace MainLib
{
	internal class Order
	{
		public int Id { get; set; }
		public DateTime OrderDate { get; set; }
		public decimal FullPrice { get; set; }
		public Client Client { get; set; } 
		public Address OrderAddress { get; set; } 
		public List<Product> Products { get; set; }
		public Priority Priority { get; set; }
		public Employee Employee { get; set; }
		public Auto Auto { get; set; }
		public Route Route { get; set; }



		public Order(Address address, Product product, Priority priority)
		{
			OrderAddress = address;
			AddToCart(product);
			Priority = priority;
		}

		public void AddToCart(Product product)
		{
			Products.Add(product);
			FullPrice += product.Price;
		}

		public void MakeOrder()
		{
			OrderDate = DateTime.Now;
			FullPrice *= Priority.IncreaseCost;

			// TODO: ORDER -> Метод вызова заказа. 
		}
	}
}
