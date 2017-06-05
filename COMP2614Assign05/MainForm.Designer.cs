namespace COMP2614Assign05
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.labelYear = new System.Windows.Forms.Label();
			this.textBoxYear = new System.Windows.Forms.TextBox();
			this.textBoxMonth = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxDay = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.labelResult = new System.Windows.Forms.Label();
			this.buttonCheckDate = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// labelYear
			// 
			this.labelYear.AutoSize = true;
			this.labelYear.Location = new System.Drawing.Point(10, 14);
			this.labelYear.Name = "labelYear";
			this.labelYear.Size = new System.Drawing.Size(42, 17);
			this.labelYear.TabIndex = 0;
			this.labelYear.Text = "Year:";
			// 
			// textBoxYear
			// 
			this.textBoxYear.Location = new System.Drawing.Point(13, 34);
			this.textBoxYear.Name = "textBoxYear";
			this.textBoxYear.Size = new System.Drawing.Size(86, 22);
			this.textBoxYear.TabIndex = 1;
			// 
			// textBoxMonth
			// 
			this.textBoxMonth.Location = new System.Drawing.Point(118, 34);
			this.textBoxMonth.Name = "textBoxMonth";
			this.textBoxMonth.Size = new System.Drawing.Size(86, 22);
			this.textBoxMonth.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(115, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Month:";
			// 
			// textBoxDay
			// 
			this.textBoxDay.Location = new System.Drawing.Point(227, 34);
			this.textBoxDay.Name = "textBoxDay";
			this.textBoxDay.Size = new System.Drawing.Size(86, 22);
			this.textBoxDay.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(224, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Day:";
			// 
			// labelResult
			// 
			this.labelResult.AutoSize = true;
			this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelResult.Location = new System.Drawing.Point(13, 100);
			this.labelResult.Name = "labelResult";
			this.labelResult.Size = new System.Drawing.Size(116, 29);
			this.labelResult.TabIndex = 6;
			this.labelResult.Text = "[Results]";
			// 
			// buttonCheckDate
			// 
			this.buttonCheckDate.Location = new System.Drawing.Point(195, 100);
			this.buttonCheckDate.Name = "buttonCheckDate";
			this.buttonCheckDate.Size = new System.Drawing.Size(118, 35);
			this.buttonCheckDate.TabIndex = 7;
			this.buttonCheckDate.Text = "Check Date";
			this.buttonCheckDate.UseVisualStyleBackColor = true;
			this.buttonCheckDate.Click += new System.EventHandler(this.buttonCheckDate_Click);
			// 
			// MainForm
			// 
			this.AcceptButton = this.buttonCheckDate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 157);
			this.Controls.Add(this.buttonCheckDate);
			this.Controls.Add(this.labelResult);
			this.Controls.Add(this.textBoxDay);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxMonth);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxYear);
			this.Controls.Add(this.labelYear);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Date Validator";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelYear;
		private System.Windows.Forms.TextBox textBoxYear;
		private System.Windows.Forms.TextBox textBoxMonth;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxDay;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelResult;
		private System.Windows.Forms.Button buttonCheckDate;
		private System.Windows.Forms.ToolTip toolTip;
	}
}

