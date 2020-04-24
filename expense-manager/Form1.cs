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
	public partial class Form1 : Form
	{
		private List<string> profilesLisy = new List<string>();
		DataBase d1 = new DataBase("expenseManagerDB.db");

		public Form1()
		{
			InitializeComponent();
		}

		public void LoadToPicker()
		{
			
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}


	}
}
