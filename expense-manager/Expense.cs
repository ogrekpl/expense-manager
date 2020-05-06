using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expense_manager
{
	public class Expense
	{
		private double _ammount;
		public double Ammount => _ammount;
		private string _category;
		public string Category => _category;
		private string _description;
		public string Description => _description;
		private int _month;
		public int Month => _month;
		private int _year;
		public int Year => _year;
		private string _profile;
		public string Profile => _profile;

		public Expense(double ammount, string category, string description, int month, int year, string profile)
		{
			this._ammount = ammount;
			this._category = category;
			this._description = description;
			this._month = month;
			this._year = year;
			this._profile = profile;
		}
	}
}
