using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace expense_manager
{
	public partial class PlotsForm : Form
	{
		private DataBase dataBase;
		private string profileName;
		private List<PlotTypes> plotTypes;
		private List<string> picker2Options;
		private List<PickerOption> pickerDataSubOptions;
		private List<string> yearsList;
		public PlotsForm(DataBase db, string profile)
		{
			InitializeComponent();
			dataBase = db;
			profileName = profile;
			plotTypes = new List<PlotTypes>();
			picker2Options = new List<string>();
			InitPicker();
			InitPicker2();
		}

		//event when index changed draw plot
		private void pickerType_SelectedIndexChanged(object sender, EventArgs e)
		{
			DrawPlot(pickerType.SelectedItem as PlotTypes);
		}

		//event when index changed show more options
		private void pickerDate_SelectedIndexChanged(object sender, EventArgs e)
		{
			InitPicker3();
		}

		//event when index changed draw plot
		private void pickerDataSub_SelectedIndexChanged(object sender, EventArgs e)
		{
			DrawPlot(pickerType.SelectedItem as PlotTypes);
		}

		//iniy plot types avaible
		private void PlotTypesInit()
		{
			plotTypes.Add(new PlotTypes("Liniowy", plotTypes.Count, SeriesChartType.Line));
			plotTypes.Add(new PlotTypes("Słupkowy", plotTypes.Count, SeriesChartType.Column));
			plotTypes.Add(new PlotTypes("Kołowy", plotTypes.Count, SeriesChartType.Pie));
		}

		//init picker1
		private void InitPicker()
		{
			PlotTypesInit();
			foreach (var type in plotTypes)
			{
				pickerType.Items.Add(type);
			}
		}

		//init picker2
		private void InitPicker2()
		{
			picker2Options.Add("Dzień");
			picker2Options.Add("Miesiąc");
			picker2Options.Add("Rok");

			foreach (var option in picker2Options)
			{
				pickerDate.Items.Add(option);
			}
		}

		//init picker3
		private void InitPicker3()
		{
			pickerDataSub.Items.Clear();

			if (pickerDate.Text == "Dzień")
			{
				pickerDataSubOptions = new List<PickerOption>();
				pickerDataSubOptions.Add(new PickerOption(1, "Styczeń"));
				pickerDataSubOptions.Add(new PickerOption(2, "Luty"));
				pickerDataSubOptions.Add(new PickerOption(3, "Marzec"));
				pickerDataSubOptions.Add(new PickerOption(4, "Kwiecień"));
				pickerDataSubOptions.Add(new PickerOption(5, "Maj"));
				pickerDataSubOptions.Add(new PickerOption(6, "Czerwiec"));
				pickerDataSubOptions.Add(new PickerOption(7, "Lipiec"));
				pickerDataSubOptions.Add(new PickerOption(8, "Sierpień"));
				pickerDataSubOptions.Add(new PickerOption(9, "Wrzesień"));
				pickerDataSubOptions.Add(new PickerOption(10, "Październik"));
				pickerDataSubOptions.Add(new PickerOption(11, "Listopad"));
				pickerDataSubOptions.Add(new PickerOption(12, "Grudzień"));

				foreach (var item in pickerDataSubOptions)
				{
					pickerDataSub.Items.Add(item);
				}
				pickerDataSub.Enabled = true;
			}
			else if (pickerDate.Text == "Miesiąc")
			{
				yearsList = dataBase.GetYears(profileName);
				foreach (var year in yearsList)
				{
					pickerDataSub.Items.Add(year);
				}
				pickerDataSub.Enabled = true;
			}
			else
			{
				pickerDataSub.Enabled = false;
			}
		}

		//drawplot - depends of type
		private void DrawPlot(PlotTypes type)
		{
			if (type.Type == SeriesChartType.Pie)
			{
				pickerDate.Enabled = false;
				pickerDataSub.Enabled = false;
				ResetPlot();
				DrawPieChart();
				
			}
			else if (type.Type == SeriesChartType.Column)
			{
				pickerDate.Enabled = false;
				pickerDataSub.Enabled = false;
				ResetPlot();
				DrawColumnChart();
			}
			else if (type.Type == SeriesChartType.Line)
			{
				pickerDate.Enabled = true;
				pickerDataSub.Enabled = true;
				ResetPlot();
				DrawLineChart();
			}
		}

		//Reseting plot for new data
		private void ResetPlot()
		{
			chart1.Series.Clear();
			chart1.Titles.Clear();
			chart1.Legends.Clear();
		}

		//drawing piechart
		private void DrawPieChart()
		{
			string seriesName = "Pie";
			Dictionary<string, double> data = LoadDataToChart();
			if (chart1.Series.IsUniqueName(seriesName))
			{
				chart1.Titles.Add("Wydatki");
				chart1.Titles[0].Font = new Font("Century Gothic", 18);
				chart1.Series.Add(seriesName);
				chart1.Series[seriesName].ChartType = SeriesChartType.Pie;
				chart1.Legends.Add("legend");

				List<string> x = new List<string>();
				List<double> y = new List<double>();

				double sum = 0;
				foreach (var value in data)
				{
					sum += value.Value;
				}

				foreach (var value in data)
				{
					string name = value.Key.ToUpper();
					name += " ";
					string percent = Math.Round(((value.Value / sum) * 100)).ToString();
					name += percent;
					name += "%";
					x.Add(name);
					y.Add(value.Value);
				}
				chart1.Series[seriesName].Points.DataBindXY(x,y);
				chart1.Series[seriesName].Font = new Font("Century Gothic", 12);
				chart1.Legends[0].Title = "Kategorie";
				chart1.Legends[0].Font = new Font("Century Gothic", 12);
				chart1.Legends[0].Enabled = true;
			}
		}

		//drawing columnchart
		private void DrawColumnChart()
		{
			string seriesName = "Column";
			Dictionary<string, double> data = LoadDataToChart();
			if (chart1.Series.IsUniqueName(seriesName))
			{
				chart1.Titles.Add("Wydatki");
				chart1.Titles[0].Font = new Font("Century Gothic", 18);
				chart1.Series.Add(seriesName);
				chart1.Series[seriesName].ChartType = SeriesChartType.Column;
				chart1.Legends.Add("legend");

				List<string> x = new List<string>();
				List<double> y = new List<double>();

				foreach (var value in data)
				{
					x.Add(value.Key.ToUpper());
					y.Add(value.Value);
				}

				chart1.Series[seriesName].Points.DataBindXY(x,y);
				chart1.Series[seriesName].Font = new Font("Century Gothic", 12);
				chart1.Legends[0].Title = "Kategorie";
				chart1.Legends[0].Font = new Font("Century Gothic", 12);
				chart1.Legends[0].Enabled = true;
			}
		}

		//drawing linechart
		private void DrawLineChart()
		{
			Dictionary<int, double> data;
			if (pickerDate.Text == "Rok")
			{
				data = LoadDataToLine(2, 0, 0);
			}
			else if (pickerDate.Text == "Miesiąc")
			{
				//todo : add variable as year 
				int year = 2020;
				data = LoadDataToLine(1, year, 0);
			}
			else
			{
				//todo : add variable as year and month
				int month = 1;
				int year = 2020;
				data = LoadDataToLine(0, month, year);
			}

			//todo: draw chart with series from variable data

			string seriesName = "Line";
			if (chart1.Series.IsUniqueName(seriesName))
			{
				chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Number;
				chart1.ChartAreas[0].AxisX.LabelStyle.Format = "";
				chart1.ChartAreas[0].AxisY.LabelStyle.Format = "";
				chart1.ChartAreas[0].AxisY.LabelStyle.IsEndLabelVisible = true;
				chart1.ChartAreas[0].AxisX.LabelStyle.IsEndLabelVisible = true;

				chart1.Titles.Add("Wydatki");
				chart1.Titles[0].Font = new Font("Century Gothic", 18);
				chart1.Series.Add(seriesName);
				chart1.Series[seriesName].ChartType = SeriesChartType.Line;
				chart1.Legends.Add("legend");
			}
		}

		//create dictionary from database as data for piechart
		private Dictionary<string, double> LoadDataToChart()
		{
			List<Expense> expenses = dataBase.GetExpenses(profileName);
			Dictionary<string, double> data = new Dictionary<string, double>();
			foreach (var expense in expenses)
			{
				if (data.ContainsKey(expense.Category))
				{
					data[expense.Category] += expense.Ammount;
				}
				else
				{
					data.Add(expense.Category, expense.Ammount);
				}
			}

			return data;
		}

		//parm1 0: day, 1: month, 2: year | parm2 : if parm1: 0 - 1-12 (months) of parm1: 1 year{xxxx} for example 2020|
		//parm3: if option: 0 - year {xxxx} 
		private Dictionary<int, double> LoadDataToLine(int parm1, int parm2, int parm3)
		{
			Dictionary<int, double> data = new Dictionary<int, double>();
			List<Expense> expenses = dataBase.GetExpenses(profileName);

			switch (parm1)
			{
				case 0:
				{
					for (int i = 1; i <= DateTime.DaysInMonth(parm3, parm2); i++)
					{
						data.Add(i, 0);
					}

					foreach (var expense in expenses)
					{
						if (expense.Year == parm3 && expense.Month == parm2)
						{
							data[expense.Day] += expense.Ammount;
						}
					}

					return data;
				}
				case 1:
				{
					foreach (var expense in expenses)
					{
						if (expense.Year == parm2)
						{
							if (data.ContainsKey(expense.Month))
							{
								data[expense.Month] += expense.Ammount;
							}
							else
							{
								data.Add(expense.Month, expense.Ammount);
							}
						}
					}

					return data;
				}
				case 2:
				{
					foreach (var expense in expenses)
					{
						if (data.ContainsKey(expense.Year))
						{
							data[expense.Year] += expense.Ammount;
						}
						else
						{
							data.Add(expense.Year, expense.Ammount);
						}
					}
					return data;
				}
				default:
				{
					throw new Exception("Not defined option");
				}
			}
		}

		/*private void WykresLiniowyTemplate()
		{
			var chart = chart1.ChartAreas[0];
			chart.AxisX.IntervalType = DateTimeIntervalType.Number;

			chart.AxisX.LabelStyle.Format = "";
			chart.AxisY.LabelStyle.Format = "";
			chart.AxisY.LabelStyle.IsEndLabelVisible = true;
			chart.AxisX.LabelStyle.IsEndLabelVisible = true;

			chart.AxisX.Minimum = 1;
			chart.AxisX.Maximum = 12;
			chart.AxisY.Minimum = 0;
			chart.AxisY.Maximum = 100;

			chart.AxisX.Interval = 1;
			chart.AxisY.Interval = chart.AxisY.Maximum / 10;

			chart1.Series.Add("test1");
			chart1.Series["test1"].ChartType = SeriesChartType.Line;
			chart1.Series["test1"].Color = Color.Red;
			chart1.Series[0].IsVisibleInLegend = true;

			chart1.Series["test1"].Points.AddXY(1, 1);
			chart1.Series["test1"].Points.AddXY(2, 2);
			chart1.Series["test1"].Points.AddXY(3, 3);
			chart1.Series["test1"].Points.AddXY(4, 4);
			chart1.Series["test1"].Points.AddXY(5, 5);
			chart1.Series["test1"].Points.AddXY(6, 6);
			chart1.Series["test1"].Points.AddXY(11, 11);
		}*/
	}
}
