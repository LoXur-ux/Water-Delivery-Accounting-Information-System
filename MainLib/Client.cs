using System;
using System.Collections.Generic;

namespace MainLib
{
	internal class Client : User
	{
		private Address ClientAddress { get; set; }
		private List<Product> PurchasedProduct { get; set; }


		public Client() { }

		public Client(string login, string password, string name, string telNumber, DateTime dateOfRegistration) : base(login, password, name, telNumber, dateOfRegistration)
		{ }

		public Client(string login, string password, string name, string telNumber, DateTime dateOfRegistration, Address address) : base(login, password, name, telNumber, dateOfRegistration)
			=> ClientAddress = address;

		public void SetAddress(string city, string street, int houseNumber, int apartmentNumber, int buildingNumber = 0, string country = "Russia")
			=> ClientAddress = new Address(city, street, houseNumber, apartmentNumber, buildingNumber, country);

		// Заказ.
	}
}
