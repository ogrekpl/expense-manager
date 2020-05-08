using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace expense_manager
{
	public partial class ExpenseControl : UserControl
	{
		private Expense _expense;
		public Expense Expense => _expense;

		public ExpenseControl()
		{
			InitializeComponent();
		}
		public ExpenseControl(Expense expense)
		{
			InitializeComponent();
			_expense = expense;
			LoadToLabels();
		}

		public void LoadEpxpense(Expense expense)
		{
			_expense = expense;
		}

		private void LoadToLabels()
		{
			amount_label.Text = Expense.Ammount.ToString() + " zł";
			category_label.Text = Expense.Category;
			description_label.Text = Expense.Description;
			date_label.Text = MakeDate(Expense);
		}

		private string MakeDate(Expense expense)
		{
			string text = "";

			if (expense.Day < 10)
			{
				text += string.Format("0{0}.", expense.Day);
			}
			else
			{
				text += expense.Day.ToString();
			}

			if (expense.Month < 10)
			{
				text += string.Format("0{0}.", expense.Month);
			}
			else
			{
				text += expense.Month.ToString();
			}

			text += expense.Year.ToString();

			return text;
		}

		private void delete_button_Click(object sender, EventArgs e)
		{
			MainForm form = Application.OpenForms["MainForm"] as MainForm;
			form.DataBase.DeleteExpense(Expense.Id);
			form.RefreshPanel();
			MessageBox.Show("Wydatek został pomyslnie usunięty!");
		}

		private void edit_button_Click(object sender, EventArgs e)
		{
			MainForm form = Application.OpenForms["MainForm"] as MainForm;
			Form editExpenseForm = new EditExpenseForm(form.ProfileName, form.DataBase, _expense.Id);
			editExpenseForm.ShowDialog();
		}
	}
}
