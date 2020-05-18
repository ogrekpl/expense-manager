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
		private List<string> categories;

		private string profileName;
		public AddExpenseForm(string profile, DataBase db)
		{
			InitializeComponent();
			profileName = profile;
			dataBase = db;
			categories = dataBase.GetCategories(profileName);
			LoadToPicker();
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
			ExpensesForm form = Application.OpenForms["ExpensesForm"] as ExpensesForm;
			form.RefreshPanel();
			MessageBox.Show("Wydatek został dodany!");
		}

		private void LoadToPicker()
		{
			if (categories != null)
			{
				foreach (string category in categories)
				{
					categoryPicker.Items.Add(category);
				}
			}
		}
	}
}
