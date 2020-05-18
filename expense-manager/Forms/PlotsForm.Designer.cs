namespace expense_manager
{
	partial class PlotsForm
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panelLeft = new System.Windows.Forms.Panel();
			this.pickerDataSub = new System.Windows.Forms.ComboBox();
			this.pickerDate = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pickerType = new System.Windows.Forms.ComboBox();
			this.panel = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.panelLeft.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(6, 12);
			this.chart1.Name = "chart1";
			this.chart1.Size = new System.Drawing.Size(712, 547);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// panelLeft
			// 
			this.panelLeft.Controls.Add(this.pickerDataSub);
			this.panelLeft.Controls.Add(this.pickerDate);
			this.panelLeft.Controls.Add(this.label1);
			this.panelLeft.Controls.Add(this.pickerType);
			this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelLeft.Location = new System.Drawing.Point(0, 0);
			this.panelLeft.Name = "panelLeft";
			this.panelLeft.Size = new System.Drawing.Size(200, 571);
			this.panelLeft.TabIndex = 1;
			// 
			// pickerDataSub
			// 
			this.pickerDataSub.Enabled = false;
			this.pickerDataSub.FormattingEnabled = true;
			this.pickerDataSub.Location = new System.Drawing.Point(33, 137);
			this.pickerDataSub.Name = "pickerDataSub";
			this.pickerDataSub.Size = new System.Drawing.Size(121, 21);
			this.pickerDataSub.TabIndex = 3;
			this.pickerDataSub.SelectedIndexChanged += new System.EventHandler(this.pickerDataSub_SelectedIndexChanged);
			// 
			// pickerDate
			// 
			this.pickerDate.Enabled = false;
			this.pickerDate.FormattingEnabled = true;
			this.pickerDate.Location = new System.Drawing.Point(33, 101);
			this.pickerDate.Name = "pickerDate";
			this.pickerDate.Size = new System.Drawing.Size(121, 21);
			this.pickerDate.TabIndex = 2;
			this.pickerDate.SelectedIndexChanged += new System.EventHandler(this.pickerDate_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(12, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 21);
			this.label1.TabIndex = 1;
			this.label1.Text = "Wybierz typ wykresu:";
			// 
			// pickerType
			// 
			this.pickerType.FormattingEnabled = true;
			this.pickerType.Location = new System.Drawing.Point(33, 63);
			this.pickerType.Name = "pickerType";
			this.pickerType.Size = new System.Drawing.Size(121, 21);
			this.pickerType.TabIndex = 0;
			this.pickerType.SelectedIndexChanged += new System.EventHandler(this.pickerType_SelectedIndexChanged);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.chart1);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(200, 0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(730, 571);
			this.panel.TabIndex = 2;
			// 
			// PlotsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(930, 571);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.panelLeft);
			this.Name = "PlotsForm";
			this.Text = "PlotsForm";
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.panelLeft.ResumeLayout(false);
			this.panelLeft.PerformLayout();
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Panel panelLeft;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox pickerType;
		private System.Windows.Forms.ComboBox pickerDate;
		private System.Windows.Forms.ComboBox pickerDataSub;
	}
}