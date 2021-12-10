using System;

namespace MainLib
{
	public class User
	{
		public string Login { get; set; }
		public string Password { get; set; }
		private string Name { get; set; }
		private string TelNumber { get; set; }
		private DateTime DateOfRegistration { get; set; }


		public User() { }

		public User(string login, string password, string name, string telNumber, DateTime dateOfRegistration)
		{
			Login = login;
			Password = password;
			Name = name;
			TelNumber = telNumber;
			DateOfRegistration = dateOfRegistration;
		}
	}
}
