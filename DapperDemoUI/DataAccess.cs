using DapperDemoUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace DapperDemoUI
{
	public class DataAccess
	{
		public List<Person> GetPeople(string lastName)
		{
			using (IDbConnection connection = new SqlConnection(DBHelper.GetConnectionString("DefaultConnectionString")))
			{
				return connection.Query<Person>("dbo.GetPeopleByLastName @LastName", new { LastName = lastName }).ToList();
			}
		}

		public void InsertPeople(Person person)
		{
			using (IDbConnection connection = new SqlConnection(DBHelper.GetConnectionString("DefaultConnectionString")))
			{
				connection.Execute("dbo.InsertPeople @FirstName, @LastName, @Email, @PhoneNumber", person);
			}
		}
	}
}
