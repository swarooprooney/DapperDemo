using DapperDemoUI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperDemoUI
{
	public partial class DashBoard : Form
	{
		List<Person> People = new List<Person>();
		public DashBoard()
		{
			InitializeComponent();
			RefreshDataBindings();
		}

		private void RefreshDataBindings()
		{
			listBoxPeopleFound.DataSource = People;
			listBoxPeopleFound.DisplayMember = "PersonInfo";
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			DataAccess dataAccess = new DataAccess();
			People = dataAccess.GetPeople(txtLastName.Text);
			RefreshDataBindings();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtFirstName.Text = txtLastNameEntry.Text = txtEmail.Text = txtPhoneNumber.Text = string.Empty;

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Person person = new Person
			{
				FirstName = txtFirstName.Text,
				LastName = txtLastNameEntry.Text,
				PhoneNumber = txtPhoneNumber.Text,
				Email = txtEmail.Text
			};
			DataAccess dataAccess = new DataAccess();
			dataAccess.InsertPeople(person);
		}
	}
}
