using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace expense_manager
{
	public partial class Form1 : Form
	{
		private List<string> profilesList = new List<string>();
		DataBase dataBase = new DataBase("expenseManagerDB.db");

		public Form1()
		{
			InitializeComponent();
			LoadProfiles();
			LoadToPicker();
		}

		public void RefreshPicker()
		{
			LoadProfiles();
			ProfilePicker.Items.Clear();
			LoadToPicker();
		}

		private void LoadToPicker()
		{
			foreach (string profileName in profilesList)
			{
				ProfilePicker.Items.Add(profileName);
			}
		}

		private void CreateProfile()
		{
			Form addProfileForm = new AddProfileForm(dataBase);
			addProfileForm.ShowDialog();
		}

		private void LoadProfiles()
		{
			profilesList = dataBase.GetProfiles();
		}

		private void XButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void CreateButton_Click(object sender, EventArgs e)
		{
			CreateProfile();
		}

		private void SelectButton_Click(object sender, EventArgs e)
		{
			if (ProfilePicker.Text.Length > 0)
			{
				Form mainForm = new MainForm(ProfilePicker.Text, dataBase);
				this.Hide();
				mainForm.Show();
			}
		}
	}
}
