using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace expense_manager
{
	class PlotTypes
	{
		public SeriesChartType Type => _type;
		public string Text => _text;
		public int Id => _id;

		private SeriesChartType _type;
		private string _text;
		private int _id;

		public PlotTypes(string text, int id, SeriesChartType type)
		{
			_text = text;
			_type = type;
			_id = id;
		}

		public override string ToString()
		{
			return Text;
		}
	}
}
