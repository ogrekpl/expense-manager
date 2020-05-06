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
	public partial class AddProfileForm : Form
	{
		private Form1 preForm;
		private DataBase dataBase;
		public AddProfileForm(DataBase dataBase)
		{
			InitializeComponent();
			this.dataBase = dataBase;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form1 form = Application.OpenForms["Form1"] as Form1;
			dataBase.AddProfile(profileNameInput.Text);
			form.RefreshPicker();

		}
	}
}
