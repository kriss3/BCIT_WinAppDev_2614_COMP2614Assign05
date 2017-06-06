using System;
using System.Drawing;
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
			//two calls: Validator and showResults(bool)
			var result = DateValidator.Validate(textBoxYear.Text,textBoxMonth.Text, textBoxDay.Text);
			showResults(result);
		}

		private void showResults(bool result)
		{
			if (result)
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

		private void textBoxYear_Enter(object sender, EventArgs e)
		{
			(sender as TextBox).SelectAll();
		}
	}
}
