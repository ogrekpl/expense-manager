using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expense_manager
{
	class PickerOption
	{
		private int _id;
		private string _name;
		public int Id => _id;
		public string Name => _name;

		public PickerOption(int id, string name)
		{
			_name = name;
			_id = id;
		}
		public override string ToString()
		{
			return Name;
		}
	}
}
