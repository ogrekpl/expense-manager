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
		public MainForm()
		{
			InitializeComponent();
		}

		protected override void OnFormClosed(FormClosedEventArgs e)
		{
			Application.OpenForms["Form1"].Close();
			base.OnFormClosed(e);
		}
	}
}
