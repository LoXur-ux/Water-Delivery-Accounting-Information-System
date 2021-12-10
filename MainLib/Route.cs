using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLib
{
	internal class Route
	{
		public Address AddressTo { get; set; }
		public Address AddressFrom { get; set; }
		public double Distance { get; set; }

		public Route(Address addressFrom, Address addressTo)
		{
			AddressFrom = addressFrom;
			AddressTo = addressTo;
			Distance = Address.GetDist(addressFrom, addressTo);
		}
	}
}
