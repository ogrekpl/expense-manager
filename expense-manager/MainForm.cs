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
		private List<Expense> expenses;
		public MainForm(string profile, DataBase db)
		{
			InitializeComponent();
			_profileName = profile;
			_dataBase = db;
			expenses = _dataBase.GetExpenses(_profileName);
			LoadExpenseControls(expenses);
		}

		public void RefreshPanel()
		{
			panel1.Controls.Clear();
			expenses = _dataBase.GetExpenses(_profileName);
			LoadExpenseControls(expenses);
		}

		protected override void OnFormClosed(FormClosedEventArgs e)
		{
			Application.OpenForms["Form1"].Close();
			base.OnFormClosed(e);
		}

		private void addExpenseButton_Click(object sender, EventArgs e)
		{
			Form addExpenseForm = new AddExpenseForm(_profileName, _dataBase);
			addExpenseForm.ShowDialog();
		}

		private void LoadExpenseControls(List<Expense> exps)
		{
			foreach (var expense in exps)
			{
				ExpenseControl expenseControl = new ExpenseControl(expense);
				expenseControl.Location = new Point(10, panel1.Controls.Count * (expenseControl.Height + 30));
				panel1.Controls.Add(expenseControl);
			}
		}

		private void AddToPanel(Expense expense)
		{
			ExpenseControl expenseControl = new ExpenseControl(expense);
			expenseControl.Location = new Point(10, panel1.Controls.Count * (expenseControl.Height + 30));
			panel1.Controls.Add(expenseControl);
		}
	}
}
