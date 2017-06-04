using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP2614Assign05
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void buttonCheckDate_Click(object sender, EventArgs e)
		{
			var year = textBoxYear.Text;
			var month = textBoxMonth.Text;
			var day = textBoxDay.Text;
			if (DateValidator.Validate(year, month, day))
			{
				labelResult.ForeColor = Color.Green;
				labelResult.Text = "Valid";
				toolTip.SetToolTip(labelResult, "Entered Date is Valid");
			}
			else
			{
				labelResult.ForeColor = Color.Red;
				labelResult.Text = "Invalid";
				toolTip.SetToolTip(labelResult, "Entered Date is Invalid");
			}

			
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			labelResult.Text = String.Empty;
		}
	}
}
