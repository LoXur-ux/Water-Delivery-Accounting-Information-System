namespace MainLib
{
	public class Address
	{
		public string Country { get; set; }
		public string City { get; set; }
		public string Street { get; set; }
		public int HouseNumber { get; set; }
		public int BuildingNumber { get; set; }
		public int ApartmentNumber { get; set; }

		public Address(string city, string street, int houseNumber, int apartmentNumber, int buildingNumber = 0, string country = "Russia")
		{
			Country = country;
			City = city;
			Street = street;
			HouseNumber = houseNumber;
			BuildingNumber = buildingNumber;
			ApartmentNumber = apartmentNumber;
		}

		public Address() { }

		public static double GetDist(Address addressFrom, Address addressTo)
		{
			// TODO: Address -> Сделать нахождение расстояния между пунктом А и Б.
			return 1;
		}
	}
}
