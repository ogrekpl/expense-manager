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
	public partial class MainForm : Form
	{
		private DataBase _dataBase;
		public DataBase DataBase => _dataBase;
		private string _profileName;
		public string ProfileName => _profileName;
		private Form activeForm = null;
		public MainForm(string profile, DataBase db)
		{
			InitializeComponent();
			_profileName = profile;
			_dataBase = db;
		}

		private void showSubMenu(Panel subMenu)
		{
			if (!subMenu.Visible)
			{
				subMenu.Visible = true;
			}
			else
			{
				subMenu.Visible = false;
			}
		}

		private void buttonExpenses_Click(object sender, EventArgs e)
		{
			openChildForm(new ExpensesForm(ProfileName, DataBase));
		}

		private void openChildForm(Form childForm)
		{
			if (activeForm != null)
			{
				activeForm.Close();
			}

			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelChildForm.Controls.Add(childForm);
			panelChildForm.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		private void buttonPlots_Click(object sender, EventArgs e)
		{
			openChildForm(new PlotsForm(DataBase, ProfileName));
		}

		private void buttonChangeProfile_Click(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			this.Hide();
			form.Show();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
