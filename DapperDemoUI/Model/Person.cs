﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemoUI.Model
{
	public class Person
	{
		public int Id { get; set; }
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Email{ get; set; }
		public string PhoneNumber { get; set; }

		public string PersonInfo
		{
			get
			{
				return $"{FirstName} {LastName} ({Email})";
			}
		}
	}
}
