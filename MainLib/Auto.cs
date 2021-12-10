using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLib
{
	internal class Auto
	{
		public string Mark { get; set; }
		public string Model { get; set; }
		public string OSAGO { get; set; }
		public string AutoNumber { get; set; }
		public double AutoVolume { get; set; }

		public Route Route { get; set; }

		public Auto(string mark, string model, string oSAGO, string autoNumber, double autoVolume)
		{
			Mark = mark;
			Model = model;
			OSAGO = oSAGO;
			AutoNumber = autoNumber;
			AutoVolume = autoVolume;
		}
	}
}
