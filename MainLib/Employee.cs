using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLib
{
	internal class Employee : User
	{
		public string PassNumber { get; set; }
		public string PassSeries { get; set; }
		public Post Post { get; set; }
		public DateTime DateOfEmployment { get; set; }
	}
}
