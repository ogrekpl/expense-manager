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
	public partial class AddExpenseForm : Form
	{
		private Expense expense;
		private DataBase dataBase;

		private string profileName;
		public AddExpenseForm(string profile, DataBase db)
		{
			InitializeComponent();
			profileName = profile;
			dataBase = db;
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			try
			{
				expense = new Expense(
					Convert.ToDouble(ammountInput.Text), 
					categoryPicker.Text, 
					descriptionInput.Text,
					datePicker.Value.Day,
					datePicker.Value.Month,
					datePicker.Value.Year, 
					profileName); 

				dataBase.AddExpense(expense);
			}
			catch (Exception exception)
			{
				throw exception;
			}
			MainForm form = Application.OpenForms["MainForm"] as MainForm;
			form.RefreshPanel();
			MessageBox.Show("Wydatek został dodany!");
		}
	}
}
