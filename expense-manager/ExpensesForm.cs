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
	public partial class ExpensesForm : Form
	{
		private DataBase _dataBase;
		public DataBase DataBase => _dataBase;
		private string _profileName;
		public string ProfileName => _profileName;
		public List<Expense> expenses;
		private List<Expense> _expensesOriginal;
		public List<Expense> ExpensesOriginal => _expensesOriginal;
		private int sortAmmClick = -1;
		private int sortDateClick = -1;


		public ExpensesForm(string profile, DataBase db)
		{
			InitializeComponent();
			_profileName = profile;
			_dataBase = db;
			expenses = _dataBase.GetExpenses(_profileName);
			_expensesOriginal = _dataBase.GetExpenses(_profileName);
			LoadExpenseControls(expenses);
		}
		public void RefreshPanel()
		{
			panel1.Controls.Clear();
			expenses = _dataBase.GetExpenses(_profileName);
			LoadExpenseControls(expenses);
		}
		public void RefreshPanelAfterSort()
		{
			panel1.Controls.Clear();
			LoadExpenseControls(expenses);
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

		private void addExpenseButton_Click_1(object sender, EventArgs e)
		{
			Form addExpenseForm = new AddExpenseForm(_profileName, _dataBase);
			addExpenseForm.ShowDialog();
		}

		public List<Expense> FiltrExpensesCategory(List<string> categories)
		{
			List<Expense> expList = new List<Expense>();
			foreach (var category in categories)
			{
				foreach (var exp in ExpensesOriginal)
				{
					if (exp.Category == category)
						expList.Add(exp);
				}
			}

			return expList;
		}

		public void ClearFilrtExpenseCategory()
		{
			expenses = DataBase.GetExpenses(ProfileName);
		}

		private void buttonSortAmmount_Click(object sender, EventArgs e)
		{
			ExpenseCompareAmmHL amComparerHL = new ExpenseCompareAmmHL();
			ExpenseCompareAmmLH amCompareLH = new ExpenseCompareAmmLH();

			if (sortAmmClick == -1)
			{
				expenses.Sort(amCompareLH);
				sortAmmClick += 1;
				sortDateClick = -1;
				buttonSortAmmount.BackColor = Color.FromArgb(70,60,255);
			}
			else if (sortAmmClick == 0)
			{
				expenses.Sort(amComparerHL);
				sortAmmClick += 1;
				sortDateClick = -1;
				buttonSortAmmount.BackColor = Color.FromArgb(76, 236, 120);
			}
			else
			{
				expenses = ExpensesOriginal;
				sortAmmClick = -1;
				sortDateClick = -1;
				buttonSortAmmount.BackColor = Color.FromArgb(255, 255, 0);
			}
			RefreshPanelAfterSort();
		}

		private void buttonSortDate_Click(object sender, EventArgs e)
		{
			ExpenseComaprerDateHL comaprerDateHL = new ExpenseComaprerDateHL();
			ExpenseComaprerDateLH comaprerDateLH = new ExpenseComaprerDateLH();

			if (sortDateClick == -1)
			{
				expenses.Sort(comaprerDateLH);
				sortDateClick += 1;
				sortAmmClick = -1;
				buttonSortDate.BackColor = Color.FromArgb(70,60,255);
			}
			else if (sortDateClick == 0)
			{
				expenses.Sort(comaprerDateHL);
				sortDateClick += 1;
				sortAmmClick = -1;
				buttonSortDate.BackColor = Color.FromArgb(76, 236, 120);
			}
			else
			{
				expenses = ExpensesOriginal;
				sortDateClick = -1;
				sortAmmClick = -1;
				buttonSortDate.BackColor = Color.FromArgb(255, 255, 0);
			}
			RefreshPanelAfterSort();
		}

		private void buttonFiltrDate_Click(object sender, EventArgs e)
		{

		}

		private void buttonFiltrCategory_Click(object sender, EventArgs e)
		{

		}
	}
}
