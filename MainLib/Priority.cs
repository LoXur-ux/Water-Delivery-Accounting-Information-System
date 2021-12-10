using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLib
{
	public class Priority
	{
		public PriorityLevel PriorityLevel { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal IncreaseCost { get; set; }

		public Priority() { }

	}
}
