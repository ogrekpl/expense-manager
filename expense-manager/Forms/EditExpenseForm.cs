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
	public partial class EditExpenseForm : Form
	{
		private Expense expense;
		private DataBase dataBase;
		private string profileName;
		private int expense_id;
		private List<string> categories;

		public EditExpenseForm(string profile, DataBase db, int expense_id)
		{
			InitializeComponent();
			profileName = profile;
			dataBase = db;
			this.expense_id = expense_id;
			categories = dataBase.GetCategories(profileName);
			LoadToPicker();
		}

		private void editButton_Click(object sender, EventArgs e)
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

				dataBase.UpdateExpense(expense_id, expense);
			}
			catch (Exception exception)
			{
				throw exception;
			}
			ExpensesForm form = Application.OpenForms["ExpensesForm"] as ExpensesForm;
			form.RefreshPanel();
			MessageBox.Show("Wydatek został edytowany!");
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
